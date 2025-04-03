namespace Sistema_Veiculos
{
    class Carro : Veiculo
    {
        public Carro(string modelo, string marca, int ano, int dias) : base(modelo, marca, ano, dias)
        {
        }

        public override decimal Calculardiaria(decimal diaria, int dias)
        {
            return dias * diaria;
        }
    }
}
