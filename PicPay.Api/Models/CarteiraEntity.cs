using PicPay.Api.Models.Enum;

namespace PicPay.Api.Models
{
	public class CarteiraEntity
	{
		public int Id { get; set; }
		public string NomeCompleto { get; set; }
		public string CPFCNPJ { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public decimal SaldoConta { get; set; }
		public UserType UserType { get; set; }

		public CarteiraEntity(string nome, string cpfcnpj, string email, string senha, UserType userType, decimal saldo = 0)
		{
			this.NomeCompleto = nome;
			this.CPFCNPJ = cpfcnpj;
			this.Email = email;
			this.Senha = senha;
			this.UserType = userType;
			this.SaldoConta = saldo;
		}

		public void DebitoConta(decimal valor)
		{
			this.SaldoConta -= valor;
		}

		public void CreditoConta(decimal valor)
		{
			this.SaldoConta += valor;
		}
	}
}
