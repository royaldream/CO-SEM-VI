namespace GDI_
{
    partial class Practical1
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
            this.frank = new System.Windows.Forms.Button();
            this.euro = new System.Windows.Forms.Button();
            this.doller = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frank
            // 
            this.frank.Location = new System.Drawing.Point(112, 107);
            this.frank.Name = "frank";
            this.frank.Size = new System.Drawing.Size(75, 23);
            this.frank.TabIndex = 0;
            this.frank.Text = "frank";
            this.frank.UseVisualStyleBackColor = true;
            this.frank.Click += new System.EventHandler(this.frank_Click);
            // 
            // euro
            // 
            this.euro.Location = new System.Drawing.Point(203, 107);
            this.euro.Name = "euro";
            this.euro.Size = new System.Drawing.Size(75, 23);
            this.euro.TabIndex = 1;
            this.euro.Text = "euro";
            this.euro.UseVisualStyleBackColor = true;
            this.euro.Click += new System.EventHandler(this.euro_Click);
            // 
            // doller
            // 
            this.doller.Location = new System.Drawing.Point(12, 107);
            this.doller.Name = "doller";
            this.doller.Size = new System.Drawing.Size(75, 23);
            this.doller.TabIndex = 2;
            this.doller.Text = "doller";
            this.doller.UseVisualStyleBackColor = true;
            this.doller.Click += new System.EventHandler(this.doller_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Practical1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.doller);
            this.Controls.Add(this.euro);
            this.Controls.Add(this.frank);
            this.Name = "Practical1";
            this.Text = "Practical1";
            this.Load += new System.EventHandler(this.Practical1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frank;
        private System.Windows.Forms.Button euro;
        private System.Windows.Forms.Button doller;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}