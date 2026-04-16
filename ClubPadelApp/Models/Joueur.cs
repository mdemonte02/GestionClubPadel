namespace ClubPadelApp.Models
{
    public class Joueur : Personne
    {
        private string _niveau;
        private string _classement;
        private DateTime _dateInscription;

        public string Niveau => _niveau;
        public string Classement => _classement;
        public DateTime DateInscription => _dateInscription;

        public Joueur(
            int id,
            string nom,
            string prenom,
            string telephone,
            string niveau,
            string classement,
            DateTime dateInscription
        ) : base(id, nom, prenom, telephone)
        {
            _niveau = niveau;
            _classement = classement;
            _dateInscription = dateInscription;
        }

        public void ReserverTerrain()
        {
            throw new NotImplementedException();
        }

        public void ParticiperMatch()
        {
            throw new NotImplementedException();
        }

        public override void AfficherRole()
        {
            Console.WriteLine("Je suis un joueur.");
        }
    }
}