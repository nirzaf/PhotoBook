using System;

namespace PhotoBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PhotoBook Class");
            var p1 = new PhotoBookTest();
        }
    }

    public class PhotoBookTest
    {
        public PhotoBookTest()
        {
            var p1 = new PhotoBook();
            Console.WriteLine(p1.GetNumberPages());

            var p2 = new PhotoBook(24);
            Console.WriteLine(p2.GetNumberPages());

            var b1 = new BigPhotoBook();
            Console.WriteLine(b1.GetNumberPages());
        }
    }

    public class PhotoBook
    {
        private int numPages { get; set; }

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int num)
        {
            numPages = num;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class BigPhotoBook : PhotoBook
    {
        private int numPages { get; set; }

        public BigPhotoBook()
        {
            numPages = 64;
        }

        public new int GetNumberPages()
        {
            return numPages;
        }
    }
}