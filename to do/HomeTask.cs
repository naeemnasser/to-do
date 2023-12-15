using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do
{
    public partial class HomeTask : Form
    {
        public HomeTask()
        {
            InitializeComponent();
        }
        bool isEditing=false;
        DataTable dt=new DataTable();
        private void HomeTask_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Time");
            dt.Columns.Add("Description");
            dataGridView1.DataSource= dt;
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText= " check ";
            chk.Name= "Check Box";
            dataGridView1.Columns.Add(chk);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            descBox.Text = "";
           
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Time"] = TitleBox.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Description"] = descBox.Text;
            }
            else
            {
                dt.Rows.Add(TitleBox.Text, descBox.Text);
               // dataGridView1.DataSource = dt;
            }
            TitleBox.Text = "";
            descBox.Text = "";
            isEditing= false;
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            TitleBox.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            descBox.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("erorr : "+ex);
            }
        }
    }
}
