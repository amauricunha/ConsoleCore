namespace GameTOP.lib
{
     public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        // funções Chuta
        public string Chuta()
        {
            return $"{_Nome} está chutando\n";
        }
        //Corre
        public string Corre()
        {
            return $"{_Nome} está Correndo\n";
        }
        //Passe
        public string Passe()
        {
            return $"{_Nome} está passando\n";
        }
    }
}