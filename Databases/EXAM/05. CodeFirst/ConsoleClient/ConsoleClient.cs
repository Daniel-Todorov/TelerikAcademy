namespace ConsoleClient
{
    using CarsModel;

    public class ConsoleClient
    {
        public static void Main()
        {
            //NOTE!!! I use SQL server. If you use SQLEXPRESS, please, change the connection string in all App.config files in the solution.

            var db = new CarEntities();
            db.Configuration.AutoDetectChangesEnabled = false;

            //NOTE!!! This is extremely slow operation to run over all of the json files.
            //The json files are in the debug folder of the ConsoleClient.
            var importer = new JsonImporter();
            importer.AddData("JsonData", db);
        }
    }
}