using System.ComponentModel.DataAnnotations;

namespace repeatRazorPages.Model;

public class Pokemon
{
    public required int Id { get; set; }
    //[Required(ErrorMessage ="вы не заполнили поле")]
    //[StringLength(maximumLength:60,MinimumLength = 2)]
    public required string Name { get; set; }
    //[Required(ErrorMessage = "вы не заполнили поле")]
    public required string URL { get; set; }
   // [Required(ErrorMessage = "вы не заполнили поле")]
   // [StringLength(maximumLength: 600, MinimumLength = 12)]
    public required string Description { get; set; }
   // [Required(ErrorMessage = "вы не заполнили поле")]
   // [Range (1,100, ErrorMessage = "уровень должен быть в диапазоне от 1 - 100")]
    public required int Level { get; set; }
}
