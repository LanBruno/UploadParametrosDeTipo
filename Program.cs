namespace ParametrosDeTipo
{
    

    class Program
    {
        static void Main(string[] args)
        {
           var p1 = new Pair<int, string>(1, "Um");
           int i = p1.First;
           string s = p1.Second;

           var p2 = new Pair<string, double>("Teclado", 45.75);
           string produto = p2.First; 
           double valor = p2.Second;

           Console.WriteLine($"Produto: {produto} - Valor: { valor}");
        }
    }

    public class Pair<Tfirst, Tsecond>
    {
        public Tfirst First { get; }
        public Tsecond Second { get; }


        public Pair(Tfirst first, Tsecond second) => (First, Second) = (first, second); /// =>



    }             
}