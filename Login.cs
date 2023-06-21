using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DearDiary
{
    
    public partial class Login : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Username.Text = "Enter Username";
            Username.ForeColor = Color.LightGray;
            Password.Text = "Enter Password";
            Password.ForeColor = Color.LightGray;

            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\harsh\Desktop\Shivam C Programs\Project\DearDiary\DearDiary\Diary.mdf"";Integrated Security=True");
            cn.Open();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if(Username.Text=="Enter Username")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Enter Username";
                Username.ForeColor = Color.LightGray;
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Enter Password")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Enter Password";
                Password.ForeColor = Color.LightGray;
            }
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (Password.Text != string.Empty || Username.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from users where U_Username='" + Username.Text + "' and U_Password='" + Password.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Homepage home = new Homepage();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration re = new Registration();
            re.Show();
        }
    }
}
