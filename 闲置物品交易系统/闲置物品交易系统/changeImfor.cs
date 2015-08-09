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
    public partial class changeImfor : Form
    {
        string name;  //获得当前登录用户的名字
        string[] thingName = new string[200];
        string[] pictures = new string[200];
        string[] buyTime = new string[200];
        int i = 0;

        int r;//执行sql语句影响的条数
        public changeImfor()
        {
            InitializeComponent();
        }
        public void showPictureAndName(int m)
        {
            if (i == 0)
            {
                backButton.Enabled = false;
            }
            else
            {
                backButton.Enabled = true;
            }
            if (pictures[m * 4 + 0] != null && (m * 4 + 0) < r)
            {
                pictureBox1.Image = Image.FromFile(pictures[m * 4 + 0]);
                pictureBox1.ImageLocation = pictures[m * 4 + 0];
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                label1.Text = thingName[m * 4 + 0];
                //label1.TextAlign = ContentAlignment.MiddleCenter;
                label5.Text = DateTime.ParseExact(buyTime[m * 4 + 0], "yyyyMMdd", null).ToString("yyyy-MM-dd");
                label5.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox1.Image = null;
                label1.Text = "";
                label5.Text = "";
                pictureBox2.Image = null;
                label2.Text = "";
                label6.Text = "";
                pictureBox3.Image = null;
                label3.Text = "";
                pictureBox4.Image = null;
                label4.Text = "";
                label7.Text = "";
                label8.Text = "";

                return;
            }
            if (pictures[m * 4 + 1] != null && (m * 4 + 1) < r)
            {
                pictureBox2.Image = Image.FromFile(pictures[m * 4 + 1]);
                pictureBox2.ImageLocation = pictures[m * 4 + 1];
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                label2.Text = thingName[m * 4 + 1];
                //label2.TextAlign = ContentAlignment.MiddleCenter;
                label6.Text = DateTime.ParseExact(buyTime[m * 4 + 1], "yyyyMMdd", null).ToString("yyyy-MM-dd");
                label6.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox2.Image = null;
                label2.Text = "";
                label6.Text = "";
                pictureBox3.Image = null;
                label3.Text = "";
                label7.Text = "";
                pictureBox4.Image = null;
                label4.Text = "";
                label8.Text = "";
                return;
            }
            if (pictures[m * 4 + 2] != null && (m * 4 + 2) < r)
            {
                pictureBox3.Image = Image.FromFile(pictures[m * 4 + 2]);
                pictureBox3.ImageLocation = pictures[m * 4 + 2];
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                label3.Text = thingName[m * 4 + 2];
                //label3.TextAlign = ContentAlignment.MiddleCenter;
                label7.Text = DateTime.ParseExact(buyTime[m * 4 + 2], "yyyyMMdd", null).ToString("yyyy-MM-dd");
                label7.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox3.Image = null;
                label3.Text = "";
                label7.Text = "";
                pictureBox4.Image = null;
                label4.Text = "";
                label8.Text = "";
                return;
            }
            if (pictures[m * 4 + 3] != null && (m * 4 + 3) < r)
            {
                pictureBox4.Image = Image.FromFile(pictures[m * 4 + 3]);
                pictureBox4.ImageLocation = pictures[m * 4 + 3];
                pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                label4.Text = thingName[m * 4 + 3];
                label8.Text = DateTime.ParseExact(buyTime[m * 4 + 3], "yyyyMMdd", null).ToString("yyyy-MM-dd");
                label8.TextAlign = ContentAlignment.MiddleCenter;
                if (r % 4 == 0 && (m + 1) >= (r / 4))
                {
                    nextButton.Enabled = false;
                }
                else
                {
                    nextButton.Enabled = true;
                }

            }
            else
            {
                nextButton.Enabled = false;
                pictureBox4.Image = null;
                label4.Text = "";
                label8.Text = "";
                return;
            }
        }

        public void selectData(string sql1)
        {

            string con = "", sql = sql1;
            if (i == 0)
            {
                backButton.Enabled = false;
            }
            else
            {
                backButton.Enabled = true;
            }
            int h = 0;
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            SqlCommand myCom = new SqlCommand(sql, myCon);
            SqlDataReader myReader = myCom.ExecuteReader();
            r = 0;
            while (myReader.Read())
            {

                pictures[h] = myReader.GetString(0);
                buyTime[h] = myReader.GetString(1);
                thingName[h] = myReader.GetString(2);
                h++;
                r++;
            }
            if (r == 4)
            {
                nextButton.Enabled = false;
            }

            myCon.Close();
            showPictureAndName(i);

        }
        private void changeImfor_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 150);
            this.Location = new Point(300, 150);
            string con = "", _sql = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            _sql = "select * from stayUser";
            SqlCommand myCom = new SqlCommand(_sql, myCon);
            SqlDataReader myReader = myCom.ExecuteReader();
            while (myReader.Read())
            {
                name = myReader.GetString(0);
            }
            myCon.Close();
            selectData(string.Format("select Tpic,Time,Tname from thing where Uname = '{0}'", name));
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            i--;
            showPictureAndName(i);
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            i++;
            showPictureAndName(i);
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox1.ImageLocation+'1';
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox2.ImageLocation+'1';
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox3.ImageLocation+'1';
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox4.ImageLocation+'1';
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void changeImfor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

    }
}
