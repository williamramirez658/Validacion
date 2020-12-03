using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjValidacionExp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ValidarCajas validacion = new ValidarCajas();
        private void limpiarCajas()
        {
            nombreIn.Clear();
            codigoIn.Clear();
            correoIn.Clear();
        }

     
       

        private void btnValPas_Click_1(object sender, EventArgs e)
        {
            if (!validacion.Vacio(paswordIn, errorM, "El pasword no puede ser vacio"))
                salida.Text = "Password Digitado";

            if (validacion.valido(paswordIn, errorM, "El pasword no cumple con las caracteristicas de 8 a 15 digitos"))
                salida.Text = "Password Digitado Correctamente";

        }

        private void btnvalidacion_Click(object sender, EventArgs e)
        {
            if (!validacion.Vacio(nombreIn, errorM, "El nombre no puede ser vacio"))
                if (validacion.TipoTexto(nombreIn, errorM, "Debe digitar texto"))
                    if (!validacion.Vacio(codigoIn, errorM, "El codigo  no puede ser vacio"))
                        if (validacion.TipoNumero(codigoIn, errorM, "Debe digitar numeros"))
                            if (!validacion.Vacio(correoIn, errorM, "El correo  no puede ser vacio"))
                                if (validacion.TipoCorreo(correoIn, errorM, "El correo no  cumple con el formato"))
                                {
                                    salida.Text = "todos los valores esta llenos";
                                    limpiarCajas();
                                }
        }
    }
}
