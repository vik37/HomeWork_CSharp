using System;

namespace HomeWork_0601
{
    public class PhotoAlbum
    {
        private int numberOfPages;
        public int Pages;
        

        public PhotoAlbum()
        {
            Pages = 16;
        }

        public void GetNumberOfPages()
        {
            numberOfPages = Pages;
            Console.WriteLine($"{numberOfPages} number od pages");
        }
    }

    public class BigPhotoAlbum
    {
        public int pages;
        private int numberOfPages;

        public BigPhotoAlbum()
        {
            pages = 64;
        }
        public void GetNumberOfPages()
        {
            numberOfPages = pages;
            Console.WriteLine($"{numberOfPages} number od pages");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var photo1 = new PhotoAlbum();
            
            photo1.GetNumberOfPages();

            var photo2 = new PhotoAlbum();
            photo2.Pages = 24;
            photo2.GetNumberOfPages();

            var photo3 = new BigPhotoAlbum();
            photo3.GetNumberOfPages();

                       
            Console.ReadLine();

        }
       

    }
}
