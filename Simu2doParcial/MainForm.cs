namespace Simu2doParcial
{
    public partial class MainForm : Form
    {
        private string[]? _palabras;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadFile()
        {
            using var dialog = new OpenFileDialog();

            dialog.InitialDirectory = Environment.CurrentDirectory;
            dialog.Filter = @"TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if(dialog.ShowDialog() != DialogResult.OK) return;

            _palabras = File.ReadAllLines(dialog.SafeFileName);
        }

        private void LoadButtons()
        {
            List<int> numbers = [];

            for (var i = 0; i < 20; i++)
            {
                numbers.Add(i);
            }

            Random random = new();

            while (numbers.Count > 0)
            {
                var index = random.Next(0, numbers.Count);



            }
        }
    }
}
