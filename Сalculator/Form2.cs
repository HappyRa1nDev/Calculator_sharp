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
    public partial class Form2 : Form
    {
        DateTime d = new DateTime();
        Form1 frm;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            frm = f;//связь с первой формой
            if (frm.TypeData)
                this.label1.Text = "Введите дату в Российском формате";
            else
                this.label1.Text = "Введите дату в Американском формате";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//нажатие на кнопку далее
        {
            string st;
            if (frm.TypeData)//проверяем тип даты
            {
                st = date.Text;
            }
            else
            {
              st = date.Text.Substring(3, 3) + date.Text.Substring(0, 2) + date.Text.Substring(5, 5);//переводим в американский формат мм.дд.гггг
            }
                bool b = DateTime.TryParse(st, out d);
                if (b == true&&!date.Text.Contains(" ")&&date.Text.Length==10)
                {
                if (!frm.flag)
                {
                    frm.EnterText(date.Text);//вводим дату в основную форму
                    frm.EnableTypeOfDate(false);
                    frm.ClickEntDate(false);
                    frm.ClickMinus(true);
                    frm.ClickPlus(true);
                    frm.ClickEnterDays(false);
                    frm.ClickEnterMonth(false);
                }
                else
                {
                    frm.ClickEntDate(false);
                    frm.EnterText(date.Text);
                    frm.ClickEnterDays(false);
                    frm.ClickEnterMonth(false);
                    frm.ClickResDays(true);
                    frm.ClickResHours(true);
                    frm.ClickResMinutes(true);
                    frm.ClickResMonth(true);
                    frm.ClickResWeeks(true);
                    frm.ClickResSecond(true);
                }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка! Введен неверный формат даты!" + date.Text);//вызываем окно ошибки
                }
        }
    }
}
