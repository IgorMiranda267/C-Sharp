﻿using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {/*Ordem de Implementação de uma Classe.
       Atributos Privados.
       Propriedades Autoimplementadas.
       Construtores.
       Propriedades customizadas.
       Outros Métodos da Classe.
    */
  
        private string _nome;//Como o _tem uma lógica particular, não dá para  usar Auto Properties.p
        public double Preco { get; private set; } //Auto Properties.
        public int Quantidade { get; private set; } //Auto Properties.

        public Produto()
        {
            //Contrutor padrão. 
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 10;
        }

        /*Implementação das Properties(Uma propriedade é um membro que oferece um mecanismo flexível 
          para ler, gravar ou calcular o valor de um campo particular 
          
          O acessador GET retorna o valor do campo particular.
          O acessador SET pode realizar alguma validação de dados antes de atribuir um valor ao campo particular.

        */

        public string Nome
        {
            get { return _nome; } //Imprimi o valor de _nome (private).
            set {
                if (value != null && value.Length > 1) //Testa se o nome não e vazio e se tem mais de 1 caractere.
                {
                    _nome = value;
                }
            }
        }
        
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RmoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
