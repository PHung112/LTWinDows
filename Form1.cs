using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //tạo 1 mảng list để nhập từng cột
            ListViewItem item = new ListViewItem();
            item.Text = txt_LastName.Text;
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txt_FirstName.Text });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txt_Phone.Text });
            listView1.Items.Add(item);

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    item.Text = txt_LastName.Text;
                    item.SubItems[1].Text = txt_FirstName.Text;
                    item.SubItems[2].Text = txt_Phone.Text;

                    MessageBox.Show("Đã sửa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("Hãy tick vào checkbox của dòng cần sửa", "Thông báo");

        }

        private void groupBox2_Enter(object sender, EventArgs e){}

        private void label1_Click_1(object sender, EventArgs e){ }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            for ( int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = listView1.Items[i];
                if (item.Checked)
                {
                    listView1.Items.RemoveAt(i);                  
                }
            }
            MessageBox.Show("Đã xóa dòng được chọn", "Thông báo");
        }
    }
}
