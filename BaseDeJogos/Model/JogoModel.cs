
using BaseDeJogos.Enums;
using System.ComponentModel.DataAnnotations;


namespace BaseDeJogos.Model
{
    public class JogoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public Genero Genero {  get; set; }
        public int TempoDuracao { get; set; }
        [Required]
        public PlataformaVideoGame plataformaVideoGame { get; set; }
        [Required]
        public StatusJogo Status  { get; set;}

        
    }
}
