
namespace Hospital
{
    partial class FPatient
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
            this.LBWelcome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbname = new System.Windows.Forms.Label();
            this.LBsurname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBemail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LBReceipt = new System.Windows.Forms.Label();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.MakeAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBWelcome
            // 
            this.LBWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBWelcome.Location = new System.Drawing.Point(624, 40);
            this.LBWelcome.Name = "LBWelcome";
            this.LBWelcome.Size = new System.Drawing.Size(113, 52);
            this.LBWelcome.TabIndex = 17;
            this.LBWelcome.Text = "Return";
            this.LBWelcome.UseVisualStyleBackColor = true;
            this.LBWelcome.Click += new System.EventHandler(this.BTNreturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // Lbname
            // 
            this.Lbname.AutoSize = true;
            this.Lbname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbname.Location = new System.Drawing.Point(182, 111);
            this.Lbname.Name = "Lbname";
            this.Lbname.Size = new System.Drawing.Size(78, 32);
            this.Lbname.TabIndex = 20;
            this.Lbname.Text = "label3";
            // 
            // LBsurname
            // 
            this.LBsurname.AutoSize = true;
            this.LBsurname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBsurname.Location = new System.Drawing.Point(182, 169);
            this.LBsurname.Name = "LBsurname";
            this.LBsurname.Size = new System.Drawing.Size(78, 32);
            this.LBsurname.TabIndex = 22;
            this.LBsurname.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Surname";
            // 
            // LBemail
            // 
            this.LBemail.AutoSize = true;
            this.LBemail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBemail.Location = new System.Drawing.Point(182, 228);
            this.LBemail.Name = "LBemail";
            this.LBemail.Size = new System.Drawing.Size(78, 32);
            this.LBemail.TabIndex = 24;
            this.LBemail.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Email";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Use FreeDrugsCours";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNSave
            // 
            this.BTNSave.Location = new System.Drawing.Point(35, 404);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(225, 29);
            this.BTNSave.TabIndex = 27;
            this.BTNSave.Text = "Save receipt";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(463, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 32);
            this.label8.TabIndex = 29;
            this.label8.Text = "Note";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(463, 271);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 113);
            this.textBox1.TabIndex = 30;
            // 
            // LBReceipt
            // 
            this.LBReceipt.AutoSize = true;
            this.LBReceipt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBReceipt.Location = new System.Drawing.Point(287, 399);
            this.LBReceipt.Name = "LBReceipt";
            this.LBReceipt.Size = new System.Drawing.Size(78, 32);
            this.LBReceipt.TabIndex = 31;
            this.LBReceipt.Text = "label3";
            // 
            // MakeAppointment
            // 
            this.MakeAppointment.Location = new System.Drawing.Point(35, 287);
            this.MakeAppointment.Name = "MakeAppointment";
            this.MakeAppointment.Size = new System.Drawing.Size(225, 29);
            this.MakeAppointment.TabIndex = 33;
            this.MakeAppointment.Text = "MakeAppointment";
            this.MakeAppointment.UseVisualStyleBackColor = true;
            this.MakeAppointment.Click += new System.EventHandler(this.MakeAppointment_Click);
            // 
            // FPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MakeAppointment);
            this.Controls.Add(this.LBReceipt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LBemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LBsurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBWelcome);
            this.Name = "FPatient";
            this.Text = "FPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LBWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbname;
        private System.Windows.Forms.Label LBsurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LBReceipt;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button MakeAppointment;
    }
}