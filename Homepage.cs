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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace DearDiary
{
    public partial class Homepage : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        SqlCommand cmd;
        public int did;
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\harsh\Desktop\Shivam C Programs\Project\DearDiary\DearDiary\Diary.mdf"";Integrated Security=True");
            cn.Open();

            DiaryGridView.Hide();
            Data.Hide();
            Note_Add.Hide();
            Del.Hide(); 
            UP.Hide();
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Data.Show();
            Note_Add.Show();
            DiaryGridView.Hide();
            UP.Hide();
            Del.Hide() ;
            Data.Text = "";

        }

        private void Note_Add_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Diary_Data values(@D_Data,@D_Timestamp)", cn);

            cmd.Parameters.AddWithValue("D_Data", Data.Text);
            cmd.Parameters.AddWithValue("D_Timestamp", DateTime.Now);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Note Added Successfully !!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Data.Hide();
            Note_Add.Hide();  
            DiaryGridView.Hide();
        }

        private void Show_note_Click(object sender, EventArgs e)
        {
            Note_Add.Hide();     
            Data.Hide() ;
            UP.Hide();
            Del.Hide();
            Update.Show();
            Delete.Show();

            DiaryGridView.Show();

            cmd = new SqlCommand("Select * from Diary_Data", cn);
            DataTable dt =new DataTable();

            
            SqlDataReader sdr= cmd.ExecuteReader();
            dt.Load(sdr);   
    
            DiaryGridView.DataSource= dt;


        }

        private void DiaryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            did = Convert.ToInt32(DiaryGridView.SelectedRows[0].Cells[0].Value);
            Data.Text = DiaryGridView.SelectedRows[0].Cells[1].Value.ToString();
            Console.WriteLine(did);

        }

        private void Update_Click(object sender, EventArgs e)
        {


            Data.Show();
            Update.Show();
            DiaryGridView.Show();
            UP.Show();
            Data.Text = "";

            cmd = new SqlCommand("Select * from Diary_Data", cn);
            DataTable dt = new DataTable();


            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            DiaryGridView.DataSource = dt;

        }

        private void welcome_name_Click(object sender, EventArgs e)
        {

        }

        private void UP_Click(object sender, EventArgs e)
        {
            if (did > 0)
            {
                cmd = new SqlCommand("Update Diary_Data set D_Data=@D_Data,D_Timestamp=@D_Timestamp where D_Id =@did", cn);

                cmd.Parameters.AddWithValue("D_Data", Data.Text);
                cmd.Parameters.AddWithValue("D_Timestamp", DateTime.Now);
                cmd.Parameters.AddWithValue("@did", this.did);
                cmd.ExecuteNonQuery();
                UP.Hide();
                Data.Hide();
                DiaryGridView.Hide();   

                
            }
            else
            {
                MessageBox.Show("Please select  a note to update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (did > 0)
            {
                cmd = new SqlCommand("Delete from Diary_Data where D_Id =@did", cn);
                cmd.Parameters.AddWithValue("@did", this.did);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Note is deleted !!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Del.Hide();
                Data.Hide();
                DiaryGridView.Hide();


            }
            else
            {
                MessageBox.Show("Please select  a note to Delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Data.Show();
            Update.Show();
            DiaryGridView.Show();
            UP.Hide();
            Del.Show();
            cmd = new SqlCommand("Select * from Diary_Data", cn);
            DataTable dt = new DataTable();


            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            DiaryGridView.DataSource = dt;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
