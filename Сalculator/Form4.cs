using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class Form4 : Form
    {
        Form1 frm;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form1 f)
        {
            InitializeComponent();
            frm = f;//связь с первой формой
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string st;
            st = textBox1.Text;
            try
            {
                int t = Convert.ToInt32(st);
                if (t >= 1)
                {
                    frm.EnterText(textBox1.Text + "д");//вводим дни в основную форму
                    frm.ClickResDate(true);
                    frm.ClickEntDate(false);
                    frm.ClickEnterDays(false);
                    frm.ClickEnterMonth(false);
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка!Введено не натуральное число дней!");//вызываем окно ошибки
                }
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Ошибка! Вы ввели слишком большое число!");//вызываем окно ошибки
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ошибка! Вы ввели не число!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
