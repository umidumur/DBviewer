using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DBviewer
{
    public partial class Login : Form
    {
        public DataB db;
        public Login()
        {
            InitializeComponent();
            db = new DataB();
        }

        public class DataB
        {
            public string constring;
            MySqlConnection connection;
            public void buildConnectionString()
            {
                constring = "Server=" + Main.Database.servername + "; Database=" + Main.Database.database + "; User ID=" + Main.Database.username + "; Password=" + Main.Database.password + "; Convert Zero Datetime=True";
                connection = new MySqlConnection(constring);
            }
            public void openConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
            }

            public void closeConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open) connection.Close();
            }

            public MySqlConnection getConnection()
            {
                return connection;
            }
        }
    

        public void button1_Click(object sender, EventArgs e)
        {
            Main.Database.servername = textBox1.Text;
            Main.Database.username = textBox2.Text;
            Main.Database.password = textBox3.Text;
            Main.Database.database = textBox4.Text;
            db.buildConnectionString();
            db.openConnection();
            if (db.getConnection() != null)
            {
                MessageBox.Show("Connection succesfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.closeConnection();
                Close();
            }    
            
        }
    }
}
