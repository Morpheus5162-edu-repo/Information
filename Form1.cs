using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information
{
    public partial class Form1 : Form
    {
        string auto_tbl_id;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_textbox()
        {
            auto_tbl_id = null;
            stud_id_txtbox.Text = "";
            stud_lname_txtbox.Text = "";
            stud_fname_txtbox.Text = "";
            stud_midinit_txtbox.Text = "";
            stud_contact_no_txtbox.Text = "";
            search_bar.Text = "";
        }

        private bool check_textbox()
        {
            if (string.IsNullOrWhiteSpace(stud_id_txtbox.Text) ||
                string.IsNullOrWhiteSpace(stud_lname_txtbox.Text) ||
                string.IsNullOrWhiteSpace(stud_fname_txtbox.Text) ||
                string.IsNullOrWhiteSpace(stud_midinit_txtbox.Text) ||
                string.IsNullOrWhiteSpace(stud_contact_no_txtbox.Text))
            {
                MessageBox.Show("All textboxes are required to be filled in.", "Fields Required", MessageBoxButtons.OK);
                return true;
            }

            return false;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(check_textbox())
            {
                return;
            }

            db.info_save(int.Parse(stud_id_txtbox.Text), stud_lname_txtbox.Text,
                stud_fname_txtbox.Text, char.Parse(stud_midinit_txtbox.Text.Substring(0, 1)), stud_contact_no_txtbox.Text);
            MessageBox.Show("Successfully Save", "Save", MessageBoxButtons.OK);
            dataGridView1.DataSource = db.info_view();
            clear_textbox();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if(check_textbox())
            {
                return;
            }

            db.info_update(int.Parse(auto_tbl_id), int.Parse(stud_id_txtbox.Text), stud_lname_txtbox.Text,
                stud_fname_txtbox.Text, char.Parse(stud_midinit_txtbox.Text.Substring(0,1)), stud_contact_no_txtbox.Text);
            MessageBox.Show("Successfully Updated", "Update", MessageBoxButtons.OK);
            dataGridView1.DataSource = db.info_view();
            clear_textbox();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(auto_tbl_id))
            {
                MessageBox.Show("There is no data selected.", "No Data", MessageBoxButtons.OK);
                return;
            }

            db.info_delete(int.Parse(auto_tbl_id));
            MessageBox.Show("Successfully Deleted", "Delete", MessageBoxButtons.OK);
            dataGridView1.DataSource = db.info_view();
            clear_textbox();
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.info_search(search_bar.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stud_id_txtbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            stud_lname_txtbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            stud_fname_txtbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            stud_midinit_txtbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            stud_contact_no_txtbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            auto_tbl_id = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.info_view();
        }
    }
}
