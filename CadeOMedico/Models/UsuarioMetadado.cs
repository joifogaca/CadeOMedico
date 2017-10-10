using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeOMedico.Models
{
    [MetadataType(typeof(UsuarioMetadado))]
    public partial class UsuarioMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        [StringLength(80, ErrorMessage = "O Nome deve possuir no máximo 80 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Login")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "O Login deve possuir no minimo 4 caracteres e no  máximo 10.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Senha")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "A Senha deve possuir no minimo 4 caracteres e no  máximo 10.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o E-mail")]
        [StringLength(100, ErrorMessage = "O E-mail deve possuir no máximo 100 caracteres")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage="Informe um email válido")]
        public string Email { get; set; }
    }
}