//02. Using transactions write a method which retrieves 
//some money (for example $200) from certain 
//account. The retrieval is successful when the 
//following sequence of sub-operations is completed 
//successfully:
// A query checks if the given CardPIN and CardNumber
//are valid.
// The amount on the account (CardCash) is evaluated 
//to see whether it is bigger than the requested sum 
//(more than $200).
// The ATM machine pays the required sum (e.g. $200) 
//and stores in the table CardAccounts the new 
//amount (CardCash = CardCash - 200).

//03. Extend the project from the previous exercise and 
//add a new table TransactionsHistory with fields
//(Id, CardNumber, TransactionDate, Ammount) 
//containing information about all money retrievals on 
//all accounts.
//Modify the program logic so that it saves historical 
//information (logs) in the new table after each 
//successful money withdrawal.
//What should the isolation level be for the 
//transaction?

using System;
using System.Data;
using System.Data.SqlClient;

public class ConsoleClient
{
    public static void Main()
    {
        string sampleCardNumber = "18392hd27f";
        string sampleCardPIN = "0000";
        decimal sampleWithdraw = 200M;

        string serverName = "."; //Change this to your server
        string databaseName = "ATM"; //Make sure you have the databased installed
        string connectionString = string.Format("Server={0}; Database={1}; Integrated Security=true", serverName, databaseName);
        SqlConnection context = new SqlConnection(connectionString);
        context.Open();

        using (context)
        {
            //RepeatableRead because we don't want someone else touching our row. We don't care if people insert new rows as long as they don't touch ours.
            //For 03. Problem it may be wiser to use IsolationLevel.Serializable to avoid the phantom rows.
            SqlTransaction transaction = context.BeginTransaction(IsolationLevel.RepeatableRead); 

            SqlCommand numberOfMatches = new SqlCommand("SELECT COUNT(*) FROM [CardAccounts] WHERE [CardNumber] = @cardNumber AND [CardPIN] = @cardPIN", context);
            numberOfMatches.Parameters.AddWithValue("@cardNumber", sampleCardNumber);
            numberOfMatches.Parameters.AddWithValue("@cardPIN", sampleCardPIN);

            SqlCommand getCash = new SqlCommand("SELECT [CardCash] FROM [CardAccounts] WHERE [CardNumber] = @cardNumber AND [CardPIN] = @cardPIN", context);
            getCash.Parameters.AddWithValue("@cardNumber", sampleCardNumber);
            getCash.Parameters.AddWithValue("@cardPIN", sampleCardPIN);

            SqlCommand updateCash = new SqlCommand("UPDATE [CardAccounts] SET [CardCash] = @newCash WHERE [CardNumber] = @cardNumber AND [CardPIN] = @cardPIN", context);
            updateCash.Parameters.AddWithValue("@cardNumber", sampleCardNumber);
            updateCash.Parameters.AddWithValue("@cardPIN", sampleCardPIN);

            SqlCommand makeLog = new SqlCommand("INSERT INTO [TransactionHistory] ([CardNumber], [CardPIN], [TransactionDate], [Ammount]) VALUES (@cardNumber, @cardPIN, @transactionDate, @ammount)", context);
            makeLog.Parameters.AddWithValue("@cardNumber", sampleCardNumber);
            makeLog.Parameters.AddWithValue("@cardPIN", sampleCardPIN);
            makeLog.Parameters.AddWithValue("@transactionDate", DateTime.Now);
            makeLog.Parameters.AddWithValue("@ammount", sampleWithdraw);

            numberOfMatches.Transaction = transaction;
            getCash.Transaction = transaction;
            updateCash.Transaction = transaction;
            makeLog.Transaction = transaction;

            try
            {
                if ((int)numberOfMatches.ExecuteScalar() != 1)
                {
                    throw new InvalidOperationException("Card number and PIN does not match.");
                }

                var cash = (decimal) getCash.ExecuteScalar();

                if (cash < sampleWithdraw)
                {
                    throw new InvalidOperationException("Card cash is lower than the requested withdrawal.");
                }

                decimal newCash = decimal.Parse(cash.ToString()) - sampleWithdraw;
                updateCash.Parameters.AddWithValue("@newCash", newCash);

                var updatedRows = updateCash.ExecuteNonQuery();

                if (updatedRows != 1)
                {
                    throw new InvalidOperationException("The withdrawal could not complete properly.");
                }

                //03. Add record
                var result = makeLog.ExecuteNonQuery();

                if (result != 1)
                {
                    throw new InvalidOperationException("The withdrawal could not be logged.");
                }

                transaction.Commit();
                Console.WriteLine("Transaction completed");
            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine(e.Message);
            }
        }
    }
}
