namespace Tyuiu.ZamyakinaOA.Sprint7.V1
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            MainTitle_ZOA = new Label();
            PictureCat_ZOA = new PictureBox();
            TimerForPictureCat_ZOA = new System.Windows.Forms.Timer(components);
            ButtonAbout_ZOA = new Button();
            ToolTipForButtonAbout_ZOA = new ToolTip(components);
            ButtonDelete_ZOA = new Button();
            ButtonSave_ZOA = new Button();
            ButtonLoad_ZOA = new Button();
            ButtonCancel_ZOA = new Button();
            ButtonDiagram_ZOA = new Button();
            PanelMainButtons_ZOA = new Panel();
            GroupBoxDataBase_ZOA = new GroupBox();
            dataGridViewDataBase_ZOA = new DataGridView();
            GroupBoxSearch_ZOA = new GroupBox();
            ButtonFiltr_ZOA = new Button();
            TextBoxFiltr_ZOA = new TextBox();
            ButtonFind_ZOA = new Button();
            TextBoxSearch_ZOA = new TextBox();
            GroupBoxMinMaxAvg_ZOA = new GroupBox();
            ButtonCalculate_ZOA = new Button();
            TextBoxAvg_ZOA = new TextBox();
            LabelAvg_ZOA = new Label();
            TextBoxMax_ZOA = new TextBox();
            TextBoxMin_ZOA = new TextBox();
            LabelMax_ZOA = new Label();
            LabelMin_ZOA = new Label();
            GroupBoxFunc_ZOA = new GroupBox();
            GroupBoxAdd_ZOA = new GroupBox();
            ButtonDeleteRow_ZOA = new Button();
            ButtonAddRow_ZOA = new Button();
            openFileDialog_ZOA = new OpenFileDialog();
            saveFileDialog_ZOA = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)PictureCat_ZOA).BeginInit();
            PanelMainButtons_ZOA.SuspendLayout();
            GroupBoxDataBase_ZOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataBase_ZOA).BeginInit();
            GroupBoxSearch_ZOA.SuspendLayout();
            GroupBoxMinMaxAvg_ZOA.SuspendLayout();
            GroupBoxAdd_ZOA.SuspendLayout();
            SuspendLayout();
            // 
            // MainTitle_ZOA
            // 
            MainTitle_ZOA.AutoSize = true;
            MainTitle_ZOA.BackColor = Color.LavenderBlush;
            MainTitle_ZOA.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MainTitle_ZOA.ForeColor = Color.MediumVioletRed;
            MainTitle_ZOA.Location = new Point(3, 11);
            MainTitle_ZOA.Name = "MainTitle_ZOA";
            MainTitle_ZOA.Size = new Size(659, 54);
            MainTitle_ZOA.TabIndex = 0;
            MainTitle_ZOA.Text = "АВТОРЕМОНТНЫЕ МАСТЕРСКИЕ";
            // 
            // PictureCat_ZOA
            // 
            PictureCat_ZOA.Cursor = Cursors.Hand;
            PictureCat_ZOA.Image = Properties.Resources.cutecat_default;
            PictureCat_ZOA.Location = new Point(668, 8);
            PictureCat_ZOA.Name = "PictureCat_ZOA";
            PictureCat_ZOA.Size = new Size(62, 63);
            PictureCat_ZOA.TabIndex = 1;
            PictureCat_ZOA.TabStop = false;
            PictureCat_ZOA.Click += PictureCat_ZOA_Click;
            // 
            // TimerForPictureCat_ZOA
            // 
            TimerForPictureCat_ZOA.Interval = 1000;
            TimerForPictureCat_ZOA.Tick += TimerForPictureCat_ZOA_Tick;
            // 
            // ButtonAbout_ZOA
            // 
            ButtonAbout_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonAbout_ZOA.Cursor = Cursors.Hand;
            ButtonAbout_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonAbout_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonAbout_ZOA.Image = Properties.Resources.question_foraboutbutton;
            ButtonAbout_ZOA.Location = new Point(1038, 11);
            ButtonAbout_ZOA.Name = "ButtonAbout_ZOA";
            ButtonAbout_ZOA.Size = new Size(55, 60);
            ButtonAbout_ZOA.TabIndex = 2;
            ToolTipForButtonAbout_ZOA.SetToolTip(ButtonAbout_ZOA, "Нажмите, чтобы получить информацию о программе!");
            ButtonAbout_ZOA.UseVisualStyleBackColor = false;
            ButtonAbout_ZOA.Click += ButtonAbout_ZOA_Click;
            // 
            // ToolTipForButtonAbout_ZOA
            // 
            ToolTipForButtonAbout_ZOA.ToolTipIcon = ToolTipIcon.Info;
            ToolTipForButtonAbout_ZOA.ToolTipTitle = "Руководство";
            // 
            // ButtonDelete_ZOA
            // 
            ButtonDelete_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonDelete_ZOA.Cursor = Cursors.Hand;
            ButtonDelete_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonDelete_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonDelete_ZOA.Image = Properties.Resources.DeleteFile;
            ButtonDelete_ZOA.Location = new Point(989, 11);
            ButtonDelete_ZOA.Name = "ButtonDelete_ZOA";
            ButtonDelete_ZOA.Size = new Size(43, 44);
            ButtonDelete_ZOA.TabIndex = 3;
            ToolTipForButtonAbout_ZOA.SetToolTip(ButtonDelete_ZOA, "Нажмите, чтобы получить информацию о программе!");
            ButtonDelete_ZOA.UseVisualStyleBackColor = false;
            ButtonDelete_ZOA.Click += buttonDelete_ZOA_Click;
            // 
            // ButtonSave_ZOA
            // 
            ButtonSave_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonSave_ZOA.Cursor = Cursors.Hand;
            ButtonSave_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonSave_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonSave_ZOA.Image = Properties.Resources.SaveFile;
            ButtonSave_ZOA.Location = new Point(940, 11);
            ButtonSave_ZOA.Name = "ButtonSave_ZOA";
            ButtonSave_ZOA.Size = new Size(43, 44);
            ButtonSave_ZOA.TabIndex = 4;
            ToolTipForButtonAbout_ZOA.SetToolTip(ButtonSave_ZOA, "Нажмите, чтобы получить информацию о программе!");
            ButtonSave_ZOA.UseVisualStyleBackColor = false;
            ButtonSave_ZOA.Click += ButtonSave_ZOA_Click;
            // 
            // ButtonLoad_ZOA
            // 
            ButtonLoad_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonLoad_ZOA.Cursor = Cursors.Hand;
            ButtonLoad_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonLoad_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonLoad_ZOA.Image = Properties.Resources.LoadFile;
            ButtonLoad_ZOA.Location = new Point(891, 11);
            ButtonLoad_ZOA.Name = "ButtonLoad_ZOA";
            ButtonLoad_ZOA.Size = new Size(43, 44);
            ButtonLoad_ZOA.TabIndex = 5;
            ToolTipForButtonAbout_ZOA.SetToolTip(ButtonLoad_ZOA, "Нажмите, чтобы получить информацию о программе!");
            ButtonLoad_ZOA.UseVisualStyleBackColor = false;
            ButtonLoad_ZOA.Click += ButtonLoad_ZOA_Click;
            // 
            // ButtonCancel_ZOA
            // 
            ButtonCancel_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonCancel_ZOA.Cursor = Cursors.Hand;
            ButtonCancel_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonCancel_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonCancel_ZOA.Image = Properties.Resources.ErrorFile;
            ButtonCancel_ZOA.Location = new Point(842, 11);
            ButtonCancel_ZOA.Name = "ButtonCancel_ZOA";
            ButtonCancel_ZOA.Size = new Size(43, 44);
            ButtonCancel_ZOA.TabIndex = 6;
            ToolTipForButtonAbout_ZOA.SetToolTip(ButtonCancel_ZOA, "Нажмите, чтобы получить информацию о программе!");
            ButtonCancel_ZOA.UseVisualStyleBackColor = false;
            ButtonCancel_ZOA.Click += ButtonCancelChanges_ZOA_Click;
            // 
            // ButtonDiagram_ZOA
            // 
            ButtonDiagram_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonDiagram_ZOA.Cursor = Cursors.Hand;
            ButtonDiagram_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonDiagram_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonDiagram_ZOA.Image = Properties.Resources.Diagram;
            ButtonDiagram_ZOA.Location = new Point(793, 11);
            ButtonDiagram_ZOA.Name = "ButtonDiagram_ZOA";
            ButtonDiagram_ZOA.Size = new Size(43, 44);
            ButtonDiagram_ZOA.TabIndex = 7;
            ToolTipForButtonAbout_ZOA.SetToolTip(ButtonDiagram_ZOA, "Нажмите, чтобы получить информацию о программе!");
            ButtonDiagram_ZOA.UseVisualStyleBackColor = false;
            // 
            // PanelMainButtons_ZOA
            // 
            PanelMainButtons_ZOA.BackColor = Color.Transparent;
            PanelMainButtons_ZOA.BackgroundImage = Properties.Resources.BAckground2;
            PanelMainButtons_ZOA.BackgroundImageLayout = ImageLayout.Stretch;
            PanelMainButtons_ZOA.Controls.Add(MainTitle_ZOA);
            PanelMainButtons_ZOA.Controls.Add(ButtonDiagram_ZOA);
            PanelMainButtons_ZOA.Controls.Add(PictureCat_ZOA);
            PanelMainButtons_ZOA.Controls.Add(ButtonCancel_ZOA);
            PanelMainButtons_ZOA.Controls.Add(ButtonAbout_ZOA);
            PanelMainButtons_ZOA.Controls.Add(ButtonLoad_ZOA);
            PanelMainButtons_ZOA.Controls.Add(ButtonDelete_ZOA);
            PanelMainButtons_ZOA.Controls.Add(ButtonSave_ZOA);
            PanelMainButtons_ZOA.Location = new Point(2, 1);
            PanelMainButtons_ZOA.Name = "PanelMainButtons_ZOA";
            PanelMainButtons_ZOA.Size = new Size(1104, 79);
            PanelMainButtons_ZOA.TabIndex = 8;
            // 
            // GroupBoxDataBase_ZOA
            // 
            GroupBoxDataBase_ZOA.Controls.Add(dataGridViewDataBase_ZOA);
            GroupBoxDataBase_ZOA.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupBoxDataBase_ZOA.Location = new Point(5, 86);
            GroupBoxDataBase_ZOA.Name = "GroupBoxDataBase_ZOA";
            GroupBoxDataBase_ZOA.Size = new Size(789, 670);
            GroupBoxDataBase_ZOA.TabIndex = 9;
            GroupBoxDataBase_ZOA.TabStop = false;
            GroupBoxDataBase_ZOA.Text = "База данных:";
            // 
            // dataGridViewDataBase_ZOA
            // 
            dataGridViewDataBase_ZOA.AllowUserToDeleteRows = false;
            dataGridViewDataBase_ZOA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDataBase_ZOA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDataBase_ZOA.BackgroundColor = Color.LavenderBlush;
            dataGridViewDataBase_ZOA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataBase_ZOA.Dock = DockStyle.Fill;
            dataGridViewDataBase_ZOA.GridColor = Color.RosyBrown;
            dataGridViewDataBase_ZOA.Location = new Point(3, 20);
            dataGridViewDataBase_ZOA.Name = "dataGridViewDataBase_ZOA";
            dataGridViewDataBase_ZOA.RowHeadersVisible = false;
            dataGridViewDataBase_ZOA.Size = new Size(783, 647);
            dataGridViewDataBase_ZOA.TabIndex = 0;
            dataGridViewDataBase_ZOA.SortCompare += dataGridViewDataBase_ZOA_SortCompare;
            // 
            // GroupBoxSearch_ZOA
            // 
            GroupBoxSearch_ZOA.Controls.Add(ButtonFiltr_ZOA);
            GroupBoxSearch_ZOA.Controls.Add(TextBoxFiltr_ZOA);
            GroupBoxSearch_ZOA.Controls.Add(ButtonFind_ZOA);
            GroupBoxSearch_ZOA.Controls.Add(TextBoxSearch_ZOA);
            GroupBoxSearch_ZOA.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupBoxSearch_ZOA.Location = new Point(801, 86);
            GroupBoxSearch_ZOA.Name = "GroupBoxSearch_ZOA";
            GroupBoxSearch_ZOA.Size = new Size(294, 159);
            GroupBoxSearch_ZOA.TabIndex = 10;
            GroupBoxSearch_ZOA.TabStop = false;
            GroupBoxSearch_ZOA.Text = "Поиск и фильтрация:";
            // 
            // ButtonFiltr_ZOA
            // 
            ButtonFiltr_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonFiltr_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonFiltr_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonFiltr_ZOA.Location = new Point(92, 114);
            ButtonFiltr_ZOA.Name = "ButtonFiltr_ZOA";
            ButtonFiltr_ZOA.Size = new Size(112, 28);
            ButtonFiltr_ZOA.TabIndex = 3;
            ButtonFiltr_ZOA.Text = "Фильтрация";
            ButtonFiltr_ZOA.UseVisualStyleBackColor = false;
            ButtonFiltr_ZOA.Click += ButtonFiltr_ZOA_Click;
            // 
            // TextBoxFiltr_ZOA
            // 
            TextBoxFiltr_ZOA.Location = new Point(64, 86);
            TextBoxFiltr_ZOA.Name = "TextBoxFiltr_ZOA";
            TextBoxFiltr_ZOA.Size = new Size(158, 22);
            TextBoxFiltr_ZOA.TabIndex = 2;
            // 
            // ButtonFind_ZOA
            // 
            ButtonFind_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonFind_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonFind_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonFind_ZOA.Location = new Point(92, 53);
            ButtonFind_ZOA.Name = "ButtonFind_ZOA";
            ButtonFind_ZOA.Size = new Size(112, 27);
            ButtonFind_ZOA.TabIndex = 1;
            ButtonFind_ZOA.Text = "Начать поиск";
            ButtonFind_ZOA.TextAlign = ContentAlignment.TopCenter;
            ButtonFind_ZOA.UseVisualStyleBackColor = false;
            ButtonFind_ZOA.Click += ButtonFind_ZOA_Click;
            // 
            // TextBoxSearch_ZOA
            // 
            TextBoxSearch_ZOA.Location = new Point(64, 25);
            TextBoxSearch_ZOA.Name = "TextBoxSearch_ZOA";
            TextBoxSearch_ZOA.Size = new Size(158, 22);
            TextBoxSearch_ZOA.TabIndex = 0;
            // 
            // GroupBoxMinMaxAvg_ZOA
            // 
            GroupBoxMinMaxAvg_ZOA.Controls.Add(ButtonCalculate_ZOA);
            GroupBoxMinMaxAvg_ZOA.Controls.Add(TextBoxAvg_ZOA);
            GroupBoxMinMaxAvg_ZOA.Controls.Add(LabelAvg_ZOA);
            GroupBoxMinMaxAvg_ZOA.Controls.Add(TextBoxMax_ZOA);
            GroupBoxMinMaxAvg_ZOA.Controls.Add(TextBoxMin_ZOA);
            GroupBoxMinMaxAvg_ZOA.Controls.Add(LabelMax_ZOA);
            GroupBoxMinMaxAvg_ZOA.Controls.Add(LabelMin_ZOA);
            GroupBoxMinMaxAvg_ZOA.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupBoxMinMaxAvg_ZOA.Location = new Point(801, 251);
            GroupBoxMinMaxAvg_ZOA.Name = "GroupBoxMinMaxAvg_ZOA";
            GroupBoxMinMaxAvg_ZOA.Size = new Size(294, 181);
            GroupBoxMinMaxAvg_ZOA.TabIndex = 11;
            GroupBoxMinMaxAvg_ZOA.TabStop = false;
            GroupBoxMinMaxAvg_ZOA.Text = "Поиск значений мощности:";
            // 
            // ButtonCalculate_ZOA
            // 
            ButtonCalculate_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonCalculate_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonCalculate_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonCalculate_ZOA.Location = new Point(30, 134);
            ButtonCalculate_ZOA.Name = "ButtonCalculate_ZOA";
            ButtonCalculate_ZOA.Size = new Size(241, 27);
            ButtonCalculate_ZOA.TabIndex = 6;
            ButtonCalculate_ZOA.Text = "Рассчитать значения";
            ButtonCalculate_ZOA.UseVisualStyleBackColor = false;
            ButtonCalculate_ZOA.Click += ButtonCalculate_ZOA_Click;
            // 
            // TextBoxAvg_ZOA
            // 
            TextBoxAvg_ZOA.Location = new Point(141, 101);
            TextBoxAvg_ZOA.Name = "TextBoxAvg_ZOA";
            TextBoxAvg_ZOA.ReadOnly = true;
            TextBoxAvg_ZOA.Size = new Size(130, 22);
            TextBoxAvg_ZOA.TabIndex = 5;
            TextBoxAvg_ZOA.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelAvg_ZOA
            // 
            LabelAvg_ZOA.AutoSize = true;
            LabelAvg_ZOA.Location = new Point(43, 101);
            LabelAvg_ZOA.Name = "LabelAvg_ZOA";
            LabelAvg_ZOA.Size = new Size(67, 18);
            LabelAvg_ZOA.TabIndex = 4;
            LabelAvg_ZOA.Text = "Среднее:";
            // 
            // TextBoxMax_ZOA
            // 
            TextBoxMax_ZOA.Location = new Point(141, 63);
            TextBoxMax_ZOA.Name = "TextBoxMax_ZOA";
            TextBoxMax_ZOA.ReadOnly = true;
            TextBoxMax_ZOA.Size = new Size(130, 22);
            TextBoxMax_ZOA.TabIndex = 3;
            TextBoxMax_ZOA.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxMin_ZOA
            // 
            TextBoxMin_ZOA.Location = new Point(141, 30);
            TextBoxMin_ZOA.Name = "TextBoxMin_ZOA";
            TextBoxMin_ZOA.ReadOnly = true;
            TextBoxMin_ZOA.Size = new Size(130, 22);
            TextBoxMin_ZOA.TabIndex = 2;
            TextBoxMin_ZOA.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelMax_ZOA
            // 
            LabelMax_ZOA.AutoSize = true;
            LabelMax_ZOA.Location = new Point(30, 63);
            LabelMax_ZOA.Name = "LabelMax_ZOA";
            LabelMax_ZOA.Size = new Size(96, 18);
            LabelMax_ZOA.TabIndex = 1;
            LabelMax_ZOA.Text = "Наибольшее:";
            // 
            // LabelMin_ZOA
            // 
            LabelMin_ZOA.AutoSize = true;
            LabelMin_ZOA.Location = new Point(28, 30);
            LabelMin_ZOA.Name = "LabelMin_ZOA";
            LabelMin_ZOA.Size = new Size(98, 18);
            LabelMin_ZOA.TabIndex = 0;
            LabelMin_ZOA.Text = "Наименьшее:";
            // 
            // GroupBoxFunc_ZOA
            // 
            GroupBoxFunc_ZOA.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupBoxFunc_ZOA.Location = new Point(801, 438);
            GroupBoxFunc_ZOA.Name = "GroupBoxFunc_ZOA";
            GroupBoxFunc_ZOA.Size = new Size(294, 196);
            GroupBoxFunc_ZOA.TabIndex = 12;
            GroupBoxFunc_ZOA.TabStop = false;
            GroupBoxFunc_ZOA.Text = "График:";
            // 
            // GroupBoxAdd_ZOA
            // 
            GroupBoxAdd_ZOA.Controls.Add(ButtonDeleteRow_ZOA);
            GroupBoxAdd_ZOA.Controls.Add(ButtonAddRow_ZOA);
            GroupBoxAdd_ZOA.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupBoxAdd_ZOA.Location = new Point(800, 640);
            GroupBoxAdd_ZOA.Name = "GroupBoxAdd_ZOA";
            GroupBoxAdd_ZOA.Size = new Size(294, 116);
            GroupBoxAdd_ZOA.TabIndex = 13;
            GroupBoxAdd_ZOA.TabStop = false;
            GroupBoxAdd_ZOA.Text = "Добавление строки:";
            // 
            // ButtonDeleteRow_ZOA
            // 
            ButtonDeleteRow_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonDeleteRow_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonDeleteRow_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonDeleteRow_ZOA.Location = new Point(68, 71);
            ButtonDeleteRow_ZOA.Name = "ButtonDeleteRow_ZOA";
            ButtonDeleteRow_ZOA.Size = new Size(154, 36);
            ButtonDeleteRow_ZOA.TabIndex = 1;
            ButtonDeleteRow_ZOA.Text = "Удалить";
            ButtonDeleteRow_ZOA.UseVisualStyleBackColor = false;
            ButtonDeleteRow_ZOA.Click += ButtonDeleteRow_ZOA_Click;
            // 
            // ButtonAddRow_ZOA
            // 
            ButtonAddRow_ZOA.BackColor = Color.FromArgb(255, 214, 237);
            ButtonAddRow_ZOA.FlatStyle = FlatStyle.Flat;
            ButtonAddRow_ZOA.ForeColor = Color.FromArgb(237, 151, 194);
            ButtonAddRow_ZOA.Location = new Point(68, 30);
            ButtonAddRow_ZOA.Name = "ButtonAddRow_ZOA";
            ButtonAddRow_ZOA.Size = new Size(154, 35);
            ButtonAddRow_ZOA.TabIndex = 0;
            ButtonAddRow_ZOA.Text = "Добавить";
            ButtonAddRow_ZOA.UseVisualStyleBackColor = false;
            ButtonAddRow_ZOA.Click += ButtonAddRow_ZOA_Click;
            // 
            // openFileDialog_ZOA
            // 
            openFileDialog_ZOA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 764);
            Controls.Add(GroupBoxAdd_ZOA);
            Controls.Add(GroupBoxFunc_ZOA);
            Controls.Add(GroupBoxMinMaxAvg_ZOA);
            Controls.Add(GroupBoxSearch_ZOA);
            Controls.Add(GroupBoxDataBase_ZOA);
            Controls.Add(PanelMainButtons_ZOA);
            DoubleBuffered = true;
            ForeColor = Color.RosyBrown;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            Text = "⊹ . ° ♱ · ꒰⠀ Спринт7 | Вариант 1 | Замякина О. А. | (⁎ᴗ͈ ⩊ ᴗ͈⁎) ⩍   ׁ  ₊";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)PictureCat_ZOA).EndInit();
            PanelMainButtons_ZOA.ResumeLayout(false);
            PanelMainButtons_ZOA.PerformLayout();
            GroupBoxDataBase_ZOA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataBase_ZOA).EndInit();
            GroupBoxSearch_ZOA.ResumeLayout(false);
            GroupBoxSearch_ZOA.PerformLayout();
            GroupBoxMinMaxAvg_ZOA.ResumeLayout(false);
            GroupBoxMinMaxAvg_ZOA.PerformLayout();
            GroupBoxAdd_ZOA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label MainTitle_ZOA;
        private PictureBox PictureCat_ZOA;
        private System.Windows.Forms.Timer TimerForPictureCat_ZOA;
        private Button ButtonAbout_ZOA;
        private ToolTip ToolTipForButtonAbout_ZOA;
        private Button ButtonDelete_ZOA;
        private Button ButtonSave_ZOA;
        private Button ButtonLoad_ZOA;
        private Button ButtonCancel_ZOA;
        private Button ButtonDiagram_ZOA;
        private Panel PanelMainButtons_ZOA;
        private GroupBox GroupBoxDataBase_ZOA;
        private GroupBox GroupBoxSearch_ZOA;
        private GroupBox GroupBoxMinMaxAvg_ZOA;
        private GroupBox GroupBoxFunc_ZOA;
        private GroupBox GroupBoxAdd_ZOA;
        private Button ButtonFind_ZOA;
        private TextBox TextBoxSearch_ZOA;
        private Button ButtonFiltr_ZOA;
        private TextBox TextBoxFiltr_ZOA;
        private Button ButtonDeleteRow_ZOA;
        private Button ButtonAddRow_ZOA;
        private TextBox TextBoxAvg_ZOA;
        private Label LabelAvg_ZOA;
        private TextBox TextBoxMax_ZOA;
        private TextBox TextBoxMin_ZOA;
        private Label LabelMax_ZOA;
        private Label LabelMin_ZOA;
        private Button ButtonCalculate_ZOA;
        private DataGridView dataGridViewDataBase_ZOA;
        private OpenFileDialog openFileDialog_ZOA;
        private SaveFileDialog saveFileDialog_ZOA;
    }
}
