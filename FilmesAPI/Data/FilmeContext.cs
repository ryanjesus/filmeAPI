using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data;

//Definição do Context explicando onde vai acessar e qual banco
public class FilmeContext : DbContext
{
	public FilmeContext(DbContextOptions<FilmeContext> opts)
		: base(opts)
	{

	}

	protected override void OnModelCreating(ModelBuilder builder) //sobrescrita do metodo
	{
		builder.Entity<Sessao>()
			.HasKey(sessao => new { sessao.FilmeId, sessao.CinemaId }); //para cada sessão vai compor uma chave composta

		builder.Entity<Sessao>()
			.HasOne(sessao => sessao.Cinema)
			.WithMany(cinema => cinema.Sessoes)
			.HasForeignKey(sessao => sessao.CinemaId);

		builder.Entity<Sessao>()
			.HasOne(sessao => sessao.Filme)
			.WithMany(filme => filme.Sessoes)
			.HasForeignKey(sessao => sessao.FilmeId);

		//Tipo de deleção
		builder.Entity<Endereco>()
			.HasOne(endereco => endereco.Cinema)
			.WithOne(cinema => cinema.Endereco)
			.OnDelete(DeleteBehavior.Restrict);
	}


	public DbSet<Filme> Filmes { get; set; }
	public DbSet<Cinema> Cinemas { get; set; }

	public DbSet<Endereco> Enderecos { get; set; }

	public DbSet<Sessao> Sessoes { get; set; } 
}
