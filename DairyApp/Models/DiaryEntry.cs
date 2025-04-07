using System.ComponentModel.DataAnnotations;

namespace DairyApp.Models
{
    public class DiaryEntry
    {
        //[Key]
        public int Id { get; set; }
      [Required(ErrorMessage ="please enter a title!..")]
       /* [StringLength(100,MinimumLength =3,
            ErrorMessage ="Title must between 3 and 100 characters!..")]*/
        public string  Title { get; set; }=string.Empty;
        [Required]
        public string Content { get; set; }=string.Empty;
       [Required]
        public DateTime Created { get; set; }=DateTime.Now;

    }
}
