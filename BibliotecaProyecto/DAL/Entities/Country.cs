using System.ComponentModel.DataAnnotations;

namespace BibliotecaProyecto.DAL.Entities
{
    public class Country:AuditBase
    {
        [Display(Name="Pais")]//Etiqueta visual para que se vea PAIS en vez de Name
        [MaxLength(50,ErrorMessage="El campo {0} debe tener , maximo {1} caracteres.")]//Longitud maxima (en este caso 50 caracteres)
        [Required(ErrorMessage ="El campo {0} es obligatorio")]// campo obligatorio
        public string Name { get; set; }


    }
}
