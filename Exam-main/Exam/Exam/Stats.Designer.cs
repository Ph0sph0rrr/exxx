namespace Exam
{
    partial class Stats
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDoneReq = new System.Windows.Forms.Label();
            this.lbMedTime = new System.Windows.Forms.Label();
            this.lbOftProb = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(758, 380);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Приоритетные заявки:";
            // 
            // lbDoneReq
            // 
            this.lbDoneReq.AutoSize = true;
            this.lbDoneReq.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDoneReq.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbDoneReq.Location = new System.Drawing.Point(115, 9);
            this.lbDoneReq.Name = "lbDoneReq";
            this.lbDoneReq.Size = new System.Drawing.Size(215, 20);
            this.lbDoneReq.TabIndex = 5;
            this.lbDoneReq.Text = "Кол-во выполненых заказов:";
            // 
            // lbMedTime
            // 
            this.lbMedTime.AutoSize = true;
            this.lbMedTime.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMedTime.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbMedTime.Location = new System.Drawing.Point(418, 9);
            this.lbMedTime.Name = "lbMedTime";
            this.lbMedTime.Size = new System.Drawing.Size(213, 20);
            this.lbMedTime.TabIndex = 6;
            this.lbMedTime.Text = "Среднее время выполнения:";
            // 
            // lbOftProb
            // 
            this.lbOftProb.AutoSize = true;
            this.lbOftProb.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOftProb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbOftProb.Location = new System.Drawing.Point(381, 43);
            this.lbOftProb.Name = "lbOftProb";
            this.lbOftProb.Size = new System.Drawing.Size(264, 25);
            this.lbOftProb.TabIndex = 7;
            this.lbOftProb.Text = "Частая неисправность:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(-12, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 39);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(794, 480);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbOftProb);
            this.Controls.Add(this.lbMedTime);
            this.Controls.Add(this.lbDoneReq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Stats";
            this.Text = "Stats";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label lbDoneReq;
        private Label lbMedTime;
        private Label lbOftProb;
        private Button btnBack;
        private PictureBox pictureBox1;
    }
}