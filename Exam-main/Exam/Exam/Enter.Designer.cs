namespace Exam
{
    partial class Enter
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnt = new System.Windows.Forms.Button();
            this.tBxPasEn = new System.Windows.Forms.TextBox();
            this.tBxPhEn = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnEmp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(73, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 36;
            this.label6.Text = "Пароль";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 28);
            this.label5.TabIndex = 35;
            this.label5.Text = "Номер телефона";
            // 
            // btnEnt
            // 
            this.btnEnt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnt.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnt.Location = new System.Drawing.Point(56, 325);
            this.btnEnt.Name = "btnEnt";
            this.btnEnt.Size = new System.Drawing.Size(142, 43);
            this.btnEnt.TabIndex = 33;
            this.btnEnt.Text = "Войти";
            this.btnEnt.UseVisualStyleBackColor = false;
            this.btnEnt.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // tBxPasEn
            // 
            this.tBxPasEn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBxPasEn.Location = new System.Drawing.Point(24, 265);
            this.tBxPasEn.Name = "tBxPasEn";
            this.tBxPasEn.Size = new System.Drawing.Size(216, 29);
            this.tBxPasEn.TabIndex = 32;
            // 
            // tBxPhEn
            // 
            this.tBxPhEn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBxPhEn.Location = new System.Drawing.Point(23, 183);
            this.tBxPhEn.Name = "tBxPhEn";
            this.tBxPhEn.Size = new System.Drawing.Size(217, 29);
            this.tBxPhEn.TabIndex = 31;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReg.ForeColor = System.Drawing.Color.Honeydew;
            this.btnReg.Location = new System.Drawing.Point(73, 52);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(127, 23);
            this.btnReg.TabIndex = 37;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 70);
            this.panel1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(102, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Вход";
            // 
            // btnEnEmp
            // 
            this.btnEnEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnEmp.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnEmp.Location = new System.Drawing.Point(56, 426);
            this.btnEnEmp.Name = "btnEnEmp";
            this.btnEnEmp.Size = new System.Drawing.Size(142, 62);
            this.btnEnEmp.TabIndex = 40;
            this.btnEnEmp.Text = "Войти как работник";
            this.btnEnEmp.UseVisualStyleBackColor = false;
            this.btnEnEmp.Click += new System.EventHandler(this.btnEnEmp_Click);
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 534);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnEnEmp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEnt);
            this.Controls.Add(this.tBxPasEn);
            this.Controls.Add(this.tBxPhEn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Enter";
            this.Text = "Enter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label5;
        private Button btnEnt;
        private TextBox tBxPasEn;
        private TextBox tBxPhEn;
        private Button btnReg;
        private Panel panel1;
        private Label label2;
        private Button btnEnEmp;
    }
}