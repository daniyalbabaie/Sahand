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

    public partial class Form1 : Form
    {
        private string contection = "Data Source=.;Initial Catalog=data;Integrated Security=true";
        Ghavanin datas;
        public Form1()
        {
            InitializeComponent();
            datas = new Sqldata();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updategrid();

            dataview.AutoGenerateColumns = false;
        }

        void updategrid()
        {
            dataview.DataSource = datas.Selectall();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            updategrid();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_data frm = new Add_data();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataview.DataSource = datas.Selectall();
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string name = dataview.CurrentRow.Cells[1].Value.ToString();
            try
            {
                if (name == "")
                {
                    MessageBox.Show("لطفا یک شخص را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }






                if (dataview.CurrentRow != null)
                {
                    if (MessageBox.Show($"ایا از حذف {name} مطمئن  هستید", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataview.CurrentRow.Cells[0].Value);
                        datas.Delete(id);
                    }

                }
            }
            catch
            {
                MessageBox.Show("لطفا یک شخص را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updategrid();
        }

        private void btaks_Click(object sender, EventArgs e)
        {

            Runsql();

        }


        Byte[] Converter()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpg Files|*.jpg|PNG Files|*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(op.FileName, FileMode.Open, FileAccess.Read);
                Byte[] b = new byte[fs.Length];

                fs.Read(b, 0, b.Length);
                return b;

            }
            return null;

        }

        void Runsql()
        {
            SqlConnection connect = new SqlConnection(contection);


            Byte[] j = Converter();

            {
                int id = Convert.ToInt32(dataview.CurrentRow.Cells[0].Value);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = "update inv.partpic set ImageIo=@im where   Id=@iy";
                cmd.Parameters.AddWithValue("@im", j);
                cmd.Parameters.AddWithValue("@iy", id);

                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();






            }
        }
    }
}
