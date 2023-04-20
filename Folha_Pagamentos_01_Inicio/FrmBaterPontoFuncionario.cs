using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_Pagamentos_01_Inicio
{
    public partial class FrmBaterPontoFuncionario : Form
    {
        public FrmBaterPontoFuncionario()
        {
            InitializeComponent();
        }

        private void FrmBaterPontoFuncionario_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.text_relogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void text_relogio_Click(object sender, EventArgs e)
        {

        }

        private void btnBaterPonto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ponto Registrado com Sucesso!");
        }
    }
}
