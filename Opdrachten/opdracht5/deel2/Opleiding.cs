namespace deel2
{
    public class Opleiding : IInformatie //duppel punt staat voor overerving
    {

        private string afkortingCampus;

        protected int campusNummer;

        public string Campus{
            get;
            set;
        }

        public string Opledingsnaam{
            get;
            set;
        }

        string GetWifiCode(){
            return "code";
        }

        public Opleiding(){
            this.afkortingCampus = this.Campus.Substring(0, 3);
        }

        public string ToString()
        {
            return string.Format("Campus {0} - campusnummer {1}", this.Campus, this.campusNummer);
        }
    }
}