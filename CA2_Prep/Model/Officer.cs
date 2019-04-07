using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CA2_Prep.Model
{
    public class Officer
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Required]
        [Display(Name = "First name")]
        [RegularExpression(@"[A-Z,a-z,á, Á, ó, Ó, ú, Ú, í, Í, é, É]{2,50}", ErrorMessage = "Please enter a valid name")]
        public string FirstName { get; set; } = "";


        [Required]
        [Display(Name = "Surname")]
        [RegularExpression(@"[A-Z,a-z,á, Á, ó, Ó, ú, Ú, í, Í, é, É,']{2,50}", ErrorMessage = "Please enter a valid name")]
        public string Surname { get; set; } = "";

        [Required]
        //[Age]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Division")]
        public string Division { get; set; }

    }
}
