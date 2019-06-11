using System;

namespace PhotoAlbumTarea
{
    public class PhotoAlbum
    {
        protected uint numberOfPages = 0;
        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(uint numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        public int GetNumberOfPages()
        {
            return Convert.ToInt32(numberOfPages.GetHashCode());
        }
    }
}