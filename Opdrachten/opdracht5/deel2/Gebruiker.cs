namespace deel2
{
    public class Gebruiker{
        protected string wachtwoord;

        public string Gebruikersnaam{
            get;
            set;
        }

        public virtual string GenereerWachtwoord(){
            return "Persoon - wachtwoord";
        }

        public void GenereerGebruikersnaam(){
            this.Gebruikersnaam = "test";
        }

        public Gebruiker(){
            this.wachtwoord = GenereerWachtwoord();
    }

    }
}