using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDesign
{
    class Movie
    {
        string title;
        string genre;
        string mainCharacter;
        int lenth;

        public Movie(string title, string genre, string mainCharacter, int lenth)
        {
            this.title = title;
            this.genre = genre;
            this.mainCharacter = mainCharacter;
            this.Lenth = lenth;
        }

        public int Lenth { get => lenth; set => lenth = value; }

        public override string ToString()
        {
            return String.Format("{0} is the tilte of the film which " +
                "main character is {1}. \nThe genre is {2} and the length of " +
                "the movie is {3} minutes. " , title,mainCharacter,genre,lenth);
        }
    }
}
