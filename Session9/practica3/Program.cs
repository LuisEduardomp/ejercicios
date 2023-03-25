using System;

namespace AlbumTest
{
    public class PhotoAlbum
    {
        private int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int pages)
        {
            numberOfPages = pages;
        }

        public int GetNumberOfPages() { return numberOfPages; }
    }

    public class BigPhotoAlbum
    {
        private int numberOfPages;

        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }

        public int GetNumberOfPages() { return numberOfPages; }
    }

    class AlbumTest
    {
        static void Main(string[] args)
        {
            PhotoAlbum    album1 = new PhotoAlbum();
            PhotoAlbum    album2 = new PhotoAlbum(24);
            BigPhotoAlbum album3 = new BigPhotoAlbum();

            Console.WriteLine("El 'álbum1' tiene: {0} paginas", album1.GetNumberOfPages());
            Console.WriteLine("El 'álbum2' tiene: {0} paginas", album2.GetNumberOfPages());
            Console.WriteLine("El 'álbum3' tiene: {0} paginas", album3.GetNumberOfPages());
        }
    }
}
