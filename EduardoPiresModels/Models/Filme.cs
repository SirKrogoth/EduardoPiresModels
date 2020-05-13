using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduardoPiresModels.Models
{
    public class Filme
    {        
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título deverá ter entre 3 e 60 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório.")]
        [DataType(DataType.DateTime, ErrorMessage = "A data informada está em formato incorreto.")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Genero informado inválido.")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres."), Required(ErrorMessage = "O campo Genero é obrigatório.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Valor deverá ser informado.")]
        [Range(1,1000, ErrorMessage = "Valor de 1 até 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        public int Avaliacao { get; set; }
    }
}
