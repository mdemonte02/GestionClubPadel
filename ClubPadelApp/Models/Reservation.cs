namespace ClubPadelApp.Models
{
    public class Reservation
    {
        private int _idReservation;
        private DateTime _date;
        private string _heureDebut;
        private string _heureFin;
        private string _statut;
        private Joueur _joueur;
        private Terrain _terrain;

        public int IdReservation => _idReservation;
        public DateTime Date => _date;
        public string HeureDebut => _heureDebut;
        public string HeureFin => _heureFin;
        public string Statut => _statut;
        public Joueur Joueur => _joueur;
        public Terrain Terrain => _terrain;

        public Reservation(
            int idReservation,
            DateTime date,
            string heureDebut,
            string heureFin,
            string statut,
            Joueur joueur,
            Terrain terrain
        )
        {
            _idReservation = idReservation;
            _date = date;
            _heureDebut = heureDebut;
            _heureFin = heureFin;
            _statut = statut;
            _joueur = joueur;
            _terrain = terrain;
        }

        public void Confirmer()
        {
            _statut = "Confirmée";
        }

        public void Annuler()
        {
            _statut = "Annulée";
        }
    }
}