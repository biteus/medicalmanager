using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalManager.Models
{
    public class Medication
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage="Only alphabet of size 2 to 50 allowed")]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Dose { get; set; }
        [Required]
        [Display(Name = "When To Take")]
        public TakeTime Administer { get; set; }
        [Required]
        [Display(Name = "Prescription Date")]
        public DateTime Prescribed { get; set; }
        [Required]
        public Count Refills { get; set; }
        [Required]
        [Display(Name = "Prescriber Name")]
        public string Prescriber { get; set; }
    }
}
