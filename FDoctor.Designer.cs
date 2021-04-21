
namespace Hospital
{
    partial class FDoctor
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
            this.LBName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBDoctor = new System.Windows.Forms.ComboBox();
            this.LBSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBReceipt = new System.Windows.Forms.TextBox();
            this.BTNReceipt = new System.Windows.Forms.Button();
            this.CheckB = new System.Windows.Forms.CheckBox();
            this.BTNreturn = new System.Windows.Forms.Button();
            this.LBWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBName
            // 
            this.LBName.AutoSize = true;
            this.LBName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBName.Location = new System.Drawing.Point(161, 96);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(0, 32);
            this.LBName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name: ";
            // 
            // CBDoctor
            // 
            this.CBDoctor.FormattingEnabled = true;
            this.CBDoctor.Location = new System.Drawing.Point(435, 51);
            this.CBDoctor.Name = "CBDoctor";
            this.CBDoctor.Size = new System.Drawing.Size(151, 28);
            this.CBDoctor.TabIndex = 3;
            this.CBDoctor.SelectedIndexChanged += new System.EventHandler(this.CBAdmin_SelectedIndexChanged);
            // 
            // LBSurname
            // 
            this.LBSurname.AutoSize = true;
            this.LBSurname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBSurname.Location = new System.Drawing.Point(161, 160);
            this.LBSurname.Name = "LBSurname";
            this.LBSurname.Size = new System.Drawing.Size(0, 32);
            this.LBSurname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname";
            // 
            // LBEmail
            // 
            this.LBEmail.AutoSize = true;
            this.LBEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBEmail.Location = new System.Drawing.Point(161, 224);
            this.LBEmail.Name = "LBEmail";
            this.LBEmail.Size = new System.Drawing.Size(0, 32);
            this.LBEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Receipt";
            // 
            // TBReceipt
            // 
            this.TBReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBReceipt.Location = new System.Drawing.Point(37, 331);
            this.TBReceipt.Multiline = true;
            this.TBReceipt.Name = "TBReceipt";
            this.TBReceipt.Size = new System.Drawing.Size(421, 91);
            this.TBReceipt.TabIndex = 11;
            // 
            // BTNReceipt
            // 
            this.BTNReceipt.Location = new System.Drawing.Point(364, 285);
            this.BTNReceipt.Name = "BTNReceipt";
            this.BTNReceipt.Size = new System.Drawing.Size(94, 29);
            this.BTNReceipt.TabIndex = 12;
            this.BTNReceipt.Text = "Save";
            this.BTNReceipt.UseVisualStyleBackColor = true;
            this.BTNReceipt.Click += new System.EventHandler(this.BTNReceipt_Click);
            // 
            // CheckB
            // 
            this.CheckB.AutoSize = true;
            this.CheckB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckB.Location = new System.Drawing.Point(517, 360);
            this.CheckB.Name = "CheckB";
            this.CheckB.Size = new System.Drawing.Size(249, 36);
            this.CheckB.TabIndex = 15;
            this.CheckB.Text = "OutPatienTreatment";
            this.CheckB.UseVisualStyleBackColor = true;
            // 
            // BTNreturn
            // 
            this.BTNreturn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNreturn.Location = new System.Drawing.Point(637, 33);
            this.BTNreturn.Name = "BTNreturn";
            this.BTNreturn.Size = new System.Drawing.Size(113, 52);
            this.BTNreturn.TabIndex = 16;
            this.BTNreturn.Text = "Return";
            this.BTNreturn.UseVisualStyleBackColor = true;
            this.BTNreturn.Click += new System.EventHandler(this.BTNreturn_Click);
            // 
            // LBWelcome
            // 
            this.LBWelcome.AutoSize = true;
            this.LBWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBWelcome.Location = new System.Drawing.Point(35, 33);
            this.LBWelcome.Name = "LBWelcome";
            this.LBWelcome.Size = new System.Drawing.Size(160, 46);
            this.LBWelcome.TabIndex = 17;
            this.LBWelcome.Text = "Welcome";
            // 
            // FDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBWelcome);
            this.Controls.Add(this.BTNreturn);
            this.Controls.Add(this.CheckB);
            this.Controls.Add(this.BTNReceipt);
            this.Controls.Add(this.TBReceipt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBDoctor);
            this.Name = "FDoctor";
            this.Text = "FDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBDoctor;
        private System.Windows.Forms.Label LBSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBReceipt;
        private System.Windows.Forms.Button BTNReceipt;
        private System.Windows.Forms.CheckBox CheckB;
        private System.Windows.Forms.Button BTNreturn;
        private System.Windows.Forms.Label LBWelcome;
    }
}