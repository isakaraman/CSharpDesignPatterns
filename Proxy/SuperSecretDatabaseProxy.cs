using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    internal class SuperSecretDatabaseProxy : ISuperSecretDatabase
    {
        private SuperSecretDatabase superSecretDatabase;
        private string _databaseName;
        private string _password;

        public SuperSecretDatabaseProxy(string databaseName,string password)
        {
            _databaseName = databaseName;
            _password = password;
        }

        public void DisplayDatabaseName()
        {
            if (_password.Equals("Password"))
            {
                if(superSecretDatabase == null)
                {
                    superSecretDatabase = new SuperSecretDatabase(_databaseName);
                }
                superSecretDatabase.DisplayDatabaseName();
            }
        }
    }
}
