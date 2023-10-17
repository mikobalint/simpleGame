using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace simpleGame
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static void raiseError(string title, string message, int line)
        {

        }

        public static string hideStrings(string text)
        {
            char insideString = ' ';
            int index = 0;

            for (int i = text.Length-1; i <= 0 ; i--)
            {
                if (insideString == ' ')
                {
                    if (text[i] == '\"' || text[i] == '\'')
                    {
                        insideString = text[i];
                        index = i;
                    }
                }
                else
                {
                    if (text[i] == insideString)
                    {
                        insideString = ' ';
                        text = text.Substring(i,index);
                    }


                }

            }

            return text;
        }

        public static void processInput(string sourcePath)
        {
            StreamReader source = new StreamReader(sourcePath);

            string line;

            int lineNum = 1;
            while (!source.EndOfStream)
            {
                line = source.ReadLine();

                if (line.Length > 0)
                {
                    if (line[0] == '#')
                    {
                        string[] splitLine = line.Split(' ');

                        if (splitLine[0] == "#page")
                        {

                        }
                        else if (splitLine[0] == "#var")
                        {
                            if (splitLine.Length > 1)
                            {
                                // itt járok
                                // kell hozzá a hideStrings függvény --> \uE0000-ra cseréli a stringeket
                                // a függvény félkész állapotban van
                            }
                            else
                            {
                                raiseError("SyntaxError",
                                           "The name of the variable is expected.",
                                           lineNum);
                            }
                        }

                    }
                }
                else
                {

                }

                lineNum++;
            }
            
        }

    }
    
}
