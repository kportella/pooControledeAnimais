namespace pooControledeAnimais
{
    public class Animal
    {

        public static int cachorro = 0;
        public static int gato = 0;
        public static int peixe = 0;
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public Animal(string tipo, string nome)
        {
            this.Nome = nome;
            this.Tipo = testeAnimal(tipo);
        }

        public Animal()
        {
        }

        private string testeAnimal(string tipo)
        {
            if (tipo.ToLower() == "gato")
            {
                gato++;
                return "gato";
            }
            else if (tipo.ToLower() == "cachorro")
            {
                cachorro++;
                return "cachorro";
            }
            else
            {
                peixe++;
                return "peixe";
            }
        }



    }
}
