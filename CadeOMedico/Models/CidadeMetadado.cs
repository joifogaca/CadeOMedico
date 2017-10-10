using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeOMedico.Models
{
     [MetadataType(typeof(CidadeMetadado))]
    public partial class CidadeMetadado
    {
         [Required(ErrorMessage = "Obrigatorio informar o Nome da Cidade")]
         [StringLength(50, ErrorMessage = "O Nome da Cidade deve possuir no máximo 50 caracteres")]
         public string Nome { get; set; }
    }
}