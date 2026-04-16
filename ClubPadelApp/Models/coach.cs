namespace ClubPadelApp.Models
{
    public class Coach : Personne
    {
        private string _specialite;
        private string _disponibilite;
        private decimal _salaireHoraire;

        public string Specialite => _specialite;
        public string Disponibilite => _disponibilite;
        public decimal SalaireHoraire => _salaireHoraire;

        public Coach(
            int id,
            string nom,
            string prenom,
            string telephone,
            string specialite,
            string disponibilite,
            decimal salaireHoraire
        ) : base(id, nom, prenom, telephone)
        {
            _specialite = specialite;
            _disponibilite = disponibilite;
            _salaireHoraire = salaireHoraire;
        }

        public void DonnerCours()
        {
            throw new NotImplementedException();
        }

        public override void AfficherRole()
        {
            Console.WriteLine("Je suis un coach.");
        }
    }
}