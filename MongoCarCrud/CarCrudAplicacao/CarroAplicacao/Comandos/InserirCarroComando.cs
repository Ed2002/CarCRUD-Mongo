using System.ComponentModel.DataAnnotations;

namespace CarCrudAplicacao.CarroAplicacao.Comandos
{
    public class InserirCarroComandos
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "O renavam é obrigatório")]
        public int Renavam { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "A placa é obrigatória")]
        public string Placa { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "O valor é obrigatório")]
        public float Valor { get; set; }

        [Required(ErrorMessage = "O ano é obrigatório")]
        public DateTime Ano { get; set; }
        public long IdModelo { get; set; }
    }
}
