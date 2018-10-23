using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _300910377_KAUR__300916412_YANG__Lab2.Models
{
    public class Association
    {
        [Key]
        public int AssociationId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Video")]
        public int VideoId { get; set; }

        [ForeignKey("Comment")]
        public int CommentId { get; set; }
    }
}
