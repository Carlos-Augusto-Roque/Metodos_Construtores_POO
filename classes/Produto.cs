using System;

namespace Metodos_Construtores_POO.classes
{
    public class Produto
    {
        //atributos já com metodos acessores (get;set;)
        public int Code{get;set;}
        public string Name{get;set;}
        public string Description{get;set;}
        public int Stock{get;set;}

        //metodo construtor vazio (permite inserir quais desejar ou nenhum tambem)
        public Produto (){
        }
        //metodo construtor com um atributo (obrigatoriamente deve-se inserir o argumento pedido e outros se assim quiser)
        public Produto(int cod){
            Code = cod;//Valor recebido no Code transferido para cod
        }
        //metodo construtor com todos atributos
        public Produto(int code,string name,string description,int stock){
            Code = code;
            Name = name;
            Description = description;
            Stock = stock;
        }
    }
}