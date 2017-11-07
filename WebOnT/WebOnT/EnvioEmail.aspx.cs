using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebOnT
{
    public partial class EnvioEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            enviarEmail();
        }

        public void enviarEmail()
        {
            string email = txtEmail.Text;
            string nombre = txtNombre.Text;
            string apellido_p = txtApellidoP.Text;
            string apellido_m = txtApellidoM.Text;
            string rut = txtRut.Text;
            string fono = txtFono.Text;
            string colegio = txtColegio.Text;
            string curso = txtCurso.Text;

            new Email().enviarCorreo(email, nombre, apellido_p, apellido_m, rut, fono, colegio, curso);
        }
    }
}