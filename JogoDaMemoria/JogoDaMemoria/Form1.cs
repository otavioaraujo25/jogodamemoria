using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class Form1 : Form
    {
        //int pontox = 10, pontoy = 10; // Localização
        // Matriz
        //int[] vetor = new int[16]; //Vetor

           
        public Form1()
        {
            InitializeComponent();
        }
        Button primeiraescolha, segundaescolha;
        int i, j, cont = 0;
        int NmrDeAcertos;
        int NmrDeErros;
        int NmrDeJogadas;
        private void iniciargame2_Click(object sender, EventArgs e)
        {
           iniciargame2.Enabled = false;
           int[] vetor = new int[16];
           int pontox = 10, pontoy = 10;

            Numeros.criarVetor();

            for ( i = 0; i < 4; i++)
            {
                for ( j = 0; j < 2; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(60, 60);
                    btn.Location = new Point(pontox, pontoy);
                    btn.Text = Numeros.DefinirNumeros2().ToString();
                    this.Controls.Add(btn);
                    pontox += 90;
                    btn.Click += new EventHandler(ClickButton);
                    btn.BackColor = Color.Black;
                }
                pontox = 10;
                pontoy += 90;
            }
        }

        private void iniciargame_Click(object sender, EventArgs e) //gerar os botões 
        {
            iniciargame.Enabled = false; //Usar o botao apenas uma vez
            int[] vetor = new int[16]; //Definindo as posições
            int pontox = 10, pontoy = 10;

            Numeros.criarVetor();

            for ( i = 0; i < 4; i++)
            {
                for ( j = 0; j < 4; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(60, 60);
                    btn.Location = new Point(pontox, pontoy);
                    btn.Text = Numeros.DefinirNumeros().ToString(); //numeros de cada botao dinamico
                    this.Controls.Add(btn);
                    btn.Click += new EventHandler(ClickButton);
                    pontox += 90;
                    btn.BackColor = Color.Black; //Deixado na cor preta para sumir os numeros
                }
                pontox = 10;
                pontoy += 90;
            }
        }

        private void ClickButton(object sender, EventArgs e)
        {
            cont++; //Define quantos botões estão sendo clicados
            if (cont % 2 == 1) //Primeiro botao clicado na cor VERMELHA
            {            
                primeiraescolha = (Button)sender;
                primeiraescolha.BackColor = Color.Red;

            }
             else //Segundo botao clicado na cor AZUL
            {               
                segundaescolha = (Button)sender;
                segundaescolha.BackColor = Color.Blue;
                CompararEscolhas();
            }
        }

        public void CompararEscolhas()
        {
           
            if (primeiraescolha.Text != segundaescolha.Text)
            {
                MessageBox.Show("Errado! Que pena...");
                primeiraescolha.BackColor = Color.Black;
                segundaescolha.BackColor = Color.Black;
                NmrDeErros++;
            }
            else
            {
                MessageBox.Show("Acertou na mosca!");
                primeiraescolha.BackColor = Color.Green;
                segundaescolha.BackColor = Color.Green;
                primeiraescolha.Enabled = false; //Desativa os botões para não poder clicar mais neles
                segundaescolha.Enabled = false;
                NmrDeAcertos++;
            }

            NmrDeJogadas = NmrDeAcertos + NmrDeErros;

            if (NmrDeAcertos >= 8)
            {
                MessageBox.Show("Parabéns! Você ganhou depois de " + NmrDeJogadas + " Tentativas!");
            }

        }
    }
}
