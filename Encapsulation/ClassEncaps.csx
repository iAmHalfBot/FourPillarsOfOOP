public class Account
{
    private class PasswordManager
    {
        private string _password;

        public PasswordManager(string password)
        {
            _password = password;
        }
        
        public bool PassChecker(string input)
        {
            return _password == input;
        }
    } 

    private string _username;
    
    private PasswordManager _passwordManager;
    
    public Account(string username, string password)
    {
        _username = username;

        _passwordManager = new PasswordManager(password);
    }

    public bool login(string password)
    {
        return _passwordManager.PassChecker(password);
    }

}

