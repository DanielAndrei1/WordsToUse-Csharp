using Microsoft.Win32;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Speech.Synthesis;
using WordsToUseML.Model;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace WordsToUse
{
    public partial class Form1 : Form 
    {
        DataView myView;

        public Form1()
        {

            InitializeComponent();

            MyMethod();
        }

        public void MyMethod()
        {
            string connetionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dany\source\repos\WordsToUse\WordsToUse\WordsTOUse.mdb";

            try
            {
                connection = new OleDbConnection(connetionString);
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Select * from Words";
                DataTable data = new DataTable();
                data.Clear();
                oledbAdapter = new OleDbDataAdapter(command);
                oledbAdapter.Fill(data);
                DataSet.DataSource = data;
                connection.Close();
                myView = data.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        


        private void AddWordClick(object sender, EventArgs e)
        {


            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dany\source\repos\WordsToUse\WordsToUse\WordsTOUse.mdb";

            String Word = textBox1.Text;

            OleDbCommand cmd = new OleDbCommand("INSERT into Words (Words) Values(@Word)");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@Word", OleDbType.VarChar).Value = Word;

                try
                {
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Data Added");
                    conn.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Source);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }

            MyMethod();
        }

        

        

        private void DataSet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wordsTOUseDataSet4.Words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.wordsTOUseDataSet4.Words);
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("My application", Application.ExecutablePath.ToString());
            MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void elevatorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random slumpGenerator = new Random();
            // Or whatever limits you want... Next() returns a double
            int count = DataSet.Rows.GetRowCount(DataGridViewElementStates.Visible);
            int tal = slumpGenerator.Next(1, count);
            textBox2.Text = tal.ToString();
           

           OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dany\source\repos\WordsToUse\WordsToUse\WordsTOUse.mdb";

            String id = textBox2.Text;

            OleDbCommand cmd = new OleDbCommand("select * from Words WHERE [ID] = " + id + " ");
            cmd.Connection = conn;
            OleDbDataReader dr = null;

            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox3.Text = (dr["Words"].ToString());
               
            }
            conn.Close();
            ss = new SpeechSynthesizer();
            ss.SpeakAsync(textBox3.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyMethod();

        }
        private void button3_Click(object sender, EventArgs e)
        {


            object a = DataSet.CurrentCell.Value;
            string mya = a.ToString();
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Dany\source\repos\WordsToUse\WordsToUse\WordsTOUse.mdb";

            OleDbCommand delcmd = new OleDbCommand();


            delcmd.CommandText = "DELETE FROM Words WHERE ID=" + a + "";
                conn.Open();
                delcmd.Connection = conn;
                delcmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Row Deleted");
            MyMethod();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }
        SpeechSynthesizer ss;
        private void Btnread_Click(object sender, EventArgs e)
        {

           object a = DataSet.CurrentCell.Value;
            string mya = a.ToString();
            ss = new SpeechSynthesizer();
            ss.Rate = trkSpeed.Value;
            ss.Volume = trkvolume.Value;

          

            ss.SpeakAsync(mya);
            DataSet.ClearSelection();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataSet_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //This method is fired by the KeyUp event handler on the textbox.
        //The purpose of this method is to take the text or number from the search
        //box, split it up into words, and then create and assign a filter
        //statement that will do a LIKE comparison on each of the selected
        //search fields. Each word's filter statement is AND'ed together
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            string outputInfo = "";
            string[] keyWords = textBox4.Text.Split(' ');

            foreach (string word in keyWords)
            {
                if (outputInfo.Length == 0)
                {
                    outputInfo = "(Words LIKE '%" + word + "%' OR convert(ID, 'System.String') LIKE '%" + word + "%')";
                }
                else
                {
                    outputInfo += " AND (Words LIKE '%" + word + "%' OR convert(ID, 'System.String') LIKE '%" + word + "%')";
                }
                MyMethod();
                myView.RowFilter = outputInfo;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FriendConnect_Click(object sender, EventArgs e)
        {

            this.Hide();
            Friend friendConnectionChat = new Friend();
            friendConnectionChat.Show();



        }

        

        private void LanguageTranslate_Enter(object sender, EventArgs e)
        {

        }
        
       
        private void button1_Click_1(object sender, EventArgs e)
        {
           ;
          


        }
    }
}


