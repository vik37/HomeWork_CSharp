using System;

namespace HomeWork_0601
{
    public class PhotoAlbum
    {
        private int numberOfPages;
        public int Pages;
        

        public PhotoAlbum()
        {

        }

        public PhotoAlbum(int pages)
        {
            Pages = pages;

        }

        public void GetNumberOfPages()
        {
            numberOfPages = Pages;
            Console.WriteLine($"{numberOfPages} number od pages");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pfoto = new PhotoAlbum();
            pfoto.Pages = 16;
            pfoto.GetNumberOfPages();

            Console.ReadLine();

        }

    }
}
