using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _300910377_KAUR__300916412_YANG__Lab2.Models
{
    public class PlayMovie
    {
        public Users user { get; set; }

        public Movie movie { get; set; }

        public IEnumerable<Comment> comment { get; set; }


    }
}
