
namespace Information
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stud_id_txtbox = new System.Windows.Forms.TextBox();
            this.stud_lname_txtbox = new System.Windows.Forms.TextBox();
            this.stud_fname_txtbox = new System.Windows.Forms.TextBox();
            this.stud_midinit_txtbox = new System.Windows.Forms.TextBox();
            this.stud_contact_no_txtbox = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.search_bar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle Initial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact No.";
            // 
            // stud_id_txtbox
            // 
            this.stud_id_txtbox.Location = new System.Drawing.Point(88, 10);
            this.stud_id_txtbox.Name = "stud_id_txtbox";
            this.stud_id_txtbox.Size = new System.Drawing.Size(126, 20);
            this.stud_id_txtbox.TabIndex = 1;
            // 
            // stud_lname_txtbox
            // 
            this.stud_lname_txtbox.Location = new System.Drawing.Point(88, 36);
            this.stud_lname_txtbox.Name = "stud_lname_txtbox";
            this.stud_lname_txtbox.Size = new System.Drawing.Size(126, 20);
            this.stud_lname_txtbox.TabIndex = 2;
            // 
            // stud_fname_txtbox
            // 
            this.stud_fname_txtbox.Location = new System.Drawing.Point(88, 62);
            this.stud_fname_txtbox.Name = "stud_fname_txtbox";
            this.stud_fname_txtbox.Size = new System.Drawing.Size(126, 20);
            this.stud_fname_txtbox.TabIndex = 3;
            // 
            // stud_midinit_txtbox
            // 
            this.stud_midinit_txtbox.Location = new System.Drawing.Point(88, 89);
            this.stud_midinit_txtbox.Name = "stud_midinit_txtbox";
            this.stud_midinit_txtbox.Size = new System.Drawing.Size(126, 20);
            this.stud_midinit_txtbox.TabIndex = 4;
            // 
            // stud_contact_no_txtbox
            // 
            this.stud_contact_no_txtbox.Location = new System.Drawing.Point(88, 116);
            this.stud_contact_no_txtbox.Name = "stud_contact_no_txtbox";
            this.stud_contact_no_txtbox.Size = new System.Drawing.Size(126, 20);
            this.stud_contact_no_txtbox.TabIndex = 5;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(11, 156);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(55, 36);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(72, 156);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(68, 36);
            this.update_btn.TabIndex = 8;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(146, 156);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(68, 36);
            this.delete_btn.TabIndex = 9;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 366);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search";
            // 
            // search_bar
            // 
            this.search_bar.Location = new System.Drawing.Point(270, 10);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(333, 20);
            this.search_bar.TabIndex = 6;
            this.search_bar.TextChanged += new System.EventHandler(this.search_bar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 411);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.stud_contact_no_txtbox);
            this.Controls.Add(this.stud_midinit_txtbox);
            this.Controls.Add(this.stud_fname_txtbox);
            this.Controls.Add(this.stud_lname_txtbox);
            this.Controls.Add(this.stud_id_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stud_id_txtbox;
        private System.Windows.Forms.TextBox stud_lname_txtbox;
        private System.Windows.Forms.TextBox stud_fname_txtbox;
        private System.Windows.Forms.TextBox stud_midinit_txtbox;
        private System.Windows.Forms.TextBox stud_contact_no_txtbox;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox search_bar;
    }
}

