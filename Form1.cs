using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Avaliativa_1___POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int marcha;

            Veiculo o_veiculo = new Veiculo();
            o_veiculo.Marca = "Chevrolet";
            o_veiculo.Modelo = "Onix";
            o_veiculo.Cor = "Azul escuro";
            o_veiculo.Ano = 2019;
            o_veiculo.NroPortas = 4;
            o_veiculo.VelocidadeMax = 171;
            o_veiculo.QtdeMarchas = 6;

            Console.WriteLine();
            o_veiculo.acelerar();
            marcha = o_veiculo.alterarMarcha(0);
           
            //Console.WriteLine(o_veiculo.velocidadeAtual);
            //o_veiculo.acelerar();
            //o_veiculo.acelerar();
            //o_veiculo.acelerar();
            //o_veiculo.acelerar();
            //Console.WriteLine(o_veiculo.velocidadeAtual);
            //o_veiculo.frear();
            //Console.WriteLine(o_veiculo.velocidadeAtual);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            int marcha;

            Veiculo o_veiculo = new Veiculo();
            o_veiculo.Marca = "Chevrolet";
            o_veiculo.Modelo = "Onix";
            o_veiculo.Cor = "Azul escuro";
            o_veiculo.Ano = 2019;
            o_veiculo.NroPortas = 4;
            o_veiculo.VelocidadeMax = 171;
            o_veiculo.QtdeMarchas = 6;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 o_form2 = new Form2();
            o_form2.Show();
            
        }

        private void btnAcelerar1_Click(object sender, EventArgs e)
        {
            

            Veiculo o_veiculo = new Veiculo();
            o_veiculo.VelocidadeMax = 171;
            o_veiculo.acelerar();
            
            

        }

        private void btnFrear1_Click(object sender, EventArgs e)
        {
            Veiculo o_veiculo = new Veiculo();
            o_veiculo.frear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                Veiculo o_veiculo = new Veiculo();
                o_veiculo.QtdeMarchas = 6;
                o_veiculo.alterarMarcha(int.Parse(textBox1.Text));
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Atenção: Informe a marcha que deseja selecionar entre 0 e 6.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Veiculo o_veiculo = new Veiculo();
            o_veiculo.Marca = "Chevrolet";
            o_veiculo.Modelo = "Onix";
            o_veiculo.Cor = "Azul escuro";
            o_veiculo.Ano = 2019;
            o_veiculo.NroPortas = 4;
            o_veiculo.VelocidadeMax = 171;
            o_veiculo.QtdeMarchas = 6;
            o_veiculo.Proprietario = "Iago Ramos";

            o_veiculo.imprimirDados();
        }
    }
}
