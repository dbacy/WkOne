using System;
using System.Collections.Generic;
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
            // create the screen to hold the number of rows passed in with the height parameter
            screenText = new string[height];

            // we will use the C# object to set the size of our window.
            Console.SetWindowSize(columns, height + 7);

            // let's set the initial screen rows to all blank lines
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

    }
}
