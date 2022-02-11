using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaReviewSystem
{
    public abstract class VideoMediaCreator
    {
        public string? Name { get; set; }
        public List<VideoMedia> MediaWorkedOn { get; set; }
    }
}
