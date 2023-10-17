using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace simpleGame
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
    
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

    public static class memory
    {
        // Ha szótárakat használok, akkor a fentebb leírt classokba nem kell id változót tennem
        public static Dictionary<string, Page> pages = new Dictionary<string, Page>();
        public static Dictionary<string, Option> options = new Dictionary<string, Option>();
        public static Dictionary<string, Style> styles = new Dictionary<string, Style>();
        public static Dictionary<string, Function> functions = new Dictionary<string, Function>();

        public static Dictionary<string,string> strings = new Dictionary<string, string>();
        public static Dictionary<string, float> numbers = new Dictionary<string, float>();
        public static Dictionary<string, bool> booleans = new Dictionary<string, bool>();



    }
}
