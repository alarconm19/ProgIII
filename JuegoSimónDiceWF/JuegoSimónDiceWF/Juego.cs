namespace JuegoSimónDiceWF
{
    public partial class Juego : Form
    {
        public Juego()
        {
            InitializeComponent();
        }

        private readonly List<int> _juego = [];
        private readonly List<int> _jugador = [];
        private readonly Random _random = new();
        private bool _turnoDelUsuario;


        private void Button_Rojo_Click(object sender, EventArgs e)
        {
            ButtonSeleccionado(0);
        }

        private void Button_Verde_Click(object sender, EventArgs e)
        {
            ButtonSeleccionado(1);
        }

        private void Button_Azul_Click(object sender, EventArgs e)
        {
            ButtonSeleccionado(2);
        }

        private void Button_Amarillo_Click(object sender, EventArgs e)
        {
            ButtonSeleccionado(3);
        }


        private void ButtonSeleccionado(int color)
        {
            if (!_turnoDelUsuario) return;

            _jugador.Add(color);
            if (!CompararSecuenciaJugador())
            {
                MessageBox.Show(@"Has fallado. Prueba de nuevo.");
                ReiniciarJuego();
                return;
            }

            if (_jugador.Count != _juego.Count) return;

            MessageBox.Show(@"Bien. Siguiente nivel.");
            _turnoDelUsuario = false;
            _jugador.Clear();
            GenerarSecuencia();
        }

        private bool CompararSecuenciaJugador() => !_jugador.Where((t, i) => t != _juego[i]).Any();

        private void GenerarSecuencia()
        {
            _juego.Add(_random.Next(4)); // Genera un número aleatorio entre 0 y 3
            MostrarSecuencia();
        }

        private async void MostrarSecuencia()
        {
            foreach (var color in _juego)
            {
                RemarcarColores(color);
                await Task.Delay(500);
                ReiniciarColores();
                await Task.Delay(250);
            }
            _turnoDelUsuario = true;
        }

        private void RemarcarColores(int color)
        {
            switch (color)
            {
                case 0: button_Rojo.BackColor = Color.DarkRed; break;
                case 1: button_Verde.BackColor = Color.DarkGreen; break;
                case 2: button_Azul.BackColor = Color.DarkBlue; break;
                case 3: button_Amarillo.BackColor = Color.DarkGoldenrod; break;
            }
        }

        private void ReiniciarColores()
        {
            button_Rojo.BackColor = Color.Red;
            button_Verde.BackColor = Color.Green;
            button_Azul.BackColor = Color.Blue;
            button_Amarillo.BackColor = Color.Yellow;
        }

        private void ReiniciarJuego()
        {
            _juego.Clear();
            _jugador.Clear();
            _turnoDelUsuario = false;
        }

        private void Button_Comenzar_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
            GenerarSecuencia();
        }
    }
}
