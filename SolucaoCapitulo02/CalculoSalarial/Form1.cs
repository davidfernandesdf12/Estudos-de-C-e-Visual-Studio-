using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalarial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton rbnTurno = groupTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rbnCategoria = groupCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);

            RealizarProcessamento(rbnTurno, rbnCategoria, Convert.ToDouble(txtSalarioMin.Text), Convert.ToDouble(txtHorasTrab.Text));

        }

        private void RealizarProcessamento(RadioButton rbnTurno, RadioButton rbnCategoria, double HorasTrab, double valorSalarioMin)
        {
            double valorCoeficiente = GetCoeficiente(rbnTurno);
            //double valorGratificado = GetGratificado()
        }

        private double GetCoeficiente(RadioButton rbnTurno)
        {
            double valorCoeficiente = 0;
            switch (rbnTurno.Text)
            {
                case "Matutino":
                    valorCoeficiente = Convert.ToDouble(txtSalarioMin.Text) * 0.01;
                    break;
                case "Vespertino":
                    valorCoeficiente = Convert.ToDouble(txtSalarioMin.Text) * 0.02;
                    break;
                case "Noturno":
                    valorCoeficiente = Convert.ToDouble(txtSalarioMin.Text) * 0.03;
                    break;
                
            }
            return valorCoeficiente;
        }
    }
}
