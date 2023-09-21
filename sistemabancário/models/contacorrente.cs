namespace NuBank
{
    class ContaCorrente
    {

        private string titular { get; set; }
        private int saldo { get; set; }
        public ContaCorrente(string titular, int saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine($"O saldo na conta de {titular} é de R${saldo}");
        }
        public void Depositar()
        {
            Console.WriteLine("Qual o valor do depósito?");
            int maisgrana = int.Parse(Console.ReadLine());
            
            if (maisgrana <= 0)
            {
                Console.WriteLine("Valores negativos não podem ser depositados");
            }
            else
            {
                saldo = saldo + maisgrana;
                Console.WriteLine($"Com seu depósito de {maisgrana}, seu saldo ficou de {saldo}");
            }
            
        }
        public void Sacar()
        {
            Console.WriteLine("Qual o valor do saque?");
            int menosgrana = int.Parse(Console.ReadLine());
            
            if (menosgrana <= 0 || menosgrana > saldo )
            {
                Console.WriteLine("O valor de saque não pode ser negativo e nem ultrapassar o valor disponível na conta.");
            }
            else
            {
                saldo = saldo - menosgrana;
                Console.WriteLine($"Com seu saque de {menosgrana}, seu saldo ficou de {saldo}");
            }

            
        }
    }
}