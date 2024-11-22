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
    public partial class Form1 : Form
    {
        public bool flag=false;//флаг для проверки наличия операции + или -
        public bool TypeData = true;//флаг переключения форматов даты (true-российский формат)
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormatData_SelectedIndexChanged(object sender, EventArgs e)//нажатие переключателя форматы даты
        {
            TypeData = !TypeData;//Меняем флаг переключателя форматов даты.
        }

        private void Delete_Click(object sender, EventArgs e)//нажатие клавиши delete
        {
            string t = EnterT.Text;
            if (t != "")//проверяем наличие текста
            {
                string tmp;
                switch (t[t.Length - 1])
                {
                    case '+':
                        flag = false;
                        ClickMinus(true);
                        ClickPlus(true);
                        ClickEnterMonth(false);
                        ClickEnterDays(false);
                        ClickEntDate(false);
                        tmp = t.Substring(0, t.Length - 1);//удаляем поселдний знак
                        break;
                    case '-':
                        flag = false;
                        ClickMinus(true);
                        ClickPlus(true);
                        ClickEnterMonth(false);
                        ClickEnterDays(false);
                        ClickEntDate(false);
                        tmp = t.Substring(0, t.Length - 1);//удаляем поселдний знак
                        break;
                    case 'д':
                        ClickEnterMonth(true);
                        ClickEnterDays(true);
                        ClickResDate(false);
                        Result.Text = "";
                        if (t[10] == '-')
                            ClickEntDate(true);
                        tmp = t.Substring(0, 11);
                        break;
                    case 'м':
                        ClickEnterMonth(true);
                        ClickEnterDays(true);
                        ClickResDate(false);
                        Result.Text = "";
                        if (t[10] == '-')
                            ClickEntDate(true);
                        tmp = t.Substring(0, 11);
                        break;
                    default:
                        if (flag)
                        {
                            ClickEnterMonth(true);
                            ClickEnterDays(true);
                                if(t[10]=='-')//проверяем стоит минус или плюс
                                ClickEntDate(true);
                            ClickResDays(false);
                            ClickResHours(false);
                            ClickResMinutes(false);
                            ClickResMonth(false);
                            ClickResWeeks(false);
                            ClickResSecond(false);
                            Result.Text = "";
                            tmp = t.Substring(0, 11);
                        }
                        else
                        {
                            ClickEntDate(true);
                            ClickMinus(false);
                            ClickPlus(false);
                            tmp = "";
                        }
                        break;
                }
                EnterT.Text = tmp;
            }
            t = EnterT.Text;
            if (t == "")
                EnableTypeOfDate(true);
        }
        private void EnterData_Click(object sender, EventArgs e)//форма ввода даты
        {
            Form2 newForm = new Form2(this);
            newForm.ShowDialog();//подключаем форму ввода даты
        }
        public void ClickResDate(bool b1)
        {
            ResDate.Enabled=b1;
        }
        public void ClickEnterMonth(bool b1)//включаем отключаем ввод месяцев
        {
            EnterMonth.Enabled = b1;
        }
        public void ClickEnterDays(bool b1)//включаем отключаем ввод дней
        {
            EnterDays.Enabled = b1;
        }
        public void ClickResHours(bool b1)//=Часы включение выключение
        {
            ResHours.Enabled = b1;
        }
        public void ClickResDays(bool b1)//=Дни включение выключение кнопки
        {
            ResDays.Enabled = b1;
        }
        public void ClickResWeeks(bool b1)//=Недели включение отключение кнопки
        {
            ResWeeks.Enabled = b1;
        }
        public void ClickResMonth(bool b1)//=Month включение отключение
        {
            ResMonth.Enabled = b1;
        }
        public void ClickResMinutes(bool b1)//=Minutes включение отключение
        {
            ResMinutes.Enabled = b1;
        }
        public void ClickResSecond (bool b1)//включаем выключаем секунды
        {
            ResSeconds.Enabled = b1;
        }
        public void ClickPlus(bool b1)//включаем выключаем кнопку плюса
        {
            plus.Enabled = b1;
        }
        public void ClickMinus(bool b1)//включаем выключаем кнопку минуса
        {
            minus.Enabled = b1;
        }
        public void ClickEntDate(bool b1)//включаем выключаем кнопку ввода даты
        {
            EnterData.Enabled = b1;
        }
        public void EnableTypeOfDate(bool b1)//включаем выключаем смену формата даты
        {
            FormatData.Enabled = b1;
        }
        public void EnterText(string str)//изменяем строку ввода
        {
            EnterT.Text = EnterT.Text + str;
        }

        private void minus_Click(object sender, EventArgs e)//нажатие на кнопку минуса
        {
            flag =true;
            EnterText("-");
            ClickMinus(false);//отклчили кнопку
            ClickPlus(false);//отклчили кнопку
            ClickEntDate(true);
            ClickEnterDays(true);
            ClickEnterMonth(true);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            flag = true;
            EnterText("+");
            ClickMinus(false);//отклчили кнопку
            ClickPlus(false);//отклчили кнопку
            ClickEnterDays(true);
            ClickEnterMonth(true);
        }

        private void EnterMonth_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.ShowDialog();//подключаем форму ввода месяца
        }

        private void EnterDays_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(this);
            newForm.ShowDialog();//подключаем форму ввода дней
        }

        private void ResDate_Click(object sender, EventArgs e)
        {
            string strDate;//переменная для временного хранения даты
            string newDate;//переменная для конечной даты
            if (TypeData == false)
            {
                strDate = EnterT.Text.Substring(3, 3) + EnterT.Text.Substring(0, 3) + EnterT.Text.Substring(6, 4);
            }
            else
                strDate = EnterT.Text.Substring(0, 10);
            DateTime d = new DateTime();//создаем перменную датетайм
            d=DateTime.Parse(strDate);//переводим строку в датетайм
            try
            {
                if (EnterT.Text[EnterT.Text.Length - 1] == 'д')//проверяем последний символ строки
                {
                    int NumDays = Convert.ToInt32(EnterT.Text.Substring(11, EnterT.Text.Length - 12));//выделяем к-во дней из строки
                    if (EnterT.Text[10] == '-')//проверяем знак операции
                    {
                        NumDays = NumDays * (-1);//меняем знак
                    }
                    d = d.AddDays(NumDays);//добавляем или вычитаем дни
                }
                else
                {
                    int NumMonth = Convert.ToInt32(EnterT.Text.Substring(11, EnterT.Text.Length - 12));//выделяем к-во месяцев из строки
                    if (EnterT.Text[10] == '-')//проверяем знак операции
                    {
                        NumMonth = NumMonth * (-1);//меняем знак
                    }
                    d = d.AddMonths(NumMonth);//добавляем или вычитаем месяцы
                }
                newDate = Convert.ToString(d.ToShortDateString());//записываем конечную дату
                if (TypeData == false)//проверяем формат
                {
                    newDate = newDate.Substring(3, 3) + newDate.Substring(0, 3) + newDate.Substring(6, 4);
                }
                Result.Text = newDate;
            }
            catch(System.ArgumentOutOfRangeException)//ошибка выхода за пределы возможных  дат
            {
                MessageBox.Show("Ошибка! Ответ выходит за пределы реализованного диапазона дат");
            }
        }

        private void ResSeconds_Click(object sender, EventArgs e)
        {
            string strDate;//переменная для временного хранения даты
            if (TypeData == false)
            {
                strDate = EnterT.Text.Substring(3, 3) + EnterT.Text.Substring(0, 3) + EnterT.Text.Substring(6, 4);
            }
            else
                strDate = EnterT.Text.Substring(0, 10);
            DateTime d = new DateTime();//создаем перменную датетайм d (первая дата)
            d = DateTime.Parse(strDate);//переводим строку в датетайм

            if (TypeData == false)
            {
                strDate = EnterT.Text.Substring(14, 3) + EnterT.Text.Substring(11, 3) + EnterT.Text.Substring(17, 4);
            }
            else
                strDate = EnterT.Text.Substring(11, 10);
            DateTime b = new DateTime();//создаем перменную датетайм b (вторая дата)
            b = DateTime.Parse(strDate);//переводим строку в датетайм

            int a = DateTime.Compare(d, b); //переменная для определения правильности записи дат 
            if (a > 0)
            {
                TimeSpan diff1 = d.Subtract(b); //ищем разницу между 2 датами
                double time = Math.Abs(diff1.TotalSeconds); //переводим разницу в секунды
                Result.Text = time.ToString() + " с";
            }
            else
                if (a == 0)
                Result.Text ="0 с";
                else MessageBox.Show("Ошибка! Первая дата раньше второй!");
        }

        private void ResMinutes_Click(object sender, EventArgs e)
        {
            string strDate;//переменная для временного хранения даты
            if (TypeData == false)
            {
                strDate = EnterT.Text.Substring(3, 3) + EnterT.Text.Substring(0, 3) + EnterT.Text.Substring(6, 4);
            }
            else
                strDate = EnterT.Text.Substring(0, 10);
            DateTime d = new DateTime();//создаем перменную датетайм d (первая дата)
            d = DateTime.Parse(strDate);//переводим строку в датетайм

            if (TypeData == false)
            {
                strDate = EnterT.Text.Substring(14, 3) + EnterT.Text.Substring(11, 3) + EnterT.Text.Substring(17, 4);
            }
            else
                strDate = EnterT.Text.Substring(11, 10);
            DateTime b = new DateTime();//создаем перменную датетайм b (вторая дата)
            b = DateTime.Parse(strDate);//переводим строку в датетайм
            int a = DateTime.Compare(d, b); //переменная для определения правильности записи дат 
            if (a > 0)
            {
                TimeSpan diff1 = d.Subtract(b); //ищем разницу между 2 датами
                double time = Math.Abs(diff1.TotalMinutes); //переводим разницу в минуты
                Result.Text = time.ToString() + " м";
            }
            else
                if (a == 0)
                Result.Text = "0 м";
            else MessageBox.Show("Ошибка! Первая дата раньше второй!");
        }

        private void ResMonth_Click(object sender, EventArgs e)
        {
            string strDate;//переменная для временного хранения даты

            string strDate2;
            if (TypeData == false)
            {
                strDate = EnterT.Text.Substring(3, 3) + EnterT.Text.Substring(0, 3) + EnterT.Text.Substring(6, 4);
                strDate2 = EnterT.Text.Substring(14, 3) + EnterT.Text.Substring(11, 3) + EnterT.Text.Substring(17, 4);
            }
            else
            {
                strDate = EnterT.Text.Substring(0, 10);
                strDate2 = EnterT.Text.Substring(11, 10);
            }
            DateTime date1 = new DateTime();//создаем перменную датетайм
            DateTime date2 = new DateTime();//создаем перменную датетайм
            date1 = DateTime.Parse(strDate);//переводим строку в датетайм
            date2 = DateTime.Parse(strDate2);//переводим строку в датетайм
            TimeSpan f;
            try
            {
                f = date1.Subtract(date2);
                int q;
                q = Convert.ToInt32(f.Days);
                double qq,qqq;
                qq = q / 30;
                qqq = q % 30;
                if (q >= 0)
                {
                    Result.Text = Convert.ToString(qq)+"," +Convert.ToString(qqq)+ " м";
                }
                else
                {
                    MessageBox.Show("Ошибка! Первая дата раньше второй!");
                }


            }
            catch (System.ArgumentOutOfRangeException)//ошибка выхода за пределы возможных  дат
            {
                MessageBox.Show("Ошибка! Ответ выходит за пределы реализованного диапазона дат");
            }
        }

        private void ResHours_Click(object sender, EventArgs e)
        {
            string strDate;//переменная для временного хранения даты
            if (TypeData == false)
            {
                strDate = EnterT.Text.Substring(3, 3) + EnterT.Text.Substring(0, 3) + EnterT.Text.Substring(6, 4);
            }
            else
                strDate = EnterT.Text.Substring(0, 10);
            DateTime d = new DateTime();//создаем перменную датетайм d (первая дата)
            d = DateTime.Parse(strDate);//переводим строку в датетайм

            if (TypeData == false)
            {
                strDate = EnterT.Text.Substring(14, 3) + EnterT.Text.Substring(11, 3) + EnterT.Text.Substring(17, 4);
            }
            else
                strDate = EnterT.Text.Substring(11, 10);
            DateTime b = new DateTime();//создаем перменную датетайм b (вторая дата)
            b = DateTime.Parse(strDate);//переводим строку в датетайм
            int a = DateTime.Compare(d, b); //переменная для определения правильности записи дат 
            if (a > 0)
            {
                TimeSpan diff1 = d.Subtract(b); //ищем разницу между 2 датами
                double time = Math.Abs(diff1.TotalHours); //переводим разницу в часы
                Result.Text = time.ToString() + " ч";
            }
            else
                if (a == 0)
                Result.Text = "0 ч";
            else MessageBox.Show("Ошибка! Первая дата раньше второй!");
        }

        private void ResWeeks_Click(object sender, EventArgs e)
        {
            string strDate;//переменная для временного хранения даты

            string strDate2;
            if (TypeData == false)
            {
                strDate = EnterT.Text.Substring(3, 3) + EnterT.Text.Substring(0, 3) + EnterT.Text.Substring(6, 4);
                strDate2 = EnterT.Text.Substring(14, 3) + EnterT.Text.Substring(11, 3) + EnterT.Text.Substring(17, 4);
            }
            else
            {
                strDate = EnterT.Text.Substring(0, 10);
                strDate2 = EnterT.Text.Substring(11, 10);
            }
            DateTime date1 = new DateTime();//создаем перменную датетайм
            DateTime date2 = new DateTime();//создаем перменную датетайм
            date1 = DateTime.Parse(strDate);//переводим строку в датетайм
            date2 = DateTime.Parse(strDate2);//переводим строку в датетайм
            TimeSpan f;
            try
            {
                f = date1.Subtract(date2);
                int q;
                q = Convert.ToInt32(f.Days);
                double qq, qqq;
                qq = q / 7;
                qqq = q % 7;
                if (q >= 0)
                {
                    Result.Text = Convert.ToString(qq) + "," + Convert.ToString(qqq) + " н";
                }
                else
                {
                    MessageBox.Show("Ошибка! Первая дата раньше второй!");
                }


            }
            catch (System.ArgumentOutOfRangeException)//ошибка выхода за пределы возможных  дат
            {
                MessageBox.Show("Ошибка! Ответ выходит за пределы реализованного диапазона дат");
            }
        }

        private void ResDays_Click(object sender, EventArgs e)
        {
            string strDate;//переменная для временного хранения даты

            string strDate2;
            if (TypeData == false)
            {
                strDate = EnterT.Text.Substring(3, 3) + EnterT.Text.Substring(0, 3) + EnterT.Text.Substring(6, 4);
                strDate2= EnterT.Text.Substring(14, 3)+ EnterT.Text.Substring(11, 3)+EnterT.Text.Substring(17, 4) ;
            }
            else
            {
                strDate = EnterT.Text.Substring(0, 10);
                strDate2= EnterT.Text.Substring(11, 10);
            }
            DateTime date1 = new DateTime();//создаем перменную датетайм
            DateTime date2 = new DateTime();//создаем перменную датетайм
            date1 = DateTime.Parse(strDate);//переводим строку в датетайм
            date2 = DateTime.Parse(strDate2);//переводим строку в датетайм
            TimeSpan f;
            try
            {
                f = date1.Subtract(date2);
                int q;
                q = Convert.ToInt32(f.Days);
                if (q >= 0)
                {
                    Result.Text = Convert.ToString(f.Days) + " д";
                }
                else
                {
                    MessageBox.Show("Ошибка! Первая дата раньше второй!");
                }
               
                
            }
            catch (System.ArgumentOutOfRangeException)//ошибка выхода за пределы возможных  дат
            {
                MessageBox.Show("Ошибка! Ответ выходит за пределы реализованного диапазона дат");
            }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
