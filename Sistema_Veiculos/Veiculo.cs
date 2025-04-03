namespace Sistema_Veiculos
{
    class Veiculo : Iveiculos
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        
        public int Dias { get; set; }
       

         public Veiculo (string modelo, string marca, int ano, int dias)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Dias = dias;
        }

        public virtual decimal Calculardiaria(decimal diaria,int dias)
        {
           return  diaria * dias;
        }
        
            
        
    }
}
