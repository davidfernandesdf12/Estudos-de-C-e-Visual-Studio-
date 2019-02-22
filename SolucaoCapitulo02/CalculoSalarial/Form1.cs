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

            RealizarProcessamento(rbnTurno, rbnCategoria, Convert.ToDouble(txtHorasTrab.Text), Convert.ToDouble(txtSalarioMin.Text));

        }

        private void RealizarProcessamento(RadioButton rbnTurno, RadioButton rbnCategoria, double HorasTrab, double valorSalarioMin)
        {
            double valorCoeficiente = GetCoeficiente(rbnTurno);
            double valorGratificacao = GetGratificacao(rbnTurno, HorasTrab);
            double valorSalarioBruto = HorasTrab * valorCoeficiente;
            double valorImposto = GetValorImposto(rbnCategoria, valorSalarioBruto);
            double valorAuxilioAlimentacao = GetAuxilioAlimentacao(rbnCategoria, valorSalarioBruto, valorSalarioMin);
            double valorSalarioLiquido = (valorSalarioBruto + valorGratificacao + valorAuxilioAlimentacao) - valorImposto;

            ApresentarResultados(valorCoeficiente, valorSalarioBruto, valorImposto, valorGratificacao, valorAuxilioAlimentacao, valorSalarioLiquido);
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

        private double GetGratificacao(RadioButton rbnTurno, double horasTrabalhadas)
        {
            double valorGradificacao = 30;
            if (rbnTurno.Text.Equals("Noturno") && horasTrabalhadas > 80)
                valorGradificacao = 50;

            return valorGradificacao;
        }

        private static double GetValorImposto(RadioButton rbnCategoria, double valorSalarioBruto)
        {
            double valorImposto = 0;
            switch (rbnCategoria.Text)
            {
                case "Calouro":
                    if (valorSalarioBruto < 300)
                        valorImposto = valorSalarioBruto *  0.01;
                    else
                        valorSalarioBruto = valorSalarioBruto * 0.02; 
                    break;
                case "Veterano":
                    if (valorSalarioBruto < 400)
                        valorImposto = valorSalarioBruto * 0.03;
                    else
                        valorImposto = valorSalarioBruto * 0.04;
                    break;
            }

            return valorImposto;
        }

        private double GetAuxilioAlimentacao(RadioButton rbnCategoria, double valorSalarioBruto, double valorSalarioMin)
        {
            double valorAuxilioAlimentacao = valorSalarioBruto / 6;

            if (rbnCategoria.Text.Equals("Calouro") && (valorSalarioBruto < (valorSalarioMin / 2)))
                valorAuxilioAlimentacao = valorSalarioBruto / 3;

            return valorAuxilioAlimentacao;
        }

        private string GetSituacaoEstagiario(double valorSalarioLiquido)
        {
            if (valorSalarioLiquido < 350)
                return "Mal remunerado";
            else if (valorSalarioLiquido < 600)
                return "Normal";
            else
                return "Bem remunerado";
            
        }

        private void ApresentarResultados(double valorCoeficiente, double valorSalarioBruto, double ValorImposto, double valorGratificacao, double valorAuxilioAlimentacao, double valorSalarioLiquido)
        {
            lblSituacao.Text = GetSituacaoEstagiario(valorSalarioLiquido);
            lbxResumo.Items.Add(string.Format("{0,-29}{1,12:C}", "Valor do coeficiente:", valorCoeficiente));
            lbxResumo.Items.Add(string.Format("{0,-29}{1,12:C}", "Salário Bruto:", valorSalarioBruto));
            lbxResumo.Items.Add(string.Format("{0,-29}{1,12:C}", "Valor do imposto :", ValorImposto));
            lbxResumo.Items.Add(string.Format("{0,-29}{1,12:C}", "Valor da gratificação :", valorGratificacao));
            lbxResumo.Items.Add(string.Format("{0,-29}{1,12:C}", "Valor auxilo alimentação :", valorAuxilioAlimentacao));
            lbxResumo.Items.Add(string.Format("{0,-29}{1,12:C}", "Salário líquido", valorSalarioLiquido));
        }

    }
}
