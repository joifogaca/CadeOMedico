using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeOMedico.Models
{
    [MetadataType(typeof(EspecialidadeMetadado))]
    public partial class EspecialidadeMetadado
    {
        [Required(ErrorMessage = "Obrigatorio informar a especialidade")]
        [StringLength(80, ErrorMessage = "O especialidade deve possuir no máximo 80 caracteres")]
        public string Nome { get; set; }
    }
}