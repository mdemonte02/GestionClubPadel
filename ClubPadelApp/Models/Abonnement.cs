namespace ClubPadelApp.Models
{
    public class Abonnement
    {
        private int _idAbonnement;
        private string _type;
        private decimal _prix;
        private DateTime _dateDebut;
        private DateTime _dateFin;

        public int IdAbonnement => _idAbonnement;
        public string Type => _type;
        public decimal Prix => _prix;
        public DateTime DateDebut => _dateDebut;
        public DateTime DateFin => _dateFin;

        public Abonnement(int idAbonnement, string type, decimal prix, DateTime dateDebut, DateTime dateFin)
        {
            _idAbonnement = idAbonnement;
            _type = type;
            _prix = prix;
            _dateDebut = dateDebut;
            _dateFin = dateFin;
        }

        public void Activer()
        {
            throw new NotImplementedException();
        }

        public void Expirer()
        {
            throw new NotImplementedException();
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"Abonnement {_type} - Prix : {_prix}");
        }
    }
}