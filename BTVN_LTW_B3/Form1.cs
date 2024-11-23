using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_LTW_B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng click vào id trong listview để xóa!", "Thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen.Text))
            {
                ListViewItem item = new ListViewItem((listView1.Items.Count + 1).ToString()); 
                item.SubItems.Add(txtHoTen.Text); 
                listView1.Items.Add(item); 
                txtHoTen.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {     
            if (listView1.SelectedItems.Count > 0)
            {
                if (!string.IsNullOrEmpty(txtHoTen.Text))
                {
                    listView1.SelectedItems[0].SubItems[1].Text = txtHoTen.Text;
                    txtHoTen.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập họ và tên để sửa!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng click vào id trong listview để sửa!", "Thông báo");
            }
        }
    }
}
