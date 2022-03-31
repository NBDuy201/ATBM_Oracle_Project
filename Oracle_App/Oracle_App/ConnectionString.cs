using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_App
{
    class ConnectionString
    {
        public string UserID { get; set; }
        public string Password { get; set; }

        public ConnectionString(string userID, string password)
        {
            this.UserID = userID;
            this.Password = password;
        }

        public override string ToString()
        {
            return string.Format("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = xepdb1)));" +
                "User ID={0};" +
                "Password={1}", UserID, Password);
        }
    }
}
