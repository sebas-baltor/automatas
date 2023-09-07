using System.Collections;
using System.Runtime.Serialization;

namespace automatas
{
    public partial class Home : Form
    {
        public char[] alphabet;
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
                    //alphabet = content[1].Split(limits, StringSplitOptions.RemoveEmptyEntries);
                    alphabet = content[1].ToCharArray().Where(c => c != ',' && c != ' ').ToArray();
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
            if (SelectedFileName.Text == "Ningun archivo seleccionado")
            {
                MessageBox.Show("primero selecciona un archivo", "Aviso");
                return;
            }
            if (text == "")
            {
                MessageBox.Show("tu cadena no puede esta vacia", "Aviso");
                return;
            }
            try
            {
                bool isOk = ValidateString(initialState, text[0], 0, text, lastState);

                if (isOk)
                {
                    MessageBox.Show("cadena correcta", "Aviso");
                }
                else
                {
                    MessageBox.Show("cadena incorrecta", "Aviso");
                }
            }
            catch (Exception err){
                    MessageBox.Show($"{err.Message}", "Aviso");
            }

        }

        public bool ValidateString(string state, char letter, int textIndex, string text, string lastState)
        {

            int index = Array.IndexOf(alphabet, letter);
            if (index == -1) {
                throw new Exception($"en tu alfabeto no has definido {letter} por lo tanto la cadena es incorrecta");
            }
            //char letter = text[i];
            string[] transition = (string[])transitionsTable[state];
            if (transition != null)
            {
                state = transition[index];
            }
            if (transition == null && state == lastState && textIndex == text.Length)
            {
                return true;
            }
            else
            {
                if (textIndex + 1 < text.Length)
                {
                    textIndex++;
                    ValidateString(state, text[textIndex], textIndex, text, lastState);
                }
                if (state == lastState)
                {
                    return true;
                }
                return false;
            }
        }
    }
}