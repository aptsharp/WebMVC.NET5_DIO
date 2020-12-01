using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.NET5_DIO.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="Campo obrigatorio")]
        public string Descricao { get; set; }
    }
}
