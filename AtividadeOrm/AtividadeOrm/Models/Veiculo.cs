using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;

namespace AtividadeOrm.Models
{
    public class Veiculo
    {
            [Key]
            public int VeiculoId { get; set; }

            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Ano { get; set; }

            // Propriedade para indicar o tipo do veículo (TPH - Table Per Hierarchy)
            public string TipoVeiculo { get; set; }

            // Chave estrangeira para relacionamento com propriedade
            public int ProprietarioId { get; set; }
            public Proprietario Proprietario { get; set; }
        }


    }
