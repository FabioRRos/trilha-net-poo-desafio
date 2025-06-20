namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        protected Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }



        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}