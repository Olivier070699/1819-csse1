namespace deel2
{
    public class Persoon : Gebruiker
    {
       public string Voornaam{
           get{
               return this.voornaam
           }
           set{
                this.Voornaam = value;
            }
       }

       public string VolledigeNaam{
            get;
        }
       
        public string GenereerWachtwoord(){
           return "Persoon - wachtwoord";
        }

        public string GenereerWachtwoord(int input){
            return "Test2";
        }

        public string GenereerWachtwoord(string input){
            return "Test1";
        }

        public string ToString(){
            return "waarden van object persoon";
        }
    }
}