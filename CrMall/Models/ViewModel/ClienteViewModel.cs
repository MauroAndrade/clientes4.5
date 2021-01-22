using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrMall.Models.ViewModel
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; } // id (Primary key)

        [Required(ErrorMessage ="Informe o nome.")]
        [MaxLength(150, ErrorMessage ="O nome deve ter no máximo 150 caracteres.")]
        public string Nome { get; set; } // nome (length: 150)

        [DataType(DataType.Date, ErrorMessage ="Data em formato invalido.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Informe a data de nacimento.")]
        public System.DateTime? Nascimento { get; set; } // nascimento

        [Required(ErrorMessage = "Informe o sexo.")]
        public string Sexo { get; set; } // sexo (length: 10)

        [MaxLength(9, ErrorMessage = "O cep deve ter no máximo 9 caracteres.")]
        public string Cep { get; set; } // cep (length: 9)

        [MaxLength(150, ErrorMessage = "O endereço deve ter no máximo 150 caracteres.")]
        public string Endereco { get; set; } // endereco (length: 150)

        [MaxLength(10, ErrorMessage = "O número deve ter no máximo 10 caracteres.")]
        public string Numero { get; set; } // numero (length: 10)

        [MaxLength(100, ErrorMessage = "O complemento deve ter no máximo 100 caracteres.")]
        public string Complemento { get; set; } // complemento (length: 100)

        [MaxLength(150, ErrorMessage = "O bairro deve ter no máximo 150 caracteres.")]
        public string Bairro { get; set; } // bairro (length: 150)

        [MaxLength(150, ErrorMessage = "O estado deve ter no máximo 150 caracteres.")]
        public string Estado { get; set; } // estado (length: 150)

        [MaxLength(150, ErrorMessage = "A cidade deve ter no máximo 150 caracteres.")]
        public string Cidade { get; set; } // cidade (length: 150)
    }
}