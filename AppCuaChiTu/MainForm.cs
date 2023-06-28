using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCuaChiTu
{
    public partial class MainForm : Form
    {
        BindingList<Product> dataList;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            Repo repo = new Repo();
            List<Product> products = repo.Gets();
            dataList = new BindingList<Product>(products);
            dataGridView1.DataSource = dataList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm searhForm = new SearchForm();
            searhForm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                dataGridView1.Rows.Remove(selectedRow);
                Repo repo = new Repo();
                repo.DeleteById(id);
            }
            else
            {
            }
            
        }
    }
}
