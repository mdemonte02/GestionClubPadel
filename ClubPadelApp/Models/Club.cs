namespace ClubPadelApp.Models
{
    public class Club
    {
        private string _nom;
        private string _adresse;
        private string _telephone;
        private string _email;
        private List<Joueur> _joueurs;
        private List<Coach> _coachs;
        private List<Terrain> _terrains;

        public string Nom => _nom;
        public string Adresse => _adresse;
        public string Telephone => _telephone;
        public string Email => _email;
        public List<Joueur> Joueurs => _joueurs;
        public List<Coach> Coachs => _coachs;
        public List<Terrain> Terrains => _terrains;

        public Club(string nom, string adresse, string telephone, string email)
        {
            _nom = nom;
            _adresse = adresse;
            _telephone = telephone;
            _email = email;
            _joueurs = new List<Joueur>();
            _coachs = new List<Coach>();
            _terrains = new List<Terrain>();
        }

        public void AjouterJoueur(Joueur joueur)
        {
            _joueurs.Add(joueur);
        }

        public void AjouterTerrain(Terrain terrain)
        {
            _terrains.Add(terrain);
        }

        public void AfficherInformations()
        {
            Console.WriteLine($"Club : {_nom}");
            Console.WriteLine($"Adresse : {_adresse}");
            Console.WriteLine($"Téléphone : {_telephone}");
            Console.WriteLine($"Email : {_email}");
        }
    }
}