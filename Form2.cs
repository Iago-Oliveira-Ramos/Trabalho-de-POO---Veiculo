using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Avaliativa_1___POO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Veiculo o_veiculo = new Veiculo();
            o_veiculo.VelocidadeAtual = 0;
            o_veiculo.MarchaAtual = 0;
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int marcha;

            Veiculo o_veiculo = new Veiculo();
            o_veiculo.Marca = textBox1.Text;
            o_veiculo.Modelo = textBox2.Text;
            o_veiculo.Cor = textBox3.Text;
            o_veiculo.Ano = int.Parse(textBox4.Text);
            o_veiculo.NroPortas = int.Parse(textBox5.Text);
            o_veiculo.VelocidadeMax = int.Parse(textBox6.Text);
            o_veiculo.QtdeMarchas = int.Parse(textBox7.Text);

            //MessageBox.Show(o_veiculo.Marca + "\n" + o_veiculo.Modelo + "\n" + o_veiculo.Cor + "\n" + o_veiculo.Ano + "\n" + o_veiculo.NroPortas + "\n" + o_veiculo.VelocidadeMax + "\n" + o_veiculo.QtdeMarchas);


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnImprimir2_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo o_veiculo = new Veiculo();
                o_veiculo.Marca = textBox1.Text;
                o_veiculo.Modelo = textBox2.Text;
                o_veiculo.Cor = textBox3.Text;
                o_veiculo.Ano = int.Parse(textBox4.Text);
                o_veiculo.NroPortas = int.Parse(textBox5.Text);
                o_veiculo.VelocidadeMax = int.Parse(textBox6.Text);
                o_veiculo.QtdeMarchas = int.Parse(textBox7.Text);
                o_veiculo.Proprietario = textBox8.Text;

                o_veiculo.imprimirDados();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Atenção: Informe todos os atributos do seu carro para imprimir os dados.");
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAcelerar2_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo o_veiculo = new Veiculo();
                o_veiculo.VelocidadeMax = int.Parse(textBox6.Text);
                o_veiculo.acelerar();
            }
            catch(Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Atenção: Informe a velocidade máxima do seu carro.");
            }
        }

        private void btnFreiar2_Click(object sender, EventArgs e)
        {
            Veiculo o_veiculo = new Veiculo();
            o_veiculo.frear();
        }

        private void btnAlterarMarcha2_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo o_veiculo = new Veiculo();
                o_veiculo.QtdeMarchas = int.Parse(textBox7.Text);
                o_veiculo.alterarMarcha(int.Parse(textBox9.Text));
            }
            catch(Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Atenção: Para acionar este botão, a quantidade de marchas e a marcha selecionada devem ser informadas.");
            }
        }
    }
}
