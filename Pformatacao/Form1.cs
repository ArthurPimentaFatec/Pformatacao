using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pformatacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStringDatas_Click(object sender, EventArgs e)
        {
            DateTime dataExemplo = DateTime.Now;

            MessageBox.Show(dataExemplo.ToString(""));
            MessageBox.Show(dataExemplo.ToString("d"));
            MessageBox.Show(dataExemplo.ToString("D"));
        }

        private void btnStringValores_Click(object sender, EventArgs e)
        {
            double valor = 1255.686;

            MessageBox.Show("Moeda 3 casas decimais " + valor.ToString("C3"));
            MessageBox.Show("Fixo 2 casas decimais " + valor.ToString("F2"));
            MessageBox.Show("Numero 2 casas decimais " + valor.ToString("N2"));
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            DateTime dataExemplo = DateTime.Now;

            MessageBox.Show("ToShortDateString: " + dataExemplo.ToShortDateString());
            MessageBox.Show("ToShortTimeString: " + dataExemplo.ToShortTimeString());
            MessageBox.Show("ToLongDateString: " + dataExemplo.ToLongDateString());
            MessageBox.Show("ToLongTimeString: " + dataExemplo.ToLongTimeString());
        }

        private void btnFormatDatas_Click(object sender, EventArgs e)
        {
            string dataHoje = String.Format("Hoje é {0:d} às {0:t}", DateTime.Now);

            MessageBox.Show(dataHoje);
        }

        private void btnFormatValores_Click(object sender, EventArgs e)
        {
            double valor = 1255.686;

            MessageBox.Show("Moeda 3 casas decimais " + String.Format("{0:C3}", valor));
            MessageBox.Show("Fixo 2 casas decimais " + String.Format("{0:F2}", valor));
            MessageBox.Show("Numero 2 casas decimais " + String.Format("{0:N2}", valor));
        }

        private void btnOperacoesDatas_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
        
            MessageBox.Show("Soma 2 dias: " + dt.AddDays(2).ToShortDateString());
            MessageBox.Show("Soma 2 horas: " + dt.AddHours(2).ToLongTimeString());
            MessageBox.Show("Dia da semana: " + dt.DayOfWeek.ToString());
            MessageBox.Show("Dias no mês 02/2000: " + DateTime.DaysInMonth(2000, 2));

            DateTime dt2 = Convert.ToDateTime("01/02/2023");
            DateTime dt1 = Convert.ToDateTime("06/05/2025");
            double dias = dt1.Subtract(dt2).TotalDays;
            MessageBox.Show($"Diferença entre hoje e 01/02/2023: {dias}");

            if(DateTime.IsLeapYear(2024))
                MessageBox.Show("É bissexto");
            else
                MessageBox.Show("Não é bissexto");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dtEscolhida = monthCalendar1.SelectionStart;

            MessageBox.Show($"Data escolhida: {dtEscolhida.ToString("d")}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtEscolhida = dateTimePicker1.Value;

            MessageBox.Show($"Data escolhida: {dtEscolhida.ToString("d")}");
        }
    }
}
