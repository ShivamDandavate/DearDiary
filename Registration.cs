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
    public partial class Registration : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        SqlCommand cmd;
        public Registration()
        {
            InitializeComponent();
        }

        private void LinkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login re = new Login();
            re.Show();
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

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Enter Username")
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

  

        private void CPassword_Enter(object sender, EventArgs e)
        {
            if (CPassword.Text == "Confirm Password")
            {
                CPassword.Text = "";
                CPassword.ForeColor = Color.Black;
            }
        }

        private void CPassword_Leave(object sender, EventArgs e)
        {
            if (CPassword.Text == "")
            {
                CPassword.Text = "Confirm Password";
                CPassword.ForeColor = Color.LightGray;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            UName.Text = "Enter Name";
            UName.ForeColor = Color.LightGray;

            Username.Text = "Enter Username";
            Username.ForeColor = Color.LightGray;

            Password.Text = "Enter Password";
            Password.ForeColor = Color.LightGray;

            CPassword.Text = "Confirm Password";
            CPassword.ForeColor = Color.LightGray;

            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\harsh\Desktop\Shivam C Programs\Project\DearDiary\DearDiary\Diary.mdf"";Integrated Security=True");
            cn.Open();
        }

        private void UName_Enter(object sender, EventArgs e)
        {
            if (UName.Text == "Enter Name")
            {
                UName.Text = "";
                UName.ForeColor = Color.Black ;
            }
        }

        private void UName_Leave(object sender, EventArgs e)
        {
            if (UName.Text == "")
            {
                UName.Text = "Enter Name";
                UName.ForeColor = Color.LightGray;
            }
        }

        private void UName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
         
            if (CPassword.Text != string.Empty || Password.Text != string.Empty || Username.Text != string.Empty)
            {
                if (Password.Text == CPassword.Text)
                {
                     cmd = new SqlCommand("select * from users where U_Username='" + Username.Text + "'", cn);
                     dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into users values(@U_Name,@U_Username,@U_Password)", cn);
                        
                        cmd.Parameters.AddWithValue("U_Name",UName.Text);
                        cmd.Parameters.AddWithValue("U_Username", Username.Text);
                        cmd.Parameters.AddWithValue("U_Password", Password.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login Login = new Login();
                        Login.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
