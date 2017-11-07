using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebOnT.Models
{
    public class Cuenta
    {
        public String cuenta_id { get; set; }
        public String rut { get; set; }
        public String nombre { get; set; }
        public String apellido_p { get; set; }
        public String apellido_m { get; set; }
        public String telefono { get; set; }
        public String celular { get; set; }
        public String password { get; set; }
        public String sexo { get; set; }
        public int rol_id { get; set; }
    }
}