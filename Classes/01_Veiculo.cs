using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

public class Veiculo
{
    //
    //Atributos 
    //

    public string marca;
    public string modelo;
    public string cor;
    public int ano;
    public int nroPortas;
    public long chassi;
    public string proprietario;
    public int velocidadeMax;
    public static int velocidadeAtual;
    public int qtdeMarchas;
    public static int marchaAtual;

    //
    //Propriedades 
    //

    public string Marca
    {
        get{ return marca; }
        set{ marca = value; }
    }

    public string Modelo
    {
        get{ return modelo; }
        set{ modelo = value; }
    }

    public string Cor
    {
        get { return cor; }
        set { cor = value; }
    }

    public int Ano
    {
        get { return ano; }
        set { ano = value; }
    }

    public int NroPortas
    {
        get { return nroPortas; }
        set { nroPortas = value; }
    }

    public long Chassi
    {
        get { return chassi; }
        set { chassi = value; }
    }

    public string Proprietario
    {
        get { return proprietario; }
        set { proprietario = value; }
    }

    public int VelocidadeMax
    {
        get { return velocidadeMax; }
        set { velocidadeMax = value; }
    }

    public int VelocidadeAtual
    {
        get { return velocidadeAtual; }
        set { velocidadeAtual = value; }
    }

    public int QtdeMarchas
    {
        get { return qtdeMarchas; }
        set { qtdeMarchas = value; }
    }

    public int MarchaAtual
    {
        get { return marchaAtual; }
        set { marchaAtual = value; }
    }

    public Veiculo()
    {   //
        //Criando valor para o chassi
        //

        Random o_valor = new Random();
        long valorAleatorio;
        valorAleatorio = o_valor.Next(10000000, 99999999);

        chassi = valorAleatorio;
        
    }

    public void acelerar()
    {

        if (velocidadeAtual + 10 <= velocidadeMax)
        {
            velocidadeAtual += 10;
            Console.WriteLine();
            Console.WriteLine("Você acelerou o carro!");
            Console.WriteLine("Velocidade aumentada em 10 km/h.");
            Console.WriteLine("Velocidade Atual: " + velocidadeAtual + " km/h");
        }
        else
        {
            
            Console.WriteLine();
            Console.WriteLine("Velocidade máxima atingida!" + " ( " + velocidadeMax + " km/h" + " ) ");
        }
    }

    public void frear()
    {
        if (velocidadeAtual > 0)
        {
            velocidadeAtual = 0;
            Console.WriteLine();
            Console.WriteLine("Você freou o carro!");
            Console.WriteLine("Velocidade Atual: " + velocidadeAtual + " km/h");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("O carro está parado!");
            Console.WriteLine("Velocidade já é 0 km/h.");
        }
    }

    public int alterarMarcha(int marcha)
    {
        
        if (marcha < 0 || marcha > qtdeMarchas)
        {
            Console.WriteLine();
            Console.WriteLine("Marcha inválida! Selecione uma marcha entre 0 e " + qtdeMarchas + ".");
            return 0;
        }
        

        if(marcha == 0 && velocidadeAtual != 0)
        {
            Console.WriteLine();
            Console.WriteLine("Atenção: Reduza a velocidade para 0 km/h para engatar a marcha ré.");
            return 0;
        }

        marchaAtual = marcha;
        Console.WriteLine();
        Console.WriteLine("Marcha trocada para: " + marchaAtual);
        return 1;
    }

    public void imprimirDados()
    {
        Console.WriteLine();
        Console.WriteLine("----------------");
        Console.WriteLine(" Dados do Carro");
        Console.WriteLine("----------------");
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Cor: " + cor);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Número de Portas: " + nroPortas);
        Console.WriteLine("Chassi: " + chassi);
        Console.WriteLine("Proprietário: " + proprietario);
        Console.WriteLine();
        Console.WriteLine("Quantidade de Marchas: " + qtdeMarchas);
        Console.WriteLine("Marcha Atual: " + marchaAtual);
        Console.WriteLine();
        Console.WriteLine("Velocidade Máxima: " + velocidadeMax + " km/h");
        Console.WriteLine("Velocidade Atual: " + velocidadeAtual + " km/h");
    }
}

