using System;

namespace Catalog
{
    public class Film : File
    {
        string director;
        string mainActor;
        string mainActress;

        public Film(uint code,string name, string category, uint size, string director, string mainActor, string mainActress) : base (code,name,category,size)
        {
            this.director = director;
            this.mainActor = mainActor;
            this.mainActress = mainActress;
        }

        public void Play(){}

        private void RetrieveInformation(){}
    }
}