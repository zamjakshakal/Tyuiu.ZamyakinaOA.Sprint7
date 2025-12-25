using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZamyakinaOA.Sprint7.V1.Lib;
namespace Tyuiu.ZamyakinaOA.Sprint7.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Изначальный вид кнопок без загруженного файла
        private void FormMain_Load(object sender, EventArgs e)
        {
            ButtonSave_ZOA.Enabled = false;
            ButtonCancel_ZOA.Enabled = false;
            ButtonDelete_ZOA.Enabled = false;
            TextBoxSearch_ZOA.Enabled = false;
            TextBoxSearch_ZOA.Visible = false;
            TextBoxAvg_ZOA.Enabled = false;
            TextBoxAvg_ZOA.Visible = false;
            TextBoxMax_ZOA.Enabled = false;
            TextBoxMax_ZOA.Visible = false;
            TextBoxMin_ZOA.Enabled = false;
            TextBoxMin_ZOA.Visible = false;
            ButtonFind_ZOA.Enabled = false;
            ButtonFind_ZOA.Visible = false;
            ButtonCalculate_ZOA.Enabled = false;
            ButtonCalculate_ZOA.Visible = false;
            ButtonAddRow_ZOA.Enabled = false;
            ButtonAddRow_ZOA.Visible = false;
            ButtonDeleteRow_ZOA.Enabled = false;
            ButtonDeleteRow_ZOA.Visible = false;
            ButtonDiagram_ZOA.Enabled = false;
            TextBoxFiltr_ZOA.Enabled = false;
            TextBoxFiltr_ZOA.Visible = false;
            ButtonFiltr_ZOA.Enabled = false;
            ButtonFiltr_ZOA.Visible = false;
            LabelMin_ZOA.Visible = false;
            LabelMax_ZOA.Visible = false;
            LabelAvg_ZOA.Visible = false;
            buttonCancelFind_ZOA.Visible = false;
            buttonCancelFiltr_ZOA.Visible = false;
        }
        // Изначальный вид кнопок без загруженного файла


        // Код для котика около заголовка "Авторемонтные мастерские"
        private void PictureCat_ZOA_Click(object sender, EventArgs e)
        {
            PictureCat_ZOA.Image = Properties.Resources.cutecat_clicked;
            TimerForPictureCat_ZOA.Start();
        }
        private void TimerForPictureCat_ZOA_Tick(object sender, EventArgs e)
        {
            TimerForPictureCat_ZOA.Stop();
            PictureCat_ZOA.Image = Properties.Resources.cutecat_default;
        }
        // Код для котика около заголовка "Авторемонтные мастерские"


        public string openFilePath;
        public int column, rows;
        bool issemicolon = true;


        // Окрытие csv-файла
        private void ButtonLoad_ZOA_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_ZOA.Rows.Clear();
            if (!issemicolon)
            {
                try
                {
                    dataGridViewDataBase_ZOA.AllowUserToAddRows = false;
                    openFileDialog_ZOA.ShowDialog();
                    openFilePath = openFileDialog_ZOA.FileName;
                    column = File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;


                    dataGridViewDataBase_ZOA.ColumnCount = column;
                    using (var reader = new StreamReader(openFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            dataGridViewDataBase_ZOA.Rows.Add(values);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Выбран неверный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    openFileDialog_ZOA.ShowDialog();
                    openFilePath = openFileDialog_ZOA.FileName;
                    column = File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;

                    dataGridViewDataBase_ZOA.AllowUserToAddRows = false;
                    dataGridViewDataBase_ZOA.ColumnCount = column;
                    using (var reader = new StreamReader(openFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            dataGridViewDataBase_ZOA.Rows.Add(values);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Выбран неверный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            column = dataGridViewDataBase_ZOA.Columns.Count;
            rows = dataGridViewDataBase_ZOA.Rows.Count;

            dataGridViewDataBase_ZOA.Rows[0].Cells[0].Selected = false;

            ButtonSave_ZOA.Enabled = true;
            ButtonCancel_ZOA.Enabled = true;
            ButtonDelete_ZOA.Enabled = true;
            TextBoxSearch_ZOA.Enabled = true;
            TextBoxSearch_ZOA.Visible = true;
            TextBoxAvg_ZOA.Enabled = true;
            TextBoxAvg_ZOA.Visible = true;
            TextBoxMax_ZOA.Enabled = true;
            TextBoxMax_ZOA.Visible = true;
            TextBoxMin_ZOA.Enabled = true;
            TextBoxMin_ZOA.Visible = true;
            ButtonFind_ZOA.Enabled = true;
            ButtonFind_ZOA.Visible = true;
            ButtonCalculate_ZOA.Enabled = true;
            ButtonCalculate_ZOA.Visible = true;
            ButtonAddRow_ZOA.Enabled = true;
            ButtonAddRow_ZOA.Visible = true;
            ButtonDeleteRow_ZOA.Enabled = true;
            ButtonDeleteRow_ZOA.Visible = true;
            ButtonDiagram_ZOA.Enabled = true;
            TextBoxFiltr_ZOA.Enabled = true;
            TextBoxFiltr_ZOA.Visible = true;
            ButtonFiltr_ZOA.Enabled = true;
            ButtonFiltr_ZOA.Visible = true;
            LabelMin_ZOA.Visible = true;
            LabelMax_ZOA.Visible = true;
            LabelAvg_ZOA.Visible = true;
            buttonCancelFind_ZOA.Visible = true;
            buttonCancelFiltr_ZOA.Visible = true;
        }
        // Окрытие csv-файла


        // Сохранение файла
        private void ButtonSave_ZOA_Click(object sender, EventArgs e)
        {
            if (!issemicolon)
            {
                try
                {
                    saveFileDialog_ZOA.FileName = ".csv";
                    saveFileDialog_ZOA.InitialDirectory = @":L";
                    if (saveFileDialog_ZOA.ShowDialog() == DialogResult.OK)
                    {
                        string savepath = saveFileDialog_ZOA.FileName;

                        if (File.Exists(savepath)) File.Delete(savepath);

                        int rows = dataGridViewDataBase_ZOA.RowCount;
                        int columns = dataGridViewDataBase_ZOA.ColumnCount;

                        StringBuilder strBuilder = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                strBuilder.Append(dataGridViewDataBase_ZOA.Rows[i].Cells[j].Value);

                                if (j != columns - 1) strBuilder.Append(",");
                            }
                            strBuilder.AppendLine();
                        }
                        File.WriteAllText(savepath, strBuilder.ToString(), Encoding.UTF8);
                        MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    saveFileDialog_ZOA.FileName = ".csv";
                    saveFileDialog_ZOA.InitialDirectory = @":L";
                    if (saveFileDialog_ZOA.ShowDialog() == DialogResult.OK)
                    {
                        string savepath = saveFileDialog_ZOA.FileName;

                        if (File.Exists(savepath)) File.Delete(savepath);

                        int rows = dataGridViewDataBase_ZOA.RowCount;
                        int columns = dataGridViewDataBase_ZOA.ColumnCount;

                        StringBuilder strBuilder = new StringBuilder();

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                strBuilder.Append(dataGridViewDataBase_ZOA.Rows[i].Cells[j].Value);

                                if (j != columns - 1) strBuilder.Append(";");
                            }
                            strBuilder.AppendLine();
                        }
                        File.WriteAllText(savepath, strBuilder.ToString(), Encoding.UTF8);
                        MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Сохранение файла


        // Удаление файла
        private void buttonDelete_ZOA_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_ZOA.Rows.Clear();

            ButtonSave_ZOA.Enabled = false;
            ButtonCancel_ZOA.Enabled = false;
            ButtonDelete_ZOA.Enabled = false;
            TextBoxSearch_ZOA.Enabled = false;
            TextBoxSearch_ZOA.Visible = false;
            TextBoxAvg_ZOA.Enabled = false;
            TextBoxAvg_ZOA.Visible = false;
            TextBoxMax_ZOA.Enabled = false;
            TextBoxMax_ZOA.Visible = false;
            TextBoxMin_ZOA.Enabled = false;
            TextBoxMin_ZOA.Visible = false;
            ButtonFind_ZOA.Enabled = false;
            ButtonFind_ZOA.Visible = false;
            ButtonCalculate_ZOA.Enabled = false;
            ButtonCalculate_ZOA.Visible = false;
            ButtonAddRow_ZOA.Enabled = false;
            ButtonAddRow_ZOA.Visible = false;
            ButtonDeleteRow_ZOA.Enabled = false;
            ButtonDeleteRow_ZOA.Visible = false;
            ButtonDiagram_ZOA.Enabled = false;
            TextBoxFiltr_ZOA.Enabled = false;
            TextBoxFiltr_ZOA.Visible = false;
            ButtonFiltr_ZOA.Enabled = false;
            ButtonFiltr_ZOA.Visible = false;
            LabelMin_ZOA.Visible = false;
            LabelMax_ZOA.Visible = false;
            LabelAvg_ZOA.Visible = false;
            buttonCancelFind_ZOA.Visible = false;
            buttonCancelFiltr_ZOA.Visible = false;
        }
        // Удаление файла


        // Отмена действий недавно совершенных над файлом
        private void ButtonCancelChanges_ZOA_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_ZOA.Rows.Clear();
            if (!issemicolon)
            {
                try
                {
                    column = File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;


                    dataGridViewDataBase_ZOA.ColumnCount = column;
                    using (var reader = new StreamReader(openFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            dataGridViewDataBase_ZOA.Rows.Add(values);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    column = File.ReadAllLines(openFilePath, Encoding.UTF8).Length + 1;


                    dataGridViewDataBase_ZOA.ColumnCount = column;
                    using (var reader = new StreamReader(openFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            dataGridViewDataBase_ZOA.Rows.Add(values);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            column = dataGridViewDataBase_ZOA.Columns.Count;
            rows = dataGridViewDataBase_ZOA.Rows.Count;

            dataGridViewDataBase_ZOA.Rows[0].Cells[0].Selected = false;
        }
        // Отмена действий недавно совершенных над файлом


        // Счет минимального, максимамльного и среднего значений
        private void ButtonCalculate_ZOA_Click(object sender, EventArgs e)
        {
            int columnIndex = 4; // пятый столбец

            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridViewDataBase_ZOA.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var cellValue = row.Cells[columnIndex].Value;
                if (cellValue == null)
                    continue;

                if (double.TryParse(cellValue.ToString().Trim(), out double value))
                {
                    if (value < min) min = value;
                    if (value > max) max = value;

                    sum += value;
                    count++;
                }
            }

            if (count == 0)
                return;

            TextBoxMin_ZOA.Text = min.ToString();
            TextBoxMax_ZOA.Text = max.ToString();
            TextBoxAvg_ZOA.Text = (sum / count).ToString();
        }
        // Счет минимального, максимамльного и среднего значений


        // Добавление и удалении строчек
        private void ButtonAddRow_ZOA_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_ZOA.Rows.Add();
            rows++;

        }
        private void ButtonDeleteRow_ZOA_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_ZOA.Rows.RemoveAt(dataGridViewDataBase_ZOA.Rows.Count - 1);
            rows--;
        }
        // Добавление и удалении строчек


        // Кнопка фильтра
        private void ButtonFiltr_ZOA_Click(object sender, EventArgs e)
        {

            dataGridViewDataBase_ZOA.ClearSelection();

            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (dataGridViewDataBase_ZOA.Rows[i].Cells[j].Value != null && dataGridViewDataBase_ZOA.Rows[i].Cells[j].Value.ToString().ToLower().Contains(TextBoxFiltr_ZOA.Text.ToLower()))
                        {
                            dataGridViewDataBase_ZOA.Rows[i].Selected = true;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Кнопка фильтра


        // Кнопка поиска
        private void ButtonFind_ZOA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewDataBase_ZOA.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (dataGridViewDataBase_ZOA.Rows[i].Cells[j].Value != null && dataGridViewDataBase_ZOA.Rows[i].Cells[j].Value.ToString().ToLower().Contains(TextBoxSearch_ZOA.Text.ToLower()))
                        {
                            dataGridViewDataBase_ZOA.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Кнопка поиска


        // Открытие руководства
        private void ButtonAbout_ZOA_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
        // Открытие руководства


        // сортировка
        private void dataGridViewDataBase_ZOA_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            int so = 1;
            if (dataGridViewDataBase_ZOA.SortOrder == SortOrder.Ascending)
            {
                so = -1;
            }
            if (e.RowIndex1 == 0)
            {
                e.SortResult = so;
                e.Handled = true;
            }
            if (e.RowIndex2 == 0)
            {
                e.SortResult = -so;
                e.Handled = true;
            }
        }
        // сортирровка


        // отмена поиска
        private void buttonCancelFind_ZOA_Click(object sender, EventArgs e)
        {
            TextBoxSearch_ZOA.Text = null;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewDataBase_ZOA.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }
        // отмена поиска


        // отмена фильтра
        private void buttonCancelFiltr_ZOA_Click(object sender, EventArgs e)
        {
            dataGridViewDataBase_ZOA.ClearSelection();
            TextBoxFiltr_ZOA.Text = null;
        }
        // отмена фильтра
    }
}
