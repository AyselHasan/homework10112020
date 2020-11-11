using System;

namespace homework10112020
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Ays47", "aysi47");
            Account account2 = new Account("ZZZ", "z123");
            Account account3 = new Account("LLL", "l123");
            account1.setPassword();
            account2.setPassword();
            account3.setPassword();
        }
    }
}
