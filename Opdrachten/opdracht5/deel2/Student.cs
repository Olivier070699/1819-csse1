namespace deel2
{
    public class Student
    {
        public string Emailadres{
            get;
            set;
        }

        public Opleiding Opleiding{
            get;
            set;
        }

        public override string Geneerwachtwoord(){
            return "Student - wachtwoord";
        }
    }
}