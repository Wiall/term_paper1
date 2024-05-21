using System;
using System.Windows.Forms;

namespace term_paper_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(textBox1.Text, out int length) || length < 100 || length > 50000)
            {
                MessageBox.Show("Некоректний розмір масиву. Розмір масиву має бути\nцілим додатнім числом від 100 до 50 000");
                return;
            }
            Sorting.SortingVariant variant = Sorting.SortingVariant.Random;
            if (radioButton1.Checked)
                variant = Sorting.SortingVariant.Random;
            else if (radioButton2.Checked)
                variant = Sorting.SortingVariant.Order;
            else if (radioButton3.Checked)
                variant = Sorting.SortingVariant.Invert;
            if (!int.TryParse(textBox2.Text, out int minValue) || !int.TryParse(textBox3.Text, out int maxValue))
            {
                MessageBox.Show("Некоректні значення мінімуму або максимуму.");
                return;
            }
            if (minValue == maxValue)
            {
                MessageBox.Show("Мінімальне та максимальне значення не можуть бути однаковими.");
                return;
            }
            if (minValue > maxValue)
            {
                MessageBox.Show("Максимальне значення має бути більше за мінімальне.");
                return;
            }
            if (maxValue - minValue + 1 < length)
            {
                MessageBox.Show("Діапазон між мінімальним та максимальним значеннями не може бути менше за розмір масиву.");
                return;
            }
            if (Math.Abs(maxValue) > 50000 || Math.Abs(minValue) > 50000)
            {
                MessageBox.Show("Введено завеликі значення для діапазону елементів.");
                return;
            }
            try
            {
                Sorting sort = new Sorting();
                sort.FillArray(length, variant, minValue, maxValue);
                MessageBox.Show("Масив заповнено успішно.");
                Sorting.ChosenVariant = variant;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Hide();
            SortingOptionsForm sortingOptionsForm = new SortingOptionsForm();
            sortingOptionsForm.ShowDialog();
            UpdateForm();
        }

        private void UpdateForm()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
            Show();
        }
    }
}