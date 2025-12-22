namespace Tyuiu.ZamyakinaOA.Sprint7.V1
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            PictureAbout_ZOA = new PictureBox();
            TitleForAbout_ZOA = new Label();
            Text1ForAbout_ZOA = new Label();
            Text2ForAbout_ZOA = new Label();
            ButtonLeaveAbout_ZOA = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureAbout_ZOA).BeginInit();
            SuspendLayout();
            // 
            // PictureAbout_ZOA
            // 
            PictureAbout_ZOA.Image = Properties.Resources.PictureAbout;
            PictureAbout_ZOA.Location = new Point(289, 205);
            PictureAbout_ZOA.Name = "PictureAbout_ZOA";
            PictureAbout_ZOA.Size = new Size(211, 200);
            PictureAbout_ZOA.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureAbout_ZOA.TabIndex = 1;
            PictureAbout_ZOA.TabStop = false;
            // 
            // TitleForAbout_ZOA
            // 
            TitleForAbout_ZOA.AutoSize = true;
            TitleForAbout_ZOA.BackColor = Color.LavenderBlush;
            TitleForAbout_ZOA.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TitleForAbout_ZOA.ForeColor = Color.MediumVioletRed;
            TitleForAbout_ZOA.Location = new Point(27, 9);
            TitleForAbout_ZOA.Name = "TitleForAbout_ZOA";
            TitleForAbout_ZOA.Size = new Size(455, 28);
            TitleForAbout_ZOA.TabIndex = 2;
            TitleForAbout_ZOA.Text = "Эта программа работает с базой данных!\r\n";
            // 
            // Text1ForAbout_ZOA
            // 
            Text1ForAbout_ZOA.AutoSize = true;
            Text1ForAbout_ZOA.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Text1ForAbout_ZOA.ForeColor = Color.PaleVioletRed;
            Text1ForAbout_ZOA.Location = new Point(27, 49);
            Text1ForAbout_ZOA.Name = "Text1ForAbout_ZOA";
            Text1ForAbout_ZOA.Size = new Size(473, 144);
            Text1ForAbout_ZOA.TabIndex = 3;
            Text1ForAbout_ZOA.Text = resources.GetString("Text1ForAbout_ZOA.Text");
            // 
            // Text2ForAbout_ZOA
            // 
            Text2ForAbout_ZOA.AutoSize = true;
            Text2ForAbout_ZOA.BackColor = Color.LavenderBlush;
            Text2ForAbout_ZOA.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Text2ForAbout_ZOA.ForeColor = Color.PaleVioletRed;
            Text2ForAbout_ZOA.Location = new Point(27, 205);
            Text2ForAbout_ZOA.Name = "Text2ForAbout_ZOA";
            Text2ForAbout_ZOA.Size = new Size(244, 190);
            Text2ForAbout_ZOA.TabIndex = 4;
            Text2ForAbout_ZOA.Text = "Спринт 7\r\nВариант 1\r\nТема: Авторемонтные мастерские\r\nВыполнила: Замякина Олеся \r\nАндреевна\r\nГруппа: ПКТб-25-1\r\nТюменский индустриальный \r\nуниверситет, Высшая школа \r\nцифровых технологий\r\n2025 год";
            // 
            // ButtonLeaveAbout_ZOA
            // 
            ButtonLeaveAbout_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonLeaveAbout_ZOA.Cursor = Cursors.Hand;
            ButtonLeaveAbout_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonLeaveAbout_ZOA.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonLeaveAbout_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonLeaveAbout_ZOA.Location = new Point(27, 412);
            ButtonLeaveAbout_ZOA.Name = "ButtonLeaveAbout_ZOA";
            ButtonLeaveAbout_ZOA.Size = new Size(164, 35);
            ButtonLeaveAbout_ZOA.TabIndex = 5;
            ButtonLeaveAbout_ZOA.Text = "<---  Вернуться назад!";
            ButtonLeaveAbout_ZOA.TextAlign = ContentAlignment.MiddleLeft;
            ButtonLeaveAbout_ZOA.UseVisualStyleBackColor = false;
            ButtonLeaveAbout_ZOA.Click += ButtonLeaveAbout_ZOA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(509, 459);
            Controls.Add(ButtonLeaveAbout_ZOA);
            Controls.Add(Text2ForAbout_ZOA);
            Controls.Add(Text1ForAbout_ZOA);
            Controls.Add(TitleForAbout_ZOA);
            Controls.Add(PictureAbout_ZOA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе!  ɞ ⋆.˚ <3";
            ((System.ComponentModel.ISupportInitialize)PictureAbout_ZOA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureAbout_ZOA;
        private Label TitleForAbout_ZOA;
        private Label Text1ForAbout_ZOA;
        private Label Text2ForAbout_ZOA;
        private Button ButtonLeaveAbout_ZOA;
    }
}