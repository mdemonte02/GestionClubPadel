namespace ClubPadelApp.Models
{
    public class Terrain
    {
        private int _numero;
        private string _typeSurface;
        private bool _estCouvre;
        private bool _disponible;

        public int Numero => _numero;
        public string TypeSurface => _typeSurface;
        public bool EstCouvre => _estCouvre;
        public bool Disponible => _disponible;

        public Terrain(int numero, string typeSurface, bool estCouvre, bool disponible)
        {
            _numero = numero;
            _typeSurface = typeSurface;
            _estCouvre = estCouvre;
            _disponible = disponible;
        }

        public void RendreDisponible()
        {
            _disponible = true;
        }

        public void RendreIndisponible()
        {
            _disponible = false;
        }

        public void AfficherEtat()
        {
            Console.WriteLine($"Terrain {_numero} - Disponible : {_disponible}");
        }
    }
}