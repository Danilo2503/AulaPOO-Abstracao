using System;
using AulaPOO_Abstracao;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o tipo de pagamento:");
            Console.WriteLine("1 - Boleto");
            Console.WriteLine("2 - Cartão");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    // Boleto
                    Boleto boleto = new Boleto();
                    boleto.Valor = ValorDaCompra;
                    boleto.Registrar(boleto.Valor, boleto.Data, boleto.CodigoDeBarras);

                    Console.WriteLine($"O valor da compra fica em {boleto.Valor} e a data {boleto.Data}");
                    break;
                case 2:
                    // Cartão
                    Console.WriteLine("Selecione o tipo de pagamento:");
                    Console.WriteLine("1 - Crédito");
                    Console.WriteLine("2 - Débito");
                    int tipoCartao = int.Parse(Console.ReadLine());
                        switch(tipoCartao)
                        {
                            case 1:
                                //Crédito
                                Credito credito = new Credito();
                                credito.numero = "12334.1231231.213132";
                                credito.bandeira = "MasterCard";
                                credito.cvv = "123";
                                credito.titular = "Danilo de Freitas Tomaz Rocha";
                                credito.Pagar(valorDaCompra);
                                break;
                            case 2:
                                //Débito

                                break;
                            default:
                                break;
                        }
                    break;
                default:
                    break;        
            }
        }
    }
}
