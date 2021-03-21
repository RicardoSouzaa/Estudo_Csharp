namespace Estudo_Csharp
{

    public class Pessoa
    {
        public Pessoa(string cabelo)
        {
            Olhos = 2;
            Bracos = 2;
            Pernas = 2;
            CorCabelo = cabelo;
        }
        public Pessoa()
        {

        }
        public string Nome { get; set; }
        public int Olhos { get; set; }
        public string CorCabelo { get; set; }
        public int Bracos { get; set; }
        public int Pernas { get; set; }
    }
}
