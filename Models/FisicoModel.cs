using System.ComponentModel.DataAnnotations;

namespace LocacaoCarroMVC.Models
{
	public class FisicoModel : ClienteModel
	{
		[Key]
		public int codigo { get; set; }

		public String cpf { get; set; }

		public string rg { get; set; }
	}
}
