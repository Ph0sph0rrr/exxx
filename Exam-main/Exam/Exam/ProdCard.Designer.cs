namespace Exam
{
    partial class ProdCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Serie = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.Label();
            this.lbDpInf = new System.Windows.Forms.Label();
            this.Probl = new System.Windows.Forms.Label();
            this.lbSta = new System.Windows.Forms.Label();
            this.DateStart = new System.Windows.Forms.Label();
            this.IoCl = new System.Windows.Forms.Label();
            this.PhCl = new System.Windows.Forms.Label();
            this.PhEmp = new System.Windows.Forms.Label();
            this.tbxPdInf = new System.Windows.Forms.TextBox();
            this.cmbxSta = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IoEmp = new System.Windows.Forms.Label();
            this.lbDateFinish = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.lbComment = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDateFinish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chgDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Serie
            // 
            this.Serie.AutoSize = true;
            this.Serie.Location = new System.Drawing.Point(17, 17);
            this.Serie.Name = "Serie";
            this.Serie.Size = new System.Drawing.Size(84, 15);
            this.Serie.TabIndex = 0;
            this.Serie.Text = "Номер серии:";
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(16, 57);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(91, 15);
            this.Product.TabIndex = 1;
            this.Product.Text = "Оборудование:";
            // 
            // lbDpInf
            // 
            this.lbDpInf.AutoSize = true;
            this.lbDpInf.Location = new System.Drawing.Point(16, 133);
            this.lbDpInf.Name = "lbDpInf";
            this.lbDpInf.Size = new System.Drawing.Size(178, 15);
            this.lbDpInf.TabIndex = 3;
            this.lbDpInf.Text = "Дополнительная информация:";
            // 
            // Probl
            // 
            this.Probl.AutoSize = true;
            this.Probl.Location = new System.Drawing.Point(17, 95);
            this.Probl.Name = "Probl";
            this.Probl.Size = new System.Drawing.Size(68, 15);
            this.Probl.TabIndex = 2;
            this.Probl.Text = "Проблема:";
            // 
            // lbSta
            // 
            this.lbSta.AutoSize = true;
            this.lbSta.Location = new System.Drawing.Point(194, 164);
            this.lbSta.Name = "lbSta";
            this.lbSta.Size = new System.Drawing.Size(46, 15);
            this.lbSta.TabIndex = 4;
            this.lbSta.Text = "Статус:";
            // 
            // DateStart
            // 
            this.DateStart.AutoSize = true;
            this.DateStart.Location = new System.Drawing.Point(256, 17);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(88, 15);
            this.DateStart.TabIndex = 5;
            this.DateStart.Text = "Дата создания:";
            // 
            // IoCl
            // 
            this.IoCl.AutoSize = true;
            this.IoCl.Location = new System.Drawing.Point(206, 57);
            this.IoCl.Name = "IoCl";
            this.IoCl.Size = new System.Drawing.Size(81, 15);
            this.IoCl.TabIndex = 6;
            this.IoCl.Text = "Имя клиента:";
            // 
            // PhCl
            // 
            this.PhCl.AutoSize = true;
            this.PhCl.Location = new System.Drawing.Point(206, 113);
            this.PhCl.Name = "PhCl";
            this.PhCl.Size = new System.Drawing.Size(95, 15);
            this.PhCl.TabIndex = 7;
            this.PhCl.Text = "Номер клиента:";
            // 
            // PhEmp
            // 
            this.PhEmp.AutoSize = true;
            this.PhEmp.Location = new System.Drawing.Point(378, 113);
            this.PhEmp.Name = "PhEmp";
            this.PhEmp.Size = new System.Drawing.Size(123, 15);
            this.PhEmp.TabIndex = 8;
            this.PhEmp.Text = "Номер исполнителя:";
            // 
            // tbxPdInf
            // 
            this.tbxPdInf.Location = new System.Drawing.Point(17, 165);
            this.tbxPdInf.Multiline = true;
            this.tbxPdInf.Name = "tbxPdInf";
            this.tbxPdInf.Size = new System.Drawing.Size(178, 71);
            this.tbxPdInf.TabIndex = 9;
            this.tbxPdInf.TextChanged += new System.EventHandler(this.tbxPdInf_TextChanged);
            // 
            // cmbxSta
            // 
            this.cmbxSta.FormattingEnabled = true;
            this.cmbxSta.Items.AddRange(new object[] {
            "в ожидании",
            "в работе",
            "выполнено"});
            this.cmbxSta.Location = new System.Drawing.Point(246, 161);
            this.cmbxSta.Name = "cmbxSta";
            this.cmbxSta.Size = new System.Drawing.Size(121, 23);
            this.cmbxSta.TabIndex = 10;
            this.cmbxSta.SelectedIndexChanged += new System.EventHandler(this.cmbxSta_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 10);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 14);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 246);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(728, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 252);
            this.panel4.TabIndex = 14;
            // 
            // IoEmp
            // 
            this.IoEmp.AutoSize = true;
            this.IoEmp.Location = new System.Drawing.Point(378, 57);
            this.IoEmp.Name = "IoEmp";
            this.IoEmp.Size = new System.Drawing.Size(109, 15);
            this.IoEmp.TabIndex = 15;
            this.IoEmp.Text = "Имя исполнителя:";
            // 
            // lbDateFinish
            // 
            this.lbDateFinish.AutoSize = true;
            this.lbDateFinish.Location = new System.Drawing.Point(448, 17);
            this.lbDateFinish.Name = "lbDateFinish";
            this.lbDateFinish.Size = new System.Drawing.Size(98, 15);
            this.lbDateFinish.TabIndex = 16;
            this.lbDateFinish.Text = "Дата окончания:";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(544, 161);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(178, 71);
            this.tbComment.TabIndex = 18;
            this.tbComment.TextChanged += new System.EventHandler(this.tbComment_TextChanged);
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Location = new System.Drawing.Point(544, 122);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(87, 15);
            this.lbComment.TabIndex = 17;
            this.lbComment.Text = "Комментарий:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(390, 164);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(38, 15);
            this.lbPrice.TabIndex = 19;
            this.lbPrice.Text = "Цена:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(434, 164);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(67, 23);
            this.tbPrice.TabIndex = 20;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // tbDateFinish
            // 
            this.tbDateFinish.Location = new System.Drawing.Point(552, 17);
            this.tbDateFinish.Name = "tbDateFinish";
            this.tbDateFinish.Size = new System.Drawing.Size(99, 23);
            this.tbDateFinish.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(484, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Поменять исполнителя:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(657, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 21);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "*id*";
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(657, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chgDate
            // 
            this.chgDate.BackColor = System.Drawing.Color.Black;
            this.chgDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chgDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chgDate.ForeColor = System.Drawing.Color.Honeydew;
            this.chgDate.Location = new System.Drawing.Point(657, 17);
            this.chgDate.Name = "chgDate";
            this.chgDate.Size = new System.Drawing.Size(67, 23);
            this.chgDate.TabIndex = 25;
            this.chgDate.Text = "Изменить";
            this.chgDate.UseVisualStyleBackColor = false;
            this.chgDate.Click += new System.EventHandler(this.chgDate_Click);
            // 
            // ProdCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.chgDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDateFinish);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.lbDateFinish);
            this.Controls.Add(this.IoEmp);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbxSta);
            this.Controls.Add(this.tbxPdInf);
            this.Controls.Add(this.PhEmp);
            this.Controls.Add(this.PhCl);
            this.Controls.Add(this.IoCl);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.lbSta);
            this.Controls.Add(this.lbDpInf);
            this.Controls.Add(this.Probl);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Serie);
            this.Name = "ProdCard";
            this.Size = new System.Drawing.Size(741, 252);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Serie;
        private Label Product;
        private Label lbDpInf;
        private Label Probl;
        private Label lbSta;
        private Label DateStart;
        private Label IoCl;
        private Label PhCl;
        private Label PhEmp;
        private TextBox tbxPdInf;
        private ComboBox cmbxSta;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label IoEmp;
        private Label lbDateFinish;
        private TextBox tbComment;
        private Label lbComment;
        private Label lbPrice;
        private TextBox tbPrice;
        private TextBox tbDateFinish;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button chgDate;
    }
}
