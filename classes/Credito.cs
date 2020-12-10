namespace AulaPOO_Abstracao.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;

        public void Pagar(float valor){

            if(valor <= this.limite){
                
                int parcelas;
                do{
                    Console.WriteLine("Selecione o número de parcelas entre 1 e 12:");
                    parcelas = int.Parse(Console.ReadLine());
                }while(parcelas > 12);

                float juros;
                if(parcelas <= 6){
                    juros = 0.05f;
                }else{
                    juros = 0.08f;
                }

                float total = valor + (valor * juros);
                this.Valor = total;

                ExibirNota(this.titular, total);

            }else{
                Console.WriteLine("Sem limites!");
            }    
            
        }

        public void ExibirNota(string titular, float total){
            Console.WriteLine($"Titular {titular} - Valor da compra = {total}");
        }
    }
}