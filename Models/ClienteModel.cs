using System.ComponentModel.DataAnnotations;

namespace LocacaoCarroMVC.Models
{
	public class ClienteModel
	{

		[Key]
		public int codigo { get; set; }

		public string nome { get; set; }

		public int idade { get; set; }
	}
}
