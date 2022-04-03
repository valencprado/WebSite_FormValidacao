using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebSite_FormValidacao.Models
{
    public class QuestionarioModel
    {
        [Required]
        [DisplayName("Tipo de Projeto")]
        public string TipoProjeto { get; set; }
        [Required(ErrorMessage = "O CEP deve ser informado!")]
        [RegularExpression(@"^\d{8}$|^\{5}-\{3}$", ErrorMessage = "O código postal deverá estar no formato 00000000 ou 00000-000")]
        [DisplayName("CEP")]
        public string Cep {get; set;}
        
        [Required(ErrorMessage = "O nome do contato deve ser informado!")]
        [StringLength(50, MinimumLength = 5)]
        public string Contato { get; set; }

        [Required(ErrorMessage = "O email é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone deve ser informado!")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Forneça o número do telefone no formato (000) 000-0000")]
        [DisplayName("Número do Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe a descrição do projeto!")]
        [DisplayName("Descrição do Projeto")]
        [StringLength(5000, MinimumLength = 20)]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
    }
}