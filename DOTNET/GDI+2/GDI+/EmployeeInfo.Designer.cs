namespace GDI_
{
    partial class EmployeeInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.address = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.emp_female = new System.Windows.Forms.RadioButton();
            this.emp_male = new System.Windows.Forms.RadioButton();
            this.emp_department = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emp_search = new System.Windows.Forms.Button();
            this.emp_name = new System.Windows.Forms.TextBox();
            this.emp_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.emp_female);
            this.groupBox1.Controls.Add(this.emp_male);
            this.groupBox1.Controls.Add(this.emp_department);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.emp_search);
            this.groupBox1.Controls.Add(this.emp_name);
            this.groupBox1.Controls.Add(this.emp_code);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // button
            // 
            this.button.Controls.Add(this.cancel);
            this.button.Controls.Add(this.update);
            this.button.Controls.Add(this.delete);
            this.button.Controls.Add(this.Insert);
            this.button.Location = new System.Drawing.Point(32, 246);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(698, 45);
            this.button.TabIndex = 17;
            this.button.TabStop = false;
            this.button.Text = "Operation";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(538, 16);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(356, 16);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(195, 16);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(16, 16);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(756, 108);
            this.dataGridView1.TabIndex = 16;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Reading",
            "Music",
            "Cricket"});
            this.checkedListBox1.Location = new System.Drawing.Point(482, 130);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(163, 79);
            this.checkedListBox1.TabIndex = 15;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(482, 79);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(167, 20);
            this.address.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(121, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Inactive";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // emp_female
            // 
            this.emp_female.AutoSize = true;
            this.emp_female.Location = new System.Drawing.Point(192, 164);
            this.emp_female.Name = "emp_female";
            this.emp_female.Size = new System.Drawing.Size(59, 17);
            this.emp_female.TabIndex = 12;
            this.emp_female.TabStop = true;
            this.emp_female.Text = "Female";
            this.emp_female.UseVisualStyleBackColor = true;
            // 
            // emp_male
            // 
            this.emp_male.AutoSize = true;
            this.emp_male.Checked = true;
            this.emp_male.Location = new System.Drawing.Point(119, 164);
            this.emp_male.Name = "emp_male";
            this.emp_male.Size = new System.Drawing.Size(48, 17);
            this.emp_male.TabIndex = 11;
            this.emp_male.TabStop = true;
            this.emp_male.Text = "Male";
            this.emp_male.UseVisualStyleBackColor = true;
            // 
            // emp_department
            // 
            this.emp_department.FormattingEnabled = true;
            this.emp_department.Location = new System.Drawing.Point(121, 122);
            this.emp_department.Name = "emp_department";
            this.emp_department.Size = new System.Drawing.Size(167, 21);
            this.emp_department.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hobbies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department";
            // 
            // emp_search
            // 
            this.emp_search.Location = new System.Drawing.Point(294, 35);
            this.emp_search.Name = "emp_search";
            this.emp_search.Size = new System.Drawing.Size(75, 23);
            this.emp_search.TabIndex = 4;
            this.emp_search.Text = "Search";
            this.emp_search.UseVisualStyleBackColor = true;
            // 
            // emp_name
            // 
            this.emp_name.Location = new System.Drawing.Point(121, 79);
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(167, 20);
            this.emp_name.TabIndex = 3;
            // 
            // emp_code
            // 
            this.emp_code.Location = new System.Drawing.Point(121, 38);
            this.emp_code.Name = "emp_code";
            this.emp_code.Size = new System.Drawing.Size(167, 20);
            this.emp_code.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Code";
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeInfo";
            this.Text = "EmployeeInfo";
            this.Load += new System.EventHandler(this.EmployeeInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button emp_search;
        private System.Windows.Forms.TextBox emp_name;
        private System.Windows.Forms.TextBox emp_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox emp_department;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton emp_female;
        private System.Windows.Forms.RadioButton emp_male;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox button;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Insert;
    }
}