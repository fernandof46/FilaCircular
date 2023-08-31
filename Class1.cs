using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaCircular
{
    internal class Fila
    {
        //declaração das variáveis de forma global
        string[] valores;//recebe os valores digitados pelo usuário
        int inicio, fim, total;//recebe o início da fila, o fim e o total de elementos que estão na fila.
        //método que irá gerar o processamento da fila, deve receber o mesmo nome da classe e a variável de parâmetro
        public Fila(int Tamanho)
        {
            valores = new string[Tamanho]; //dimensiona quantos itens a fila irá receber
            inicio = 0;
            fim = -1;
            total = 0;
        }
        //método que acrescenta valores à fila, recebe o parâmetro valor
        public void Enfileirar (string Valor) 
        {
            /*se a quantidade total de itens adicionados for menor que os valores referentes ao tamanho
             da fila, então o item será adicionado*/
            if (total < valores.Length) 
            {
                fim = (fim + 1) % valores.Length; /* se não há nenhum elemento na fila, o FIM tamb´me é primeiro
                                                   então fim vai receber o valor e o fim passa a ser o próximo valor*/
                valores[fim] = Valor;
                total++;//incrementa o total em +1
            }
            else
            {
                //caso todos as posições especificadas em VALORES estiverem ocupadas expressa a mensagem
                Console.WriteLine("fila está cheia");
                Console.ReadKey();
            }
        }
        /*criando o método desenfileirar*/
        public void Desenfileirar()
        {
            if (total > 0)//quando existir valores na fila
            {
                valores[inicio] = string.Empty; //cria uma posição vazia no array
                inicio = (inicio + 1) % valores.Length; /*tualiza o valor da variável inicio
                                                         percorrendo o restante do array */
                total--;
            }
            else
            {
                Console.WriteLine("Fila está vazia");
                Console.ReadKey();
            }
        }
    }
}
