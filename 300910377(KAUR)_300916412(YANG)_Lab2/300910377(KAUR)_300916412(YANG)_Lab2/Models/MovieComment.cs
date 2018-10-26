using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _300910377_KAUR__300916412_YANG__Lab2.Models
{
    public class MovieComment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Comment")]
        public int CommentId { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
    }
}
