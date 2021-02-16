using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class ContaBancaria
    {
        public string DepositoInicial;
        private int _numeroConta;
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public int NumeroConta
        {
            get { return _numeroConta; }
            set
            {

                if (value != 0)
                {
                    _numeroConta = value;
                }
                else
                {
                    while (NumeroConta == 0)
                    {
                        Console.WriteLine("Número de conta inválido.");
                        Console.Write("Entre o número da conta: ");
                        NumeroConta = int.Parse(Console.ReadLine());
                    }

                }

            }
        }


        public void DepositoInicio()
        {
            if ((DepositoInicial == "s") || (DepositoInicial == "S"))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                 Saldo = double.Parse(Console.ReadLine());
            }
            else if ((DepositoInicial == "n") || (DepositoInicial == "N"))
            {
                 Saldo = 0;
            }
        }

        public void Deposito(double valor)
        {
            
                Saldo += valor; 
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "Conta " + _numeroConta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
