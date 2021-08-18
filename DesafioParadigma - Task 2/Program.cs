using System;

namespace DesafioParadigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cenario1 = new[] { 3, 2, 1, 6, 0, 5 };
            int[] cenario2 = new[] { 7, 5, 13, 9, 1, 6, 4 };
            Console.WriteLine("--Cenario 1--");
            ConstruirArvore(cenario1);
            Console.WriteLine("--Cenario 2--");
            ConstruirArvore(cenario2);

        }

        public static void ConstruirArvore(int[] vetorEntrada)
        {
            string galhosEsquerda = string.Empty;
            string galhosDireita = string.Empty;

            int[] entradaDecrescente = BubbleSort(vetorEntrada);

            int raiz = entradaDecrescente[0];

            int indiceRaiz = RetornarIndice(vetorEntrada, raiz);

            for (int i = 1; i < entradaDecrescente.Length; i++)
            {
                int indiceConsultado = RetornarIndice(vetorEntrada, entradaDecrescente[i]);

                if (indiceRaiz < indiceConsultado)
                {
                    galhosDireita += entradaDecrescente[i] + " ";
                }
                else
                {
                    galhosEsquerda += entradaDecrescente[i] + " ";
                }
            }

            Console.WriteLine($"Array de Entrada: [{String.Join(",", vetorEntrada)}]");
            Console.WriteLine($"Raiz: {raiz}");
            Console.WriteLine($"Galhos da Esquerda: {galhosEsquerda}");
            Console.WriteLine($"Galhos da Direita: {galhosDireita}");
        }

        //Foi utilizado o algoritmo de BubbleSort para organizar a lista de forma decrescente
        public static int[] BubbleSort(int[] vetor)
        {
            int[] vetorOrganizado = CopiarVetor(vetor);
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;

                    if (vetorOrganizado[j] < vetorOrganizado[j + 1])
                    {
                        int aux = vetorOrganizado[j];
                        vetorOrganizado[j] = vetorOrganizado[j + 1];
                        vetorOrganizado[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vetorOrganizado;
        }

        //Retorna o indice do item localizado no array
        public static int RetornarIndice(int[] vetor, int number)
        {
            int indice = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == number)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        //Função criada para clonar o vetor, evitando apontar para a mesma referencia de memória e modificar o array de entrada, já que o array é um tipo primário
        public static int[] CopiarVetor(int[] vetor)
        {
            int[] novoArray = new int[vetor.Length];

            for (int i = 0; i < vetor.Length; i++)
            {
                novoArray[i] = vetor[i];
            }

            return novoArray;
        }

    }

}
