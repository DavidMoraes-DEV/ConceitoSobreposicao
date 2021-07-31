using System;
using Sobreposicao_E_Palavras_Virtual_Override_Base.Entities;

namespace Sobreposicao_E_Palavras_Virtual_Override_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
/*
* Sobreposição ou Sobrescrita:

- É a implementação de um método de uma superclasse na subclasse
- Para que um método comum (não abstrato) possa ser sobreposto, deve ser incluído nele o prefico "Virtual"
- Ao sobrescrever um método, devemos incluir nele o prefixo "override"

Exemplo: Suponha as seguintes regras para saque:

1) Conta Comum: é cobrada uma taxa no valor de 5.00
2) Conta poupança: não é cobrada taxa.

Como resolver?

Resposta: sobrescrevendo o método withDraw na subclasse SavingsAccount.
 */