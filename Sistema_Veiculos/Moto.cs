namespace Sistema_Veiculos
{
    class Moto : Veiculo
    {
        public Moto(string modelo, string marca, int ano, int dias) : base(modelo, marca, ano, dias)
        {
        }

        public override decimal Calculardiaria(decimal diaria, int dias)
        {
            return (diaria * dias) * 0.9m;
        }
    }
}
