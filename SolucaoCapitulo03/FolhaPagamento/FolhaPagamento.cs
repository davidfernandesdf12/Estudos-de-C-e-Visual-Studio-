using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class FolhaPagamento : Form
    {
        public class Funcionario
        {
            public int Codigo { get; set; }
            public double Salario { get; set; }
            public double Percentual
            {
                get
                {
                    if (this.Salario < 1000)
                        return 15;
                    else if (this.Salario < 1500)
                        return 10;
                    else
                        return 5;
                }
            }
            public double NovoSalario
            {
                get
                {
                    return (this.Salario * this.Percentual / 100) + this.Salario;
                }
            }
        }
        public class RepositorioFuncionario
        {
            private IList<RepositorioFuncionario> funcionarios = new BindingList<RepositorioFuncionario>();
            //public void Inserir (Funcionario funcionario)
            //{
            //    funcionarios.Add(funcionario);
            //}
        }

        public FolhaPagamento()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
