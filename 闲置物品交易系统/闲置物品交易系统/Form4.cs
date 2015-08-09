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
    public partial class Form4 : Form
    {
        int haha = 0;
        string name = "";
        string[] pictures = new string[200];    //用于获得图片的路径
        string[] thingName = new string[200];  //用于获得物品的名称
        int i=0;
        int r;//执行sql语句影响的条数
        public Form4()
        {
            InitializeComponent();
        }

        //用于显示图片和名称
        public void showPictureAndName(int m)
        {
            if(i == 0)
            {
                backButton.Enabled = false;
            }
            else
            {
                backButton.Enabled = true;
            }
            //*************加载图片和名字****************
            if (pictures[m * 8 + 0] != null && (m * 8 + 0) < r)
            {
                pictureBox1.Image = Image.FromFile(pictures[m * 8 + 0]);
                pictureBox1.ImageLocation = pictures[m * 8 + 0];
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                label1.Text = thingName[m * 8 + 0];
                label1.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox1.Image = null;
                label1.Text = "";
                pictureBox2.Image = null;
                label2.Text = "";
                pictureBox3.Image = null;
                label3.Text = "";
                pictureBox4.Image = null;
                label4.Text = "";
                pictureBox5.Image = null;
                label5.Text = "";
                pictureBox6.Image = null;
                label6.Text = "";
                pictureBox7.Image = null;
                label7.Text = "";
                pictureBox8.Image = null;
                label8.Text = "";
                return;
            }
            if (pictures[m * 8 + 1] != null && (m * 8 + 1) < r)
            {
                pictureBox2.Image = Image.FromFile(pictures[m * 8 + 1]);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.ImageLocation = pictures[m * 8 + 1];
                label2.Text = thingName[m * 8 + 1];
                label2.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox2.Image = null;
                label2.Text = "";
                pictureBox3.Image = null;
                label3.Text = "";
                pictureBox4.Image = null;
                label4.Text = "";
                pictureBox5.Image = null;
                label5.Text = "";
                pictureBox6.Image = null;
                label6.Text = "";
                pictureBox7.Image = null;
                label7.Text = "";
                pictureBox8.Image = null;
                label8.Text = "";
                return;
            }
            if (pictures[m * 8 + 2] != null && (m * 8 + 2) < r)
            {
                pictureBox3.Image = Image.FromFile(pictures[m * 8 + 2]);
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox3.ImageLocation = pictures[m * 8 + 2];
                label3.Text = thingName[m * 8 + 2];
                label3.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox3.Image = null;
                label3.Text = "";
                pictureBox4.Image = null;
                label4.Text = "";
                pictureBox5.Image = null;
                label5.Text = "";
                pictureBox6.Image = null;
                label6.Text = "";
                pictureBox7.Image = null;
                label7.Text = "";
                pictureBox8.Image = null;
                label8.Text = "";
                return;
            }
            if (pictures[m * 8 + 3] != null && (m * 8 + 3) < r)
            {
                pictureBox4.Image = Image.FromFile(pictures[m * 8 + 3]);
                pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox4.ImageLocation = pictures[m * 8 + 3];
                label4.Text = thingName[m * 8 + 3];
                label4.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox4.Image = null;
                label4.Text = "";
                pictureBox5.Image = null;
                label5.Text = "";
                pictureBox6.Image = null;
                label6.Text = "";
                pictureBox7.Image = null;
                label7.Text = "";
                pictureBox8.Image = null;
                label8.Text = "";
                return;
            }
            if (pictures[m * 8 + 4] != null && (m * 8 + 4) < r)
            {
                pictureBox5.Image = Image.FromFile(pictures[m * 8 + 4]);
                pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox5.ImageLocation = pictures[m * 8 + 4];
                label5.Text = thingName[m * 8 + 4];
                label5.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox5.Image = null;
                label5.Text = "";
                pictureBox6.Image = null;
                label6.Text = "";
                pictureBox7.Image = null;
                label7.Text = "";
                pictureBox8.Image = null;
                label8.Text = "";
               
            }
            if (pictures[m * 8 + 5] != null && (m * 8 + 5) < r)
            {
                pictureBox6.Image = Image.FromFile(pictures[m * 8 + 5]);
                pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox6.ImageLocation = pictures[m * 8 + 5];
                label6.Text = thingName[m * 8 + 5];
                label6.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox6.Image = null;
                label6.Text = "";
                pictureBox7.Image = null;
                label7.Text = "";
                pictureBox8.Image = null;
                label8.Text = "";
               
            }
            if (pictures[m * 8 + 6] != null && (m * 8 + 6) < r)
            {
                pictureBox7.Image = Image.FromFile(pictures[m * 8 + 6]);
                pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox7.ImageLocation = pictures[m * 8 + 6];
                label7.Text = thingName[m * 8 + 6];
                label7.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox7.Image = null;
                label7.Text = "";
                pictureBox8.Image = null;
                label8.Text = "";
                return;
            }
            if (pictures[m * 8 + 7] != null && (m * 8 + 7) < r)
            {
                pictureBox8.Image = Image.FromFile(pictures[m * 8 + 7]);
                pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox8.ImageLocation = pictures[m * 8 + 7];
                label8.Text = thingName[m * 8 + 7];
                label8.TextAlign = ContentAlignment.MiddleCenter;
                if (r % 8 == 0 && (m + 1) >= (r / 8))
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
                pictureBox8.Image = null;
                label8.Text = "";
                return;
            }
            
        }
        //用于加载数据库中的数据
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
                    thingName[h] = myReader.GetString(0);
                    pictures[h] = myReader.GetString(1);
                    h++;
                    r++;
                }
            if(r == 8 )
            {
                nextButton.Enabled = false;
            }
            myCon.Close();
            showPictureAndName(i);
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            string con = "", _sql = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            _sql = "select * from stayUser";
            SqlCommand myCom = new SqlCommand(_sql, myCon);
            SqlDataReader myReader = myCom.ExecuteReader();
            while(myReader.Read())
            {
                name = myReader.GetString(0);
            }
            myCon.Close();
            //初始化界面
            this.Location = new Point(300, 150);
            selectData(string.Format("select Tname,Tpic from thing where not Uname = '{0}'",name));
            showPictureAndName(i);
            textBox1.Text = "发布者：+名字 或 名称：+ 或学校";
            textBox1.Focus();
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
            link = pictureBox1.ImageLocation+"0";
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }
        

        //下一页
        private void nextButton_Click(object sender, EventArgs e)
        {
            i++;
            showPictureAndName(i);
        }


        //上一页
        private void backButton_Click(object sender, EventArgs e)
        {
            i--;
            showPictureAndName(i);
        }


        //搜索物品
        private void button1_Click(object sender, EventArgs e)
        {
            
                i = 0;
            string sql = "",text = textBox1.Text;
            if(text.StartsWith("发布者："))
            {
                text = text.Substring(4, text.Length - 4);
                sql = string.Format("select Tname,Tpic from thing where Uname like '%{0}%' and not Uname = '{1}'", text,name);
            }
            else if (text.StartsWith("名称："))
            {
                text = text.Substring(3, text.Length - 3);
                sql = string.Format("select Tname,Tpic from thing where Tname like '%{0}%'  and not Uname = '{1}'", text,name);
            }
            else if(text.StartsWith("学校："))
            {
                text = text.Substring(3, text.Length - 3);
                sql = string.Format("select Tname,Tpic from thing,usr where usr.Uname = thing.Uname and usr.Uschool = '{0}' and not usr.Uname = '{1}'", text, name);
            }
            else
            {
                sql = string.Format("select Tname,Tpic from thing where Tname like '%{0}%'  and not Uname = '{1}'", text,name);
            }
            selectData(sql);
            if(r == 0 )
            {
                MessageBox.Show("未找到您需要的物品！");
            }
        }

        //根据时间和价格排序
        private void checkBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "";
            
            if (checkBoxPrice.Checked && checkBoxTime.Checked)
            {
                sql = string.Format("select Tname,Tpic from thing where not Uname = '{0}' order by Time desc,Tprice asc", name);
                selectData(sql);
                showPictureAndName(i);
                return;
            }
            if(checkBoxTime.Checked)
            {

                sql = string.Format("select Tname,Tpic from thing where not Uname = '{0}' order by Time desc",name);
                selectData(sql);
                showPictureAndName(i);
                return;
            }
            if (checkBoxPrice.Checked)
            {

                sql = string.Format("select Tname,Tpic from thing where not Uname = '{0}' order by Tprice asc",name);
                selectData(sql);
                showPictureAndName(i);
                return;
            }
            else
            {
                sql = string.Format("select Tname,Tpic from thing where not Uname = '{0}'",name);
                selectData(sql);
                showPictureAndName(i);
            }
            
            
        }

        private void checkBoxPrice_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "";

            if (checkBoxPrice.Checked && checkBoxTime.Checked)
            {
                sql = string.Format("select Tname,Tpic from thing where not Uname = '{0}' order by Time desc,Tprice asc", name);
                selectData(sql);
                showPictureAndName(i);
                return;
            }
            
            if (checkBoxPrice.Checked)
            {
                sql = string.Format("select Tname,Tpic from thing where not Uname = '{0}' order by Tprice asc", name);
                selectData(sql);
                showPictureAndName(i);
                return;
            }
            if (checkBoxTime.Checked)
            {
                sql = string.Format("select Tname,Tpic from thing where not Uname = '{0}' order by Time desc", name);
                selectData(sql);
                showPictureAndName(i);
                return;
            }
            else
            {
                sql = string.Format("select Tname,Tpic from thing where not Uname = '{0}'", name);
                selectData(sql);
                showPictureAndName(i);
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender,e);
                e.SuppressKeyPress= false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox2.ImageLocation+"0";
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox3.ImageLocation + "0";
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox4.ImageLocation + "0";
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox5.ImageLocation + "0";
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox6.ImageLocation + "0";
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox7.ImageLocation + "0";
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox8.ImageLocation + "0";
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
