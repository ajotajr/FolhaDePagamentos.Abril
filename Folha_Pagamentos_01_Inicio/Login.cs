using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace Folha_Pagamentos_01_Inicio
{



    public partial class Form_Login : Form
    {

        Thread t1;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(text_usuario.Text=="teste" && text_senha.Text=="1234")
            {
                this.Close();
                t1 = new Thread(abrirJanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();

            }
           else if(text_usuario.Text=="funcionario" && text_senha.Text=="1234")
            {
                this.Close();
                t1 = new Thread(abrirJanela2);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválida!");
            }

        void abrirJanela(object obj)
            {
                Application.Run(new form_principal());
            }

            void abrirJanela2(object obj)
            {
                Application.Run(new FrmMenuFuncionario());
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
