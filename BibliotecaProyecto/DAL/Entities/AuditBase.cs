using System.ComponentModel.DataAnnotations;

namespace BibliotecaProyecto.DAL.Entities
{
    public class AuditBase
    {
        [Key]//PK
        [Required]//Obligatorio
        public virtual Guid Id { get; set; } //PK de todas las tablas

        public virtual DateTime? CreatedDate { get; set; } //para guardar todo registro nuevo con su date

        public virtual DateTime? ModifiedDate { get; set; }//para guardar todo registro que se modifico con su date
    }
}
