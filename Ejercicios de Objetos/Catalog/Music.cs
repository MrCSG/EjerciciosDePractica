using System;

namespace Catalog
{
    public class Music : File
    {
        string singer;
        DateTime length;
        public Music(uint code, string name, string category, uint size, string singer, DateTime length) : base(code, name, category, size)
        {
            this.singer = singer;
            this.length = length;
        }

        public void Play(){}
        private void RetrieveInformation(){}
    }
}