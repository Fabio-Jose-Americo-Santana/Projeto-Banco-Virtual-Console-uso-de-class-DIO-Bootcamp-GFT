using System;
using Projeto_Banco__uso_de_class__DIO_Bootcamp_GFT.Src.Entities;


namespace ProjetoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcoes = 0;

            Console.WriteLine("Digite seu Nome");
            string name = Console.ReadLine();

            Console.WriteLine("Digite seu Sobrenome");
            string lastName = Console.ReadLine();

            Console.WriteLine("Digite seu Cpf");
            long document = Convert.ToInt64(Console.ReadLine());

            if (document.ToString().Length == 11)
            {
                Customer customer = new Customer(name, lastName, document);

                Console.WriteLine("Parabens por ser nosso Novo Cliente " + customer.Name + " "
                    + customer.LastName + " " + customer.InitialsName);

                Console.WriteLine("Escolha o Tipo da sua Conta:");

                Console.WriteLine("(1) -  Conta Corrente");

                Console.WriteLine("(2) -  Conta Poupanca ");

                int optionAccount = Convert.ToInt32(Console.ReadLine());

                if (optionAccount == 1)
                {
                    CreateCurrentAccount(customer);
                }
                else if (optionAccount == 2)
                {
                    CreateEarnAccount(customer);
                }
                else
                {
                    Console.WriteLine("Opção informada inválida");
                }
            }
            else
            {
                Console.WriteLine("Cpf Inválido");
                Console.WriteLine("Cpf deve conter 11 Números");
            }

            Console.ReadKey();
        }

        private static void CreateCurrentAccount(Customer customer)
        {
            CurrentAccount contaCorrente = new CurrentAccount(customer);

            Console.WriteLine("Sua Conta Corrente Foi Criada Com Sucesso " + contaCorrente.AccountNumber);

            bool continueExecution = true;

            while (continueExecution)
            {
                ShowMenu();

                int operationOption = Convert.ToInt32(Console.ReadLine());

                switch (operationOption)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o Valor do Deposito");

                            decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

                            if (contaCorrente.Deposit(valorDeposito))
                                Console.WriteLine("Depósito realizado com sucesso.");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Informe o Valor do Saque");

                            decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine(contaCorrente.GetMoney(valorSaque));
                            break;
                        }

                    case 3:
                        {
                            var balance = contaCorrente.GetBalance();

                            Console.WriteLine("Saldo atual: " + balance);
                            break;
                        }

                    default:
                        Console.WriteLine("Operação finalizada com sucesso!");

                        continueExecution = false;
                        break;
                }
            }
        }

        private static void CreateEarnAccount(Customer customer)
        {
            EarnAccount earnAccount = new EarnAccount(customer);

            Console.WriteLine("Sua Conta Poupança Foi Criada Com Sucesso " + earnAccount.AccountNumber);

            bool continueExecution = true;

            while (continueExecution)
            {
                ShowMenu();

                int operationOption = Convert.ToInt32(Console.ReadLine());

                switch (operationOption)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o Valor do Deposito");

                            decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

                            if (earnAccount.Deposit(valorDeposito))
                                Console.WriteLine("Depósito realizado com sucesso.");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Informe o Valor do Saque");

                            decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine(earnAccount.GetMoney(valorSaque));
                            break;
                        }

                    case 3:
                        {
                            var balance = earnAccount.GetBalance();

                            Console.WriteLine("Saldo atual: " + balance);
                            break;
                        }

                    default:
                        Console.WriteLine("Operação finalizada com sucesso!");

                        continueExecution = false;
                        break;
                }
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Escolha a Operação Desejada:");

            Console.WriteLine("(1) -  Depositar");
            Console.WriteLine("(2) -  Sacar");
            Console.WriteLine("(3) -  Ver Saldo");
            Console.WriteLine("(4) -  Sair");
        }
    }
}

