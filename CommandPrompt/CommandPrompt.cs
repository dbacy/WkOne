using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommandPrompt
{
    class CommandPrompt
    {
        ConsoleColor backgroundColor;
        ConsoleColor foregroundColor;
        string[] screenText;
        int height;
        int columns;

        public CommandPrompt(int height, int columns)
        {
            backgroundColor = ConsoleColor.Blue;
            foregroundColor = ConsoleColor.Black;
            
            screenText = new string[height];

            
            Console.SetWindowSize(columns, height + 7);

            
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        }

        public void Display()
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.Clear();             
             
            for (int i = 0; i < screenText.Length; i++)
            {
                Console.WriteLine(screenText[i]);
            }
        }
        public void SetScreenText(int lineNumber, string lineOfText)
        {
            screenText[lineNumber] = lineOfText;
        }

        public void SetBackgroundColor(string color)
        {
            backgroundColor = ConvertColor(color);
        }   

        public void SetForegroundColor(string color)
        {
            foregroundColor = ConvertColor(color);
        }   

        public static ConsoleColor ConvertColor(string strColor)
        {
            ConsoleColor color;
            switch (strColor.ToLower())
            {
                case "black": color = ConsoleColor.Black; break;
                case "red": color = ConsoleColor.Red; break;
                case "green": color = ConsoleColor.Green; break;
                case "yellow": color = ConsoleColor.Yellow; break;
                case "white": color = ConsoleColor.White; break;
                case "magenta": color = ConsoleColor.Magenta; break;
                case "darkYellow": color = ConsoleColor.DarkYellow; break;
                case "darkBlue": color = ConsoleColor.DarkBlue; break;
                case "darkCyan": color = ConsoleColor.DarkCyan; break;
                case "cyan": color = ConsoleColor.Cyan; break;
                case "darkGreen": color = ConsoleColor.DarkGreen; break;
                case "darkMagenta": color = ConsoleColor.DarkMagenta; break;
                case "gray": color = ConsoleColor.Gray; break;


                default: color = ConsoleColor.DarkGray; break;
            }
            return color;
        }
        public void SaveScreen(string fileName)
        {
            StreamWriter textOut = null;
            try
            {
                fileName = "../../../" + fileName;
                textOut = new StreamWriter(fileName);
                foreach (var line in screenText)
                {
                    textOut.WriteLine(line);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textOut != null)
                    textOut.Close();
            }
        }
            public void ReloadScreen(string fileName)
            {
            string line;
            int lineNumber = 0;
                StreamReader textIn;
            fileName = "../../../" + fileName;
            textIn = new StreamReader(fileName);
            while (true)
            {
                line = textIn.ReadLine();
                if (line == null)
                {
                    break;
                }
                screenText[lineNumber] = line;
                lineNumber++;
            }
            textIn.Close();
            }
           

    }
}
