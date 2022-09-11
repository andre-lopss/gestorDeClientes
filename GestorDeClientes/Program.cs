using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeClientes
{
    [System.Serializable]
    struct Cliente
    {
        public string nome;
        public string email;
        public string cpf;
    }

    static List<Cliente> clientes = new List<Cliente>();
    enum Menu { Listagem = 1, Adicionar, Remover, Sair}
    internal class Program
    {
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            
            while (!escolheuSair)
            {
                Console.WriteLine("SISTEMA DE CLIENTES - BEM VINDO!");
                Console.WriteLine("1-Listagem\n2-Adicionar\n3-Remover\n4-Sair");
                int intOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intOp;

                switch (opcao)
                {
                    case Menu.Listagem:
                        break;
                    case Menu.Adicionar:
                        break;
                    case Menu.Remover:
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
           
        }
    }
}
