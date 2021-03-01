using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
 


namespace Furry_Community
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        string StrConnection = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Furry_Community;Data Source=DESKTOP-4UPDGGT\SQLEXPRESS";
        



        private void button3_Click(object sender, EventArgs e)
        {
            MyGrid.DataSource = MyDataSet.Tables["Table3"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyGrid.DataSource = MyDataSet.Tables["Table5"];
        }

        private void Label_title_Click(object sender, EventArgs e)
        {

        }
        DataSet MyDataSet = new DataSet("Furry_Community");
        private void button1_Click(object sender, EventArgs e)
        {
            MyGrid.DataSource = MyDataSet.Tables["engineering.it_is_me"];
            
        }
        OleDbDataAdapter MyDataAdapter1;
        OleDbDataAdapter MyAdapter2;
        OleDbDataAdapter adapter3;
        OleDbDataAdapter MyAdapter4;
        OleDbDataAdapter Myadapter5;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //для первой кнопки таблица
                OleDbConnection connection = new OleDbConnection(StrConnection);


                DataTable t_allOfMe = new DataTable("engineering.it_is_me");
                MyDataAdapter1 = new OleDbDataAdapter("SELECT * FROM  [engineering].[it_is_me];", connection);
                MyDataSet.Tables.Add(t_allOfMe);
                MyDataAdapter1.Fill(MyDataSet.Tables["engineering.it_is_me"]);
                OleDbCommandBuilder AllComands = new OleDbCommandBuilder(MyDataAdapter1);


                //для второй кнопки таблица
                DataTable t_myHelp = new DataTable("t_MyHelp");
                MyAdapter2 = new OleDbDataAdapter("SELECT * FROM   [HELP].[help];", connection);
                MyDataSet.Tables.Add(t_myHelp);
                MyAdapter2.Fill(MyDataSet.Tables["t_MyHelp"]);
                OleDbCommandBuilder AllComands2 = new OleDbCommandBuilder(MyAdapter2);



                // для третьей кнопки
                DataTable table_3 = new DataTable("Table3");
                adapter3 = new OleDbDataAdapter("SELECT * FROM [HELP].[I_found];", connection);
                MyDataSet.Tables.Add(table_3);
                adapter3.Fill(MyDataSet.Tables["Table3"]);
                OleDbCommandBuilder AllComands3 = new OleDbCommandBuilder(adapter3);

                //для четвертой кнопки
                DataTable table4 = new DataTable("Table4");
                MyAdapter4 = new OleDbDataAdapter("SELECT * FROM [SHELTER].[id_shelter];", connection);
                MyDataSet.Tables.Add(table4);
                MyAdapter4.Fill(MyDataSet.Tables["Table4"]);
                OleDbCommandBuilder AllComands4 = new OleDbCommandBuilder(MyAdapter4);
                //для пятой кнопки
                DataTable table5 = new DataTable("Table5");
                Myadapter5 = new OleDbDataAdapter(" SELECT * FROM [HELP].[I_have_lost];", connection);
                MyDataSet.Tables.Add(table5);
                Myadapter5.Fill(MyDataSet.Tables["Table5"]);
                OleDbCommandBuilder AllComands5 = new OleDbCommandBuilder(Myadapter5);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Исключение");
            }
        }

         

        private void button2_Click(object sender, EventArgs e)
        {
             
            MyGrid.DataSource = MyDataSet.Tables["t_MyHelp"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyGrid.DataSource = MyDataSet.Tables["Table4"];
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                MyDataSet.EndInit();
                MyDataAdapter1.Update(MyDataSet.Tables["engineering.it_is_me"]);
                MyAdapter2.Update(MyDataSet.Tables["t_MyHelp"]);
                adapter3.Update(MyDataSet.Tables["Table3"]);
                MyAdapter4.Update(MyDataSet.Tables["Table4"]);
                Myadapter5.Update(MyDataSet.Tables["Table5"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
