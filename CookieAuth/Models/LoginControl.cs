namespace CookieAuth.Models
{
    public class LoginControl
    {
        public bool LoginUserControl(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public bool LoginUserControlInDatabase(string username, string password)
        //{
        //    if (true)
        //    {

        //    }
        //}
    }
}
