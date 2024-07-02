using static System.Text.RegularExpressions.Regex;

namespace _2doParcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_CargarTexto_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();

            dialog.Filter = @"Archivos de texto|*.txt|Todos los archivos|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() != DialogResult.OK) return;

            textBox_Texto.Text = File.ReadAllText(dialog.FileName);

            Estadisticas();
        }

        private void Estadisticas()
        {
            var words = Split(textBox_Texto.Text, @"\W+");
            label_DatosdelTexto.Text = @$"[ Words: {words.Length}, Characters: {textBox_Texto.Text.Length} ]";

            var wordFrequency = words
                .Where(word => !string.IsNullOrWhiteSpace(word))
                .GroupBy(word => word.ToLower())
                .Select(group => new
                {
                    Word = group.Key,
                    Count = group.Count(),
                    group.Key.Length
                })
                .OrderByDescending(word => word.Count)
                .ThenBy(word => word.Word)
                .Take(10)
                .ToList();


            // Configurar el DataGridView
            dataGridView_Estadisticas.DataSource = wordFrequency;
        }
    }
}