using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBviewer
{
    public partial class Main : Form
    {
        public Database DB;
        private DataTable table;
        private MySqlDataAdapter adapter;

        public class Database
        {
            public static string servername;
            public static string username;
            public static string password;
            public static string database;
            public string constring;

            MySqlConnection connection;
            public void buildConnectionString()
            {
                constring = "Server=" + servername + "; Database=" + database + "; User ID=" + username + "; Password=" + password+ "; Convert Zero Datetime=True";
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

        public Main()
        {
            InitializeComponent();
            DB = new Database();
            table = new DataTable();
            adapter = new MySqlDataAdapter();
        }




        private void clearAll()
        {
            table = new DataTable();
        }

        private void sqlcmd(string commandstring)
        {
            clearAll();
            DB.buildConnectionString();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand(commandstring, DB.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            DB.closeConnection();
        }

        private void loadTSButton_Click(object sender, EventArgs e)
        {
            treeViewTables();
        }

        private void saveTSButton_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            DataTable changedRows = table.GetChanges();
            if (changedRows != null)
            {
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                adapter.Update(changedRows);
                table.AcceptChanges();
                MessageBox.Show("Changes saved");
            }
        }

        private void newTSButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            sqlcmd("SELECT * FROM " + selectTextBox.Text);
        }

        private void exeButton_Click(object sender, EventArgs e)
        {
            sqlcmd(commandTextBox.Text);
            commandTextBox.Text = "";
        }

        public string firsttable;

        private void treeViewTables()
        {
            string tablename;;
            int k = 0;
            treeView.Nodes.Clear();
            DB.buildConnectionString();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand("SHOW TABLES", DB.getConnection());
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                TreeNode node1 = new TreeNode();
                tablename = Convert.ToString(dataReader["Tables_in_warhouse"]);
                if (k == 0)
                {
                    node1 = treeView.Nodes.Add("Tables in database");
                    firsttable = tablename;
                }
                treeView.SelectedNode = node1;
                treeView.SelectedNode.Nodes.Add(tablename);
                k++;
            }
            DB.closeConnection();
            sqlcmd($"SELECT * FROM {firsttable}");
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((firsttable != null) & (treeView.SelectedNode.Text != "Tables in database")) 
            {
                sqlcmd($"SELECT * FROM {treeView.SelectedNode.Text}");
            }
        }

        private void invButton_Click(object sender, EventArgs e)
        {
            clearAll();
            DB.buildConnectionString();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand("invByType", DB.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            DB.closeConnection();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            clearAll();
            DB.buildConnectionString();
            DB.openConnection();
            MySqlCommand command = new MySqlCommand("supply", DB.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@product", MySqlDbType.VarChar).Value = Convert.ToInt32(textBox1.Text);
            command.Parameters.AddWithValue("@supplier", MySqlDbType.VarChar).Value = Convert.ToInt32(textBox2.Text);
            command.Parameters.AddWithValue("@amount", MySqlDbType.VarChar).Value = Convert.ToInt32(textBox3.Text);
            if (command.ExecuteNonQuery() > 0)
            {
                sqlcmd("SELECT * FROM supplies");
                MessageBox.Show("Supply added succesfully","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else 
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                MessageBox.Show("There is error, please check parameters","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            DB.closeConnection();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void aboutTSButton_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }
    }
}
