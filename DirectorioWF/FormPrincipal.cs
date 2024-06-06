namespace DirectorioWF
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Button_gotoDirectory_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderBrowserDialog = new())
            {
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;

                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo directory = new(folderBrowserDialog.SelectedPath);

                    FileInfo[] archivos = directory.GetFiles(".", SearchOption.TopDirectoryOnly);

                    textBoxContenidoArchivo.Text += "Directorio: " + folderBrowserDialog.SelectedPath;

                    float total = 0;
                    foreach (FileInfo file in archivos) 
                    {
                        textBoxContenidoArchivo.Text += Environment.NewLine + file.Name + " -> " + file.Length/1024 + " kb";
                        total += file.Length;
                    }
                    textBoxContenidoArchivo.Text += Environment.NewLine + $"Total del directorio: {total/1024/1024} mb";
                }
            }

        }
    }
}
