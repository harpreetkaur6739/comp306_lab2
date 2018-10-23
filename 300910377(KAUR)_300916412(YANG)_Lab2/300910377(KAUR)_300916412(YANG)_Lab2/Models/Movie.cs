using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _300910377_KAUR__300916412_YANG__Lab2.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string MovieName { get; set; }

        [Required]
        public string FileName { get; set; }        

        public string Description { get; set; }

        public bool Empty
        {
            get
            {
                return (MovieId == 0 &&
                        string.IsNullOrWhiteSpace(MovieName) &&
                        string.IsNullOrWhiteSpace(FileName) &&
                        string.IsNullOrWhiteSpace(Description));
            }
        }

    }
}
