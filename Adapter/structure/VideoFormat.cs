using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.structure
{
    class VideoFormat : IVideoPlayer
    {
        public string _name;

        public VideoFormat(string name)
        {
            _name = name;
        }
        public void LoadVideo()
        {
            Console.WriteLine(String.Format("Loading video {0}",_name));
        }
    }
}
