using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data;

//Definição do Context explicando onde vai acessar e qual banco
public class FilmeContext : DbContext
{
	public FilmeContext(DbContextOptions<FilmeContext> opts)
		:base(opts)
	{

	}

	public DbSet<Filme> Filmes { get; set; }
}
