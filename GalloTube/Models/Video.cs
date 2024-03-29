using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GalloTube.Models;

[Table("Video")]
public class Video
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Título")]
    [Required(ErrorMessage = "O Título é obrigatório")]
    [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 100 caracteres")]
    public string Title { get; set; }


    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "A Descrição é obrigatória")]
    [StringLength(8000, ErrorMessage = "A Descrição deve possuir no máximo 5000 caracteres")]
    public string Description { get; set; }

    [Column(TypeName = " UploadDate")]
    [Display(Name = " UploadDate")]
    [Required(ErrorMessage = " Date time é obrigatório")]
    public Int16 VideoDate { get; set; }

    [Display(Name = "Duração (em minutos)")]
    [Required(ErrorMessage = "A Duração é obrigatória")]
    public Int16 Duration { get; set; }



    [StringLength(200)]
    [Display(Name = "Thumbnail")]
    public string Thumbnail	 { get; set; }

   [Display(Name = "VideoFile")]
    [Required(ErrorMessage = "VideoFile é obrigatória")]
    public Int16 VideoFile { get; set; }
}
