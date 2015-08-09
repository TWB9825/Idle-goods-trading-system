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
    public partial class BuyForm : Form
    {
        string Uname = "";
        string flag1 = "";
        string link = "";
        public BuyForm()
        {
            InitializeComponent();
        }

        //显示发布者的信息
        public void showUserImfor()
        {
            string con = "", sql = "";
            string phone = "", place = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            sql = string.Format("select Uphone,Uschool from usr where Uname = '{0}'",Uname);
            SqlCommand myCom = new SqlCommand(sql, myCon);
            SqlDataReader myReader = myCom.ExecuteReader();
            while(myReader.Read())
            {
                phone = myReader.GetString(0);
                place = myReader.GetString(1);
            }
            phoneLabel.Text = phone;
            schoolLabel.Text = place;
        }
        /*加载的时候显示物品信息*/
        private void BuyForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 150);
            string con = "", sql = "";
            string Tname = "", Tintro = "", Tpic = "", Time = "";
            float Tprice = 0;
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            sql = "select * from pitureTable";
            SqlCommand myCom = new SqlCommand(sql, myCon);
            SqlDataReader myReader = myCom.ExecuteReader();
            //获得购买的物品图片的链接
            while (myReader.Read())
            {
                link = myReader.GetString(0);
            }
            myCon.Close();
            myCon.Open();
            flag1 = link.Substring(link.Length - 1, 1);
            if (flag1=="0")
            {
                link = link.Substring(0, link.Length - 1);
                sql = "select * from thing";
            }
            else if(flag1 == "1")
            {
                link = link.Substring(0, link.Length - 1);
                sql = "select * from thing";
            }
            else
            {
                sql = "select * from BoughtTable";
            }

            SqlCommand myCom1 = new SqlCommand(sql, myCon);
            SqlDataReader myReader1 = myCom1.ExecuteReader();
            while(myReader1.Read())
            {
                if(myReader1.GetString(3) == link)
                {
                    Uname = myReader1.GetString(0);
                    Tname = myReader1.GetString(1);
                    Tintro = myReader1.GetString(2);
                    Tpic = myReader1.GetString(3);
                    Time = myReader1.GetString(4);
                    Tprice = float.Parse(myReader1.GetValue(5).ToString());
                }
            }
            myCon.Close();
            pictureBox1.Image = Image.FromFile(Tpic);
            textBox1.Text = Tintro;
            priceLabel.Text = string.Format("¥{0}",Tprice);
            nameLable.Text = Tname;
            userLabel.Text = Uname;
            Time = DateTime.ParseExact(Time, "yyyyMMdd", null).ToString("yyyy-MM-dd");
            dateLabel.Text = Time;
            if(flag1!="0"&&flag1!="1")
            {
                button1.Enabled = false;
                button1.Visible = false;
                button2.Enabled = false;
                button2.Visible = false;
                button3.Enabled = false;
                button3.Visible = false;
            }
            else if(flag1 == "1")
            {
                button1.Enabled = false;
                button1.Visible = false;
            }
            else if(flag1 == "0")
            {
                button2.Enabled = false;
                button2.Visible = false;
                button3.Enabled = false;
                button3.Visible = false;
            }
            showUserImfor();
        }

        private void BuyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(flag1 == "0")
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
            else if(flag1 == "1")
            {
                changeImfor chanInfo = new changeImfor();
                chanInfo.Show();
            }
            else
            {
                jiaoYiJiLu jilu = new jiaoYiJiLu();
                jilu.Show();
            }
            this.Hide();
        }

        //将购买的信息放到BoughtTable表里
        public void WriteToBoughtTable()
        {
            string con = "", sql = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            sql = string.Format(" INSERT INTO  BoughtTable select * FROM thing where  Tpic = '{0}';delete  from thing where Tpic = '{1}'", link,link);
            SqlCommand myCom = new SqlCommand(sql, myCon);
            myCom.ExecuteNonQuery();
            myCon.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string con = "", sql = "",Uname = "",BuyName = "",buyTime = "";
            buyTime = DateTime.Now.ToString("yyyyMMdd");
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();

            //获得购买人
            sql = "select * from stayUser";
            SqlCommand myCom = new SqlCommand(sql, myCon);
            SqlDataReader myReader = myCom.ExecuteReader();
            while(myReader.Read())
            {
                BuyName = myReader.GetString(0);
            }
            myCon.Close();
            myCon.Open();
            sql = "select * from thing";
            SqlCommand myCom1 = new SqlCommand(sql, myCon);
            SqlDataReader myReader1 = myCom1.ExecuteReader();
            while (myReader1.Read())
            {
                if (myReader1.GetString(3) == link)
                {
                    Uname = myReader1.GetString(0);                   
                }
            }
            myCon.Close();
            myCon.Open();
            //将信息写到购买记录表里
            sql = string.Format("insert into BuyTable values('{0}','{1}','{2}','{3}')", Uname, BuyName, buyTime, link);
            SqlCommand myCom2 = new SqlCommand(sql, myCon);
            myCom2.ExecuteNonQuery();
            myCon.Close();
            WriteToBoughtTable();
            MessageBox.Show("购买成功！");
        }

        private void userLabel_Click(object sender, EventArgs e)
        {
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
            insertIntoData(string.Format("{0}0",link));
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string con = "", sql = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            sql = string.Format("delete from pitureTable;delete from thing where Tpic = '{0}'", link);
            SqlCommand myCom = new SqlCommand(sql, myCon);
            myCom.ExecuteNonQuery();
            myCon.Close();
            MessageBox.Show("删除成功!");
            changeImfor chanInfo = new changeImfor();
            chanInfo.Show();
            this.Hide();
        }
    }
}
