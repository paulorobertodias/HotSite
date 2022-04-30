using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotsite.Models
{
    ///Entidade EF Core Interesse
    public class Interesse
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(80)]
        public string Email { get; set; }

        [StringLength(320)]
        public string Mensagem { get; set; }
    }
}