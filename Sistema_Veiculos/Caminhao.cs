namespace Sistema_Veiculos
{
    class Caminhao : Veiculo
    {
        public Caminhao(string modelo, string marca, int ano, int dias) :base(modelo, marca, ano, dias)
        {
        }

        public override decimal Calculardiaria(decimal diaria, int dias)
        {
            return (dias * diaria) * 1.2m;
        }
    }
}
