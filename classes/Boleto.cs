namespace AulaPOO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras = "123456.1231231231.123132123.123123132";
        public string CodigoDeBarras{
            get {return codigoDeBarras;}
        }


        public void Registrar(float valor, DateTime dataEmissao, string codigoDeBarras){

            Console.WriteLine($"O valor da compra fica em R${valor * 0.88f}");
            Console.WriteLine($"Data de emissão = {dataEmissao}");
            Console.WriteLine($"Data de vencimento = {dataEmissao.AddDays(10)}");
            Console.WriteLine($"Código de barras = {codigoDeBarras}");
        }
    }
}