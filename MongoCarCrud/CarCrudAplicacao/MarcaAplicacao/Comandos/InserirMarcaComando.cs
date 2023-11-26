using System.ComponentModel.DataAnnotations;

namespace CarCrudAplicacao.MarcaAplicacao.Comandos
{
    public class InserirMarcaComandos
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;
    }
}
