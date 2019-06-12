using System;

namespace Catalog
{
    public abstract class File
    {
        protected string name;
        protected uint code;
        protected string category;
        protected uint size;

        public File(uint code,string name, string category, uint size)
        {
            this.code = code;
            this.name = name;
            this.category = category;
            this.size = size;
        }
    }
}