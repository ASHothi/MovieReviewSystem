using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaReviewSystem
{
    public class Movie : VideoMedia
    {
        public TimeOnly RunTime { get; set; }

        public Movie(string title) : base(title)
        {
        }

    }
}
