namespace DataGrid
{
    public partial class Form1 : Form
    {
        string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                try
                {
                    string documento = File.ReadAllText(filePath);

                    string[] fila = documento.Split('\n');
                    string[] col = fila[0].Split(',');

                    
                    dgvDatos.ColumnCount = col.Length;
                    dgvDatos.RowCount = fila.Length;
                    for (int i = 0; i < col.Length; i++)
                    {
                        dgvDatos.Rows[0].Cells[i].Value = col[i];
                    }
                    for (int i = 1; i < (fila.Length) - 1; i++)
                    {
                        col = fila[i].Split(',');
                        for (int j = 0; j < col.Length; j++)
                        {
                            dgvDatos.Rows[i].Cells[j].Value = col[j];
                        }
                    }
                    MessageBox.Show(fila.Length-1+" registros cargados.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }
    }
}
