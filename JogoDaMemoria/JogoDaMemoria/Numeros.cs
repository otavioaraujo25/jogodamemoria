using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaMemoria
{
    public static class Numeros
    {
        public static int[] vetor = new int[17];

        public static int i = 1;

        public static int SorteioDosNumeros()
        {
            Random r = new Random();
            return r.Next(1, 16); //Sorteio dos numeros de 1 a 16
        }

        public static void criarVetor()
        {
            int numero = 0;
            int contador = 1;
            int verif = 0;
            int x = 0;

            while (contador <= 16) 
            {
                //recebeu numero
                numero = SorteioDosNumeros(); // Sorteio dos numeros
                verif = verificar(numero); 

                if (contador <= 8) 
                {
                    x = vetor[contador - 1];
                    if (x != numero)
                    {
                        if (verif == 0)
                        {
                            vetor[contador] = numero;
                            contador++;
                        }
                    }
                }
                if (contador > 8)
                {
                    x = vetor[contador - 1];
                    if (x != numero)
                    {
                        if (verif == 1)
                        {
                            vetor[contador] = numero;
                            contador++;
                        }
                    }
                }

            }

        }

        public static int DefinirNumeros() //Definir numeros para cada Botão
        {
            int num;
            num = vetor[i];
            i++;
            return num;
        }

        private static int verificar(int numero) //Verificar se existe algum numero igual
        {
            int verificar = 0;
            for (int i = 0; i < 16; i++)
            {
                if (numero == vetor[i])
                {
                    verificar = verificar + 1; // Aumenta um número no indice para checagem
                }

            }

            return verificar;
        }
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static int[] vetor2= new int[17];

        public static int i2 = 1;

        public static int SorteioDosNumeros2()
        {
            Random r2 = new Random();
            return r2.Next(1, 8); //Sorteio dos numeros de 1 a 16
        }

        public static void criarVetor2()
        {
            int numero2 = 0;
            int contador2 = 1;
            int verif2 = 0;
            int x2 = 0;

            while (contador2 <= 8)
            {
                //recebeu numero
                numero2 = SorteioDosNumeros2(); // Sorteio dos numeros
                verif2 = verificar2(numero2);

                if (contador2 <= 8)
                {
                    x2 = vetor2[contador2 - 1];
                    if (x2 != numero2)
                    {
                        if (verif2 == 0)
                        {
                            vetor[contador2] = numero2;
                            contador2++;
                        }
                    }
                }
                if (contador2 > 8)
                {
                    x2 = vetor2[contador2 - 1];
                    if (x2 != numero2)
                    {
                        if (verif2 == 1)
                        {
                            vetor2[contador2] = numero2;
                            contador2++;
                        }
                    }
                }

            }

        }

        public static int DefinirNumeros2() //Definir numeros para cada Botão
        {
            int num2;
            num2 = vetor2[i];
            i2++;
            return num2;
        }

        private static int verificar2(int numero2) //Verificar se existe algum numero igual
        {
            int verificar2 = 0;
            for (int i2 = 0; i2 < 8; i2++)
            {
                if (numero2 == vetor2[i])
                {
                    verificar2 = verificar2 + 1; // Aumenta um número no indice para checagem
                }

            }

            return verificar2;
        }


    }
}

