namespace Exam
{
    partial class Registration
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.regCl = new System.Windows.Forms.Button();
            this.tBxIoRg = new System.Windows.Forms.TextBox();
            this.tBxPasRg = new System.Windows.Forms.TextBox();
            this.tBxPhRg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "Имя ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "Номер телефона";
            // 
            // regCl
            // 
            this.regCl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.regCl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regCl.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regCl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regCl.Location = new System.Drawing.Point(-8, 353);
            this.regCl.Name = "regCl";
            this.regCl.Size = new System.Drawing.Size(292, 42);
            this.regCl.TabIndex = 21;
            this.regCl.Text = "Зарегистрироваться как клиент";
            this.regCl.UseVisualStyleBackColor = false;
            this.regCl.Click += new System.EventHandler(this.regCl_Click_1);
            // 
            // tBxIoRg
            // 
            this.tBxIoRg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBxIoRg.Location = new System.Drawing.Point(12, 145);
            this.tBxIoRg.Name = "tBxIoRg";
            this.tBxIoRg.Size = new System.Drawing.Size(257, 29);
            this.tBxIoRg.TabIndex = 20;
            // 
            // tBxPasRg
            // 
            this.tBxPasRg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBxPasRg.Location = new System.Drawing.Point(12, 300);
            this.tBxPasRg.Name = "tBxPasRg";
            this.tBxPasRg.Size = new System.Drawing.Size(257, 29);
            this.tBxPasRg.TabIndex = 19;
            // 
            // tBxPhRg
            // 
            this.tBxPhRg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBxPhRg.Location = new System.Drawing.Point(12, 220);
            this.tBxPhRg.Name = "tBxPhRg";
            this.tBxPhRg.Size = new System.Drawing.Size(257, 29);
            this.tBxPhRg.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Регистрация";
            // 
            // btnEnt
            // 
            this.btnEnt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEnt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnt.Location = new System.Drawing.Point(89, 427);
            this.btnEnt.Name = "btnEnt";
            this.btnEnt.Size = new System.Drawing.Size(75, 23);
            this.btnEnt.TabIndex = 26;
            this.btnEnt.Text = "Назад";
            this.btnEnt.UseVisualStyleBackColor = false;
            this.btnEnt.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 66);
            this.panel1.TabIndex = 27;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(281, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.regCl);
            this.Controls.Add(this.tBxIoRg);
            this.Controls.Add(this.tBxPasRg);
            this.Controls.Add(this.tBxPhRg);
            this.Name = "Registration";
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private Button regCl;
        private TextBox tBxIoRg;
        private TextBox tBxPasRg;
        private TextBox tBxPhRg;
        private Label label2;
        private Button btnEnt;
        private Panel panel1;
    }
}