using System.Collections;
using System.Runtime.Serialization;

namespace automatas
{
    public partial class Home : Form
    {
        public string[] alphabet;
        public string initialState, lastState;
        public Hashtable transitionsTable = new Hashtable();
        //public string[,] transitionsTable;
        public Home()
        {
            InitializeComponent();
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();


            fileDialog.Title = "Selecciona un archivo";
            fileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string filePath = fileDialog.FileName;

                try
                {
                    // Lee el contenido del archivo y muestra en el TextBox
                    List<string> content = File.ReadAllLines(filePath).ToList();
                    char[] limits = { ' ', ',' };
                    string[] domain = content[0].Split(limits, StringSplitOptions.RemoveEmptyEntries);
                    alphabet = content[1].Split(limits, StringSplitOptions.RemoveEmptyEntries);
                    initialState = content[2];
                    lastState = content[3];
                    int i = 0;
                    foreach (string row in content.Skip(4))
                    {
                        if (row != "")
                        {
                            transitionsTable.Add(domain[i], row.Split(" ", StringSplitOptions.RemoveEmptyEntries));
                            i++;
                        }
                    }
                    SelectedFileName.Text = Path.GetFileName(fileDialog.FileName);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error al leer el archivo probablemente no tiene el formato correcto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            string text = input.Text;
            if (text == "") {
                MessageBox.Show("tu cadena no puede esta vacia", "Aviso");
                return;
            }
            
        }
    }
}