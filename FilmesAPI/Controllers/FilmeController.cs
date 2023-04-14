using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

//Atalho de importação alt + enter

[ApiController] //Sempre quando usa o ApiController importa a using Microsoft.AspNetCore.Mvc;
[Route("[controller]")]
public class FilmeController : ControllerBase
{
	private static List<Filme> filmes = new List<Filme>();

	[HttpPost]
	public void AdicionaFilme([FromBody]Filme filme) //O tipo é void pq n vou me preocupar com o retorno
							//Estamos recebendo o filme atraves do parametro	
	{
		filmes.Add(filme);

		Console.WriteLine(filme.Titulo);
		Console.WriteLine(filme.Duracao);
	}
}
