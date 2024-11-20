using Microsoft.EntityFrameworkCore;
using PicPay.Api.Models;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions<DataContext> options) : base(options) { }

	public DbSet<CarteiraEntity> Wallets { get; set; }

	public DbSet<CarteiraEntity> Transacoes { get; set; }
}