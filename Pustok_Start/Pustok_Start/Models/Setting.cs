using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Pustok_Start.Models
{
    public class Setting
    {
        [Required]
        [MaxLength(30)]
        public string Key { get; set; }
        
        public string Value { get; set; }
     
    }
}
