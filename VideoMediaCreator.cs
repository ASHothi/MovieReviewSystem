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
        public string? Description { get; set; }
        public List<VideoMediaEntry> MediaWorkedOn { get; private set; }

        public VideoMediaCreator(string name) 
        {
            Name = name;
            Description = "EMPTY";
            MediaWorkedOn = new List<VideoMediaEntry>();
        }
    }
}
