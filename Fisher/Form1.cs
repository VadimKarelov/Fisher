using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fisher
{
    public partial class Form1 : Form
    {
        Fishing f = new Fishing(500, 1000);

        public Form1()
        {
            InitializeComponent();
            UpdateValues();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            if (GetSystemParams())
            {
                f.Update(checkBox_Controller.Checked);
                UpdateValues();

                chart_Fish.Series[0].Points.Add(f.Resource);
                chart_Capital.Series[0].Points.Add(f.Capital);
                chart_Fleet.Series[0].Points.Add(f.Fleet);
                chart_PersonalGain.Series[0].Points.Add(f.PersonalGain);
            }
        }

        private void UpdateValues()
        {
            label_Fish.Text = $"Рыба: {f.Resource}";

            label_Capital.Text = "Капитал: " + String.Format("{0:f2}", f.Capital);
            label_MyMoney.Text = "Заработано: " + String.Format("{0:f2}", f.PersonalGain);

            label_Income.Text = "Доход: " + String.Format("{0:f2}", f.Income);
            label_Consumption.Text = "Расход: " + String.Format("{0:f2}", f.Consumption);
            label_Delta.Text = "Разница: " + String.Format("{0:f2}", f.Income - f.Consumption);

            label_Fleet.Text = $"Флот: {f.Fleet}";
            label_Crew.Text = $"Экипаж: {f.Crew}";

            textBox_KInvestment.Text = f.KInvestment.ToString();
            textBox_KSaving.Text = f.KSaving.ToString();
        }

        private bool GetSystemParams()
        {
            bool res = true;
            double t = 0;
            if (double.TryParse(textBox_KInvestment.Text, out t))
            {
                f.KInvestment = t;
            }
            else
            {
                MessageBox.Show("Ошибка ввода k инвестиций");
                res = false;
            }
            if (double.TryParse(textBox_KSaving.Text, out t))
            {
                f.KSaving = t;
            }
            else
            {
                MessageBox.Show("Ошибка ввода k сохранения");
                res = false;
            }
            if (double.TryParse(textBox_KReproduction.Text, out t))
            {
                f.KReproduction = t;
            }
            else
            {
                MessageBox.Show("Ошибка ввода k репродукции");
                res = false;
            }
            if (double.TryParse(textBox_MarketPrice.Text, out t))
            {
                f.MarketPrice = t;
            }
            else
            {
                MessageBox.Show("Ошибка ввода рыночной цены");
                res = false;
            }
            if (double.TryParse(textBox_ShipProduction.Text, out t))
            {
                f.ShipProduction = t;
            }
            else
            {
                MessageBox.Show("Ошибка ввода размера добыи одним судном");
                res = false;
            }
            if (double.TryParse(textBox_ShipPrice.Text, out t))
            {
                f.ShipPrice = t;
            }
            else
            {
                MessageBox.Show("Ошибка ввода цены судна");
                res = false;
            }
            if (double.TryParse(textBox_ShipLife.Text, out t))
            {
                f.ShipLife = t;
            }
            else
            {
                MessageBox.Show("Ошибка ввода срока службы");
                res = false;
            }
            if (double.TryParse(textBox_Salary.Text, out t))
            {
                f.Salary = t;
            }
            else
            {
                MessageBox.Show("Ошибка ввода зарплаты");
                res = false;
            }
            if (double.TryParse(textBox_CrewSize.Text, out t))
            {
                f.CrewNumber = (int)t;
            }
            else
            {
                MessageBox.Show("Ошибка ввода размера экипажа");
                res = false;
            }
            if (f.KInvestment + f.KSaving > 1 || f.KInvestment + f.KSaving < 0)
            { 
                MessageBox.Show("Сумма коэффициентов должна быть не больше 1 и не меньше 0");
                res = false;
            }
            return res;
        }
    }
}
