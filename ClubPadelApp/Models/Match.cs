namespace ClubPadelApp.Models
{
    public class Match
    {
        private int _idMatch;
        private DateTime _date;
        private string _typeMatch;
        private string _score;
        private List<Joueur> _participants;

        public int IdMatch => _idMatch;
        public DateTime Date => _date;
        public string TypeMatch => _typeMatch;
        public string Score => _score;
        public List<Joueur> Participants => _participants;

        public Match(int idMatch, DateTime date, string typeMatch, string score)
        {
            _idMatch = idMatch;
            _date = date;
            _typeMatch = typeMatch;
            _score = score;
            _participants = new List<Joueur>();
        }

        public void Demarrer()
        {
            throw new NotImplementedException();
        }

        public void Terminer()
        {
            throw new NotImplementedException();
        }

        public void EnregistrerScore()
        {
            throw new NotImplementedException();
        }
    }
}