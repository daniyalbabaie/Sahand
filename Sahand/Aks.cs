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
    public partial class Aks : Form
    {
        private string contection = "Data Source=.;Initial Catalog=data;Integrated Security=true";
        public Aks()
        {
            InitializeComponent();
        }

        private void Aks_Load(object sender, EventArgs e)
        {

        }

        private void btaks_Click(object sender, EventArgs e)
        {
            Runsql(); 
        }

        Byte[] Converter ()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpg Files|*.jpg|PNG Files|*.png"; 
            if (op.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(op.FileName,FileMode.Open,FileAccess.Read);
                Byte[] b = new byte[fs.Length];

                fs.Read(b, 0, b.Length);
                return b; 

            }
            return null; 

        }

        void Runsql  ()
        {
            SqlConnection connect = new SqlConnection(contection);

            try
            {
                Byte[] j = Converter();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = "insrt into inv.partpic (ImageIo) values(@im)";
                cmd.Parameters.AddWithValue("@im", j);
                connect.Open();
                cmd.ExecuteNonQuery();
            }

            catch
            {
                MessageBox.Show("لطفا عکس وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error); 

            }
            finally { 
                connect.Close(); 
            } 

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            
        }
    }
}
