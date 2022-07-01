using System.ComponentModel.DataAnnotations;

namespace testeMVC.Models
{
    public class pessoa
    {
        [Key]
        public int Codigo { get; set; } 
        public string nome { get; set; }
        public string email { get; set; }
    }
}
