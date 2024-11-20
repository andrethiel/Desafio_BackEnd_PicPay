namespace PicPay.Api.Models
{
	public class TransferenciaEntity
	{
		public Guid IdTransacao { get; set; }
		public int SenderId { get; set; }
		public CarteiraEntity Sender { get; set; }
		public int ReciverId { get; set; }
		public CarteiraEntity Reciver { get; set; }
		public decimal Valor { get; set; }

		public TransferenciaEntity(int senderId, int reciverId, decimal valor)
		{
			this.IdTransacao = Guid.NewGuid();
			this.SenderId = senderId;
			this.ReciverId = reciverId;
			this.Valor = valor;
		}
	}
}
