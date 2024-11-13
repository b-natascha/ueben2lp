namespace ueben2lp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Character
    {
        private char drawCharacter;
        private ConsoleColor foregroundColor;
        private ConsoleColor backgroundColor;

        public char DrawCharacter
        {
            get
            {
                return this.drawCharacter;
            }

            set
            {
                this.drawCharacter = value;
            }
        }

        public ConsoleColor ForegroundColor
        {
            get
            {
                return this.foregroundColor;
            }

            set
            {
                this.foregroundColor = value;
            }
        }

        public ConsoleColor BackgroundColor
        {
            get
            {
                return this.backgroundColor;
            }

            set
            {
                this.backgroundColor = value;
            }
        }

    }
}