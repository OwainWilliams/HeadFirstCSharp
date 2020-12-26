using System;

namespace Clown
{
    class Program
    {
        static void Main(string[] args)
        {
            Clown oneClown = new Clown();
            oneClown.Name = "Boffo";
            oneClown.Height = 14;
            oneClown.TalkAboutYourself();

            Clown twoClown = new Clown();
            twoClown.Name = "Biff";
            twoClown.Height = 16;
            twoClown.TalkAboutYourself();

            Clown clown3 = new Clown();
            clown3.Name = twoClown.Name;
            clown3.Height = oneClown.Height - 3;
            clown3.TalkAboutYourself();

            twoClown.Height *= 2;
            twoClown.TalkAboutYourself();
        }
    }
}
