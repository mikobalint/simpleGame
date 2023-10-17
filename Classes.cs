using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleGame
{
    public class Page
    {
        public string body;
        public Option[] options;

        public string? styleID;
        public Style? style; //ennek csak akkor van értéke, ha bármilyen módosítás érte az eredeti stílushoz képest
    }
    public class Option
    {
        public string text;
        public string[] commands;

        public string? styleID; // lehet inherited (az adott page-től örökölt) is
        public Style? style; // ennek is csak akkor van értéke, ha az opció valamilyen tulajdonságában
                             // függetlenedik a (saját vagy örökölt) styleID-jában meghatározott stílustól

    }
    public class Style
    {
        public class Body
        {
            public string? background;
            public string? foreground;
            public string? image;
        }
        public class Options
        {
            public string? background;
            public string? foreground;
            public byte? layout;
        }
    }
    public class Function
    {
        public string fileLocation;
        public string referenceName;
    }

    public static class Memory
    {
        // Ha szótárakat használok, akkor a fentebb leírt classokba nem kell id változót tennem
        public static Dictionary<string, Page> Pages = new Dictionary<string, Page>();
        public static Dictionary<string, Option> Options = new Dictionary<string, Option>();
        public static Dictionary<string, Style> Styles = new Dictionary<string, Style>();
        public static Dictionary<string, Function> Functions = new Dictionary<string, Function>();

        public static Dictionary<string, string> Strings = new Dictionary<string, string>();
        public static Dictionary<string, int> NumbersInt = new Dictionary<string, int>(); // dinamikusan váltogat Int és Float között
        public static Dictionary<string, float> NumbersFloat = new Dictionary<string, float>(); // A float szótárat csak azon ritka esetekben használja, amikor az adott változó nem egész számot tárol
        public static Dictionary<string, bool> Booleans = new Dictionary<string, bool>();

    }

    public static class SysInfo
    {
        public static string sourcePath;

    }

    public class Error
    {
        public string title;
        public string message;
        public int line;

        public Error(string title, string message, int line)
        {
            this.title = title;
            this.message = message;
            this.line = line;
        }

    }
}
