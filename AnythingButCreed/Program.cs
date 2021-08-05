using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();
            List<Song> allSongs = new List<Song>
        {
            new Song("Queen", "Don't Stop Me Now"),
            new Song("Creed", "With Arms Wide Open"),
            new Song("The Living End", "Wake Up"),
            new Song("Killswitch Engage", "Holy Diver"),
            new Song("In Flames", "Only For The Weak"),
            new Song("HammerFall", "Hearts on Fire"),
            new Song("Nightwish", "Amaranth"),
            new Song("System Of A Down", "Chop Suey!"),
            new Song("Ensiferum", "In My Sword I Trust"),
            new Song("Gojira", "L'enfant Sauvage"),
            new Song("Five Finger Death Punch", "Burn MF"),
            new Song("Arch Enemy", "The World is Yours"),
        };

            goodSongs = allSongs.FindAll(s => s.Artist != "Creed");
            foreach (var item in goodSongs)
            {
                Console.WriteLine($"{item.Artist} : {item.Name}");
            }
        }
    }
}
