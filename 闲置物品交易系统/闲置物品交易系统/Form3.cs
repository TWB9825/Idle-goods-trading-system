using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 闲置物品交易系统
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 150);
            string con, sql = "";
            string name = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            sql = string.Format("select * from stayUser");
            //sql = "select * from usr_table";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            SqlCommand myCom = new SqlCommand(sql, myCon);
            SqlDataReader myReader = myCom.ExecuteReader();
            while(myReader.Read())
            {
                name = myReader.GetString(0);
            }
            myCon.Close();
            label1.Text = string.Format("{0},欢迎您", name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        public void insertIntoData(string picLink)
        {
            string con = "", sql = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            sql = string.Format("delete from pitureTable;insert into pitureTable values('{0}')", picLink);
            SqlCommand myCom = new SqlCommand(sql, myCon);
            myCom.ExecuteNonQuery();
            myCon.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            insertIntoData("1");
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jiaoYiJiLu form = new jiaoYiJiLu();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeImfor chanInfo = new changeImfor();
            chanInfo.Show();
            this.Hide();
        }
    }
}
