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

                string sexo = curp[10].ToString();
                string estado = curp[11].ToString() + curp[12].ToString();
                DateTime fecha = DateTime.Parse(dia+"/"+mes+"/"+year);

                MessageBox.Show("La fecha de nacimiento es: " + fecha.ToString("dd/MM/yyyy") + "\nEl sexo es: " + Sexo(sexo) + "\nEl estado es: " + Estado(estado));
            } 
            else 
            {
                MessageBox.Show("Ingrese una CURP valida");
            }
        }

        public string Sexo(string sexo)
        {
            if (sexo == "H")
            {
                return "Masculino";
            }
            else
            {
                return "Femenino";
            }
        }
        public string Estado(string estado)
        {
            switch (estado)
            {
                case "AG": return "Aguascalientes"; break;
                case "BC": return "Baja California"; break;
                case "BS": return "Baja California Sur"; break;
                case "CC": return "Campeche"; break;
                case "CS": return "Chiapas"; break;
                case "CH": return "Chihuahua"; break;
                case "CM": return "Coahuila"; break;
                case "DG": return "Durango"; break;
                case "GT": return "Guanajuato"; break;
                case "GR": return "Guerrero"; break;
                case "HG": return "Hidalgo"; break;
                case "JC": return "Jalisco"; break;
                case "MC": return "México"; break;
                case "MN": return "Michoacán"; break;
                case "MS": return "Morelos"; break;
                case "NT": return "Nayarit"; break;
                case "NL": return "Nuevo León"; break;
                case "OC": return "Oaxaca"; break;
                case "PL": return "Puebla"; break;
                case "QT": return "Querétaro"; break;
                case "QR": return "Quintana Roo"; break;
                case "SP": return "San Luis Potosí"; break;
                case "SL": return "Sinaloa"; break;
                case "SR": return "Sonora"; break;
                case "TC": return "Tabasco"; break;
                case "TS": return "Tamaulipas"; break;
                case "TL": return "Tlaxcala"; break;
                case "VZ": return "Veracruz"; break;
                case "YN": return "Yucatán"; break;
                case "ZS": return "Zacatecas"; break;
                default: return "Abreviatura no reconocida"; break;
            }
        }
    }
}
