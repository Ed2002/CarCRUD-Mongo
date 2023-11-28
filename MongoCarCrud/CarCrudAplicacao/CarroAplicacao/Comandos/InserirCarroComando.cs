using System.ComponentModel.DataAnnotations;

namespace CarCrudAplicacao.CarroAplicacao.Comandos
{
    public class InserirCarroComandos
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome é obrigatório")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O renavam é obrigatório")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "A placa é obrigatória")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O valor é obrigatório")]
        [Required(ErrorMessage = "O ano é obrigatório")]
        public string Nome { get; set; } = string.Empty;

        public int Renavam { get; set; }

        public string Placa { get; set; } = string.Empty;

        public float Valor { get; set; }

        [Required(ErrorMessage = "O ano é obrigatório")]
        public int Ano { get; set; }
    }
}
