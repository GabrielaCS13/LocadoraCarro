using System.ComponentModel.DataAnnotations;

namespace LocacaoCarroMVC.Models
{
	public class JuridicoModel : ClienteModel
	{
		[Key]
		public int codigo { get; set; }

		public string nome_fantasia { get; set; }

		public string cnpj { get; set;}

	}
}
