using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{

	//prop é um atalho para criar atributo
	[Required(ErrorMessage = "O título do filme é obrigatório")] //Deixando o campo obrigatório
	[StringLength(50, ErrorMessage = "O titulo do filme não pode exceder 50 caracteres")]
	public string Titulo { get; set; }

	[Required(ErrorMessage = "O título do gênero é obrigatório")]
	[StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
	public string Genero { get; set; }

	[Required(ErrorMessage = "A duração do filme é obrigatório")]
	[Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
	public int Duracao { get; set; }

	[Required(ErrorMessage = "O nome do Diretor é obrigatório")]
	public string Diretor { get; set; }
}
