using System;

namespace AT {
    class Conta : IOperacoes{
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int id, string nome, double saldoInicial) {
            Id = id;
            Nome = nome;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor) {
            if (valor > 0) {
                Saldo += valor;
            } else {
                Console.WriteLine("O valor de depósito deve ser um número real maior que zero.");
            }
        }

        public void Sacar(double valor) {
            if (valor > 0) {
                Saldo -= valor;
            }
            else {
                Console.WriteLine("O valor de saque deve ser um número real maior que zero.");
            }
        }

        public override string ToString() {
            return $"Conta ID: {Id}, Nome: {Nome}, Saldo: {Saldo}";
        }

    }
}