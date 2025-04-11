using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoFormValidations.Models
{
    public class Student
    {

        [DisplayName("Rno")]
        [Required(ErrorMessage ="This Field cannot be blank")]
        public int Rno { get; set; }



        [DisplayName("Name")]
        [Required(ErrorMessage = "This Field cannot be blank")]
        [StringLength(100,ErrorMessage = "Name cannot exceed 100 characters")]
        public string? Name { get; set; }



        [DisplayName("DOB")]
        [Required(ErrorMessage = "This Field cannot be blank")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }



        [DisplayName("Email")]
        [EmailAddress(ErrorMessage ="Invalid Email Format")]
        public string? Email { get; set; }



        [DisplayName("Mno")]
        [StringLength(13, ErrorMessage = "Mobile Number cannot exceed 13 digits")]
        public string? Mno { get; set; }



        [DisplayName("Percentage")]
        [Range(30,80)]
        public decimal Percentage { get; set; }

    }
}
