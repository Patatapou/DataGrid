using System.Text.RegularExpressions;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string curp = CURP.Text;
            string expresion = "^[A-Z]{4}\\d{6}[HM]{1}[A-Z]{2}[A-Z]{3}[0-9A-Z]{2}$";
            /*
            ^ - Indica el inicio de la cadena.
            [A-Z]{4} - EAMM Cuatro letras mayúsculas (primeros cuatro caracteres de la CURP: iniciales del apellido y nombre).
            \\d{6} - 050518 Seis dígitos numéricos (fecha de nacimiento en formato YYMMDD). \d es equivalente a [0-9].
            [HM]{1} - H Una sola letra (H para Hombre, M para Mujer). {1} indica que debe aparecer exactamente una vez (puede omitirse porque es redundante).
            [A-Z]{2} - DG Dos letras mayúsculas (código del estado de nacimiento, como DF o DG).
            [A-Z]{3} - STG Tres letras mayúsculas (consonantes internas del apellido paterno, materno y nombre).
            [0-9A-Z]{2} - A8 Dos caracteres alfanuméricos (dígito de siglo + dígito verificador). Puede ser un número (0-9) o una letra (A-Z).
            $ - Indica el final de la cadena.
            */
            
            if (Regex.IsMatch(curp,expresion)==true)
            {
                string year = curp[4].ToString() + curp[5].ToString();
                string mes = curp[6].ToString() + curp[7].ToString();
                string dia = curp[8].ToString() + curp[9].ToString();
                DateTime fecha = DateTime.Parse(dia+"/"+mes+"/"+year);

                MessageBox.Show("La fecha de nacimiento es: " + fecha.ToString("dd/MM/yyyy"));
            } 
            else 
            {
                MessageBox.Show("Ingrese una CURP valida");
            }
        }
    }
}
