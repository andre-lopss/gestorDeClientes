using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeClientes
{
    internal class Program
    {
        [System.Serializable]
        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;
        }

        static List<Cliente> clientes = new List<Cliente>();
        enum Menu { Listagem = 1, Adicionar, Remover, Sair }
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
                        Listagem();
                        break;
                    case Menu.Adicionar:
                        Adicionar();
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

        static void Adicionar()
        {
            Console.Clear();
            Cliente cliente = new Cliente();
            Console.WriteLine("CADASTRO DE CLIENTES:");
            Console.WriteLine("Nome do Cliente: ");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Email do Cliente: ");
            cliente.email = Console.ReadLine();
            Console.WriteLine("CPF do Cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);

            Console.WriteLine("Cadastro concluido, aperte ENTER para sair.");
            Console.ReadLine();
        }

        static void Listagem()
        {
            if(clientes.Count > 0) //SE tem pelo menos um
            {
                Console.Clear();
                Console.WriteLine("LISTA DE CLIENTES: ");
                int i = 0;
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"Email: {cliente.email}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    Console.WriteLine("====================================");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("A lista de clientes está vazia.");
            }

            Console.WriteLine("Aperte ENTER para sair.");
            Console.ReadLine();
        }
    }
}
