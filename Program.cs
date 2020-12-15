using System;
using Metodos_Construtores_POO.classes;

namespace Metodos_Construtores_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contrutor vazio = permite dar valor a qualquer atributo da classe ou nenhum valor se não quiser 
            Produto produto1 = new Produto();//instanciamento do objeto
            produto1.Code = 51; //valor dado ao atributo código
            produto1.Name = "Fanta Laranja"; //valor dado ao atributo nome
            produto1.Description = "Refrigerante sabor laranja";//valor dado ao atributo descrição
            //impressão dos dados inseridos
            Console.WriteLine($"Código do produto: {produto1.Code} - Nome do Produto: {produto1.Name} - Descrição do produto: {produto1.Description}");

            //Construtor com apenas um argumento = obrigatóriamente deve-se inserir no mínimo um valor para o argumento pedido no método(int code)
            Produto produto2 = new Produto(0001);//instaciamento do objeto e já dado valor para o argumento pedido no método
            Console.WriteLine($"Código do Produto: {produto2.Code}");//impressão do dado inserido 
            // obs: Poderia colocar além do atributo obrigatório , quaisquer outros atributos da classe que não estão no método

            //Construtor com diversos argumentos obrigatórios = obrigatório dar valor para todos argumentos do método
            Produto produto3 = new Produto(0001,"Café Pilão","Café Tradicional 500g",5000);//instanciamento do objeto e já dado o valor para todos argumentos do método
            //impressão dos dados inseridos
            Console.WriteLine($"Código do produto: {produto3.Code} - Nome do produto: {produto3.Name} - Descrição do produto: {produto3.Description} - Estoque do produto: {produto3.Stock}");


        }   

    }
}
