namespace ClubPadelApp.Models
{
    public abstract class Personne
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private string _telephone;

        public int Id => _id;
        public string Nom => _nom;
        public string Prenom => _prenom;
        public string Telephone => _telephone;

        public Personne(int id, string nom, string prenom, string telephone)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _telephone = telephone;
        }

        public abstract void AfficherRole();
    }
}