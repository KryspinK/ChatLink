using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ChatLink
{
    class DBconnection
    {

        private MySqlConnection connection;
        
        private string server;
        private string database;
        private string uid;
        private string password;
        private bool isCon = false;

        public DBconnection()
        {
            Init();
        }

        private void Init(string server, string database, string uid)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
        }

        private void Init()
        {
            server = "127.0.0.1";
            database = "sys";
            uid = "root";
            password = "kkkk";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            OpenConnection();
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection Successfull");
                isCon = true;
                return true;
            }
            catch(MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to the server");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid Username/Password, Please Try again");
                        break;

                }
                return false;


            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Connection Closed");
                isCon = false;
                return true;
            }
            catch (MySqlException)
            {
                Console.WriteLine("Connection could not close");
                return false;
            }
        }

        public void getUsers()
        {
            string Query = "SELECT * FROM sys.user;";

            MySqlCommand cmd = new MySqlCommand(Query,connection);
            MySqlDataReader MyReader;

            

                if (isCon == true)
                {
                    MyReader = cmd.ExecuteReader();

                    while (MyReader.Read())
                    {
                    int i = Convert.ToInt16(MyReader.GetValue(0));
                    User u = new User(i, MyReader.GetValue(1).ToString(), null);
                    // string txt = MyReader.GetValue(0).ToString() + " " + MyReader.GetValue(1).ToString();
                    //string txt = u.getId() + " " + u.getFirstName() + " " + u.getSecondName();
                    
                    Console.WriteLine(u);
                    }
                MyReader.Close();
                }
            else
            {

                Console.WriteLine("Not Connected to server");

            }

        }


        public bool getIsConnect()
        {
            return isCon;
        }


    }
}
