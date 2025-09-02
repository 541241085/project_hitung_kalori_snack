namespace project_hitung_kalori_snack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbhitungkalori = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxJumlah = new TextBox();
            textBoxKalori = new TextBox();
            groupBoxHasil = new GroupBox();
            labelHasil = new Label();
            buttonHitung = new Button();
            label3 = new Label();
            textBoxTarget = new TextBox();
            groupBoxHasil.SuspendLayout();
            SuspendLayout();
            // 
            // lbhitungkalori
            // 
            lbhitungkalori.AutoSize = true;
            lbhitungkalori.BackColor = Color.Transparent;
            lbhitungkalori.Font = new Font("Poppins SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbhitungkalori.ForeColor = Color.FromArgb(0, 64, 0);
            lbhitungkalori.Location = new Point(79, 24);
            lbhitungkalori.Name = "lbhitungkalori";
            lbhitungkalori.Size = new Size(469, 56);
            lbhitungkalori.TabIndex = 0;
            lbhitungkalori.Text = "Hitung Kalori Snack Kamuu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 0);
            label1.Location = new Point(26, 92);
            label1.Name = "label1";
            label1.Size = new Size(184, 39);
            label1.TabIndex = 1;
            label1.Text = "Jumlah Snack:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 0);
            label2.Location = new Point(122, 146);
            label2.Name = "label2";
            label2.Size = new Size(88, 39);
            label2.TabIndex = 2;
            label2.Text = "Kalori:";
            // 
            // textBoxJumlah
            // 
            textBoxJumlah.Location = new Point(216, 94);
            textBoxJumlah.Name = "textBoxJumlah";
            textBoxJumlah.Size = new Size(150, 31);
            textBoxJumlah.TabIndex = 3;
            textBoxJumlah.TextChanged += textBox1_TextChanged;
            // 
            // textBoxKalori
            // 
            textBoxKalori.Location = new Point(216, 146);
            textBoxKalori.Name = "textBoxKalori";
            textBoxKalori.Size = new Size(150, 31);
            textBoxKalori.TabIndex = 4;
            // 
            // groupBoxHasil
            // 
            groupBoxHasil.BackColor = Color.Transparent;
            groupBoxHasil.Controls.Add(labelHasil);
            groupBoxHasil.Location = new Point(402, 92);
            groupBoxHasil.Name = "groupBoxHasil";
            groupBoxHasil.Size = new Size(208, 93);
            groupBoxHasil.TabIndex = 5;
            groupBoxHasil.TabStop = false;
            groupBoxHasil.Text = "Hasil";
            // 
            // labelHasil
            // 
            labelHasil.AutoSize = true;
            labelHasil.Location = new Point(3, 27);
            labelHasil.Name = "labelHasil";
            labelHasil.Size = new Size(66, 25);
            labelHasil.TabIndex = 0;
            labelHasil.Text = "output";
            // 
            // buttonHitung
            // 
            buttonHitung.Location = new Point(436, 191);
            buttonHitung.Name = "buttonHitung";
            buttonHitung.Size = new Size(112, 34);
            buttonHitung.TabIndex = 6;
            buttonHitung.Text = "YAY or NAY";
            buttonHitung.UseVisualStyleBackColor = true;
            buttonHitung.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 0);
            label3.Location = new Point(37, 191);
            label3.Name = "label3";
            label3.Size = new Size(173, 39);
            label3.TabIndex = 7;
            label3.Text = "Target Kalori: ";
            // 
            // textBoxTarget
            // 
            textBoxTarget.Location = new Point(216, 194);
            textBoxTarget.Name = "textBoxTarget";
            textBoxTarget.Size = new Size(150, 31);
            textBoxTarget.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(622, 415);
            Controls.Add(textBoxTarget);
            Controls.Add(label3);
            Controls.Add(buttonHitung);
            Controls.Add(textBoxKalori);
            Controls.Add(textBoxJumlah);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbhitungkalori);
            Controls.Add(groupBoxHasil);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            groupBoxHasil.ResumeLayout(false);
            groupBoxHasil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbhitungkalori;
        private Label label1;
        private Label label2;
        private TextBox textBoxJumlah;
        private TextBox textBoxKalori;
        private GroupBox groupBoxHasil;
        private Button buttonHitung;
        private Label label3;
        private TextBox textBoxTarget;
        private Label labelHasil;
    }
}
