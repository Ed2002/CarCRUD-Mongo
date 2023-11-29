using System.ComponentModel.DataAnnotations;

namespace CarCrudAplicacao.ModeloAplicacao.Comandos
{
    public class InserirModeloComandos
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;
        public long IdMarca { get; set; }
    }
}
