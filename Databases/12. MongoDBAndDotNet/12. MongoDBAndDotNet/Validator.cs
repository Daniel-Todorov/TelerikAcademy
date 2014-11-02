namespace _12.MongoDBAndDotNet
{
    public class Validator
    {
        public static bool IsValidUsername(string userName){
            if (string.IsNullOrEmpty(userName) || userName.Trim().Length < 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
