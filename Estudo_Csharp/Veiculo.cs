namespace Estudo_Csharp
{
    class Veiculo //classe base
    {
        private int rodas; // para inicializar var rodas utiliza-se um construtor
        public int velMax;
        private bool ligado; //privado so pode ser acessado dentro da propria classe -- para acessar de fora tem que chamar os métodos ligar e desligar.

        public Veiculo(int rodas) // construtor para receber o nuero de rodas que o usuário definir no Program.
        {
            this.rodas = rodas;
        }
        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }

        public string getLigado()
        {
            return (ligado ? "Sim" : "Não"); // operador ternário para substituir o if com duas condiçoes
        }

        public int getRodas()
        {
            return rodas;
        }

        public void setRodas(int rodas)
        {
            if (rodas < 0)
            {
                this.rodas = 0;
            }
            else if (rodas > 40)
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }

    class Carro : Veiculo // classe carro derivada da classe base véiculo (vai herdar)
    {
        public string nome;
        public string cor;

        public Carro(string nome, string cor):base(4) // o Construtor base precisa saber o numero de rodas, esse deve ser definido aqui nesse construtor
        {
            Desligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class CarroCombate : Carro // essa classe herda da classe carro.. carro é base dela e todas são derivadas de Veículos
    {
        public int municao;

        public CarroCombate():base("Carro de Combte", "Verde")
        {
            municao = 100;
            setRodas(6);
        }
    }
}
