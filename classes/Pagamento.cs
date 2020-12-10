namespace AulaPOO_Abstracao.classes
{
    public class Pagamento
    {
        public abstract class Pagamento
        {
            private DateTime data;
            public DateTime Data{
                get {return data;}
                set {data = value;}
            }

            protected float valor;

            public float Valor{
                set {valor = value;}
                get {return valor;}
            }

            public string Cancelar(){
                return "";
            }
        }        
    }
}