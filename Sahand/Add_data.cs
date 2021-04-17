using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient; 

namespace Sahand
{
    public partial class Add_data : Form

    {
        private string contection = "Data Source=.;Initial Catalog=data;Integrated Security=true";
        public Add_data()
        {
            InitializeComponent();
        }

        private void btnsabt_Click(object sender, EventArgs e)
        {

            if(check()==true)
            {
                Runsql();
                MessageBox.Show("عملیات با موفقیت انجام شد","موفقیت",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show( "لطفا فیلد هارا به درستی پاسخ دهید","هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        void Runsql()
        {
            SqlConnection connect = new SqlConnection(contection);
            try
            {

                byte[] j = converter();
                if (j.Length == 0)
                {
                    MessageBox.Show("لطفا عکس را به درستی انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
                    string a = txtname.Text;
                    int num = Convert.ToInt32(Numbers.Text);
                  
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "insert into inv.partpic (Name,ImageIo,Number) values (@name,@ig,@nums)";
                    cmd.Parameters.AddWithValue("@name", a);
                    cmd.Parameters.AddWithValue("@ig", j);
                    cmd.Parameters.AddWithValue("@nums", num);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                

                
            }
            catch (SqlException)
            {
                MessageBox.Show("ارور دیتابیس", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch
            {
                MessageBox.Show("لطفا فیلد هارا به درستی پاسخ دهید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                connect.Close();
            }

            
           
           
        }
        bool check()
        {
            
            if(txtname.Text =="")
            {
                MessageBox.Show("لطفا نام کالارا انتخاب کنید","هشدار",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DialogResult = DialogResult.OK;
                return false; 

            }
            if (Numbers.Text == "")
            {
                MessageBox.Show("لطفاکد را به درستی انتخاب کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.OK;
                return false;

            }
         


            return true;
        }

        public  Byte[] converter ()
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(op.FileName, FileMode.Open, FileAccess.Read);
                Byte[] b= new byte[fs.Length];
                fs.Read(b, 0, b.Length);
                pictureBox1.Image = System.Drawing.Image.FromStream(fs);
                return b; 
                
            }
            return null; 
        }



        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; 
        }

      
    }
}
