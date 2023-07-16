using System.ComponentModel.DataAnnotations; 

namespace CRUDSERVER.Models
{
    public class ContactoModels
    {
        public int IdContacto { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo telefono es requerido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo correo es requerido")]
        public string Correo { get; set; }
    }
}
