using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Enemy
    {

        uint yPos;
        uint xPos;
        static Random rnd = new Random();

        public Enemy(uint y, uint x)
        {
            yPos = y;
            xPos = x;
        }

        public Enemy()
        {
            yPos = 0;
            xPos = 0;
        }

        public uint getX()
        {
            return xPos;
        }

        public uint getY()
        {
            return yPos;
        }

        public void randomMove()
        {
            int random = rnd.Next(1, 10);

            if(random == 1)
            {
                if(xPos != 0)
                    xPos--;
                if(yPos != 24)
                    yPos++;
            }
            else if(random == 2)
            {
                if (yPos != 24)
                    yPos++;
            }
            else if(random == 3)
            {
                if(xPos != 78)
                    xPos++;
                if (yPos != 24)
                    yPos++;
            }
            else if(random == 4)
            {
                if (xPos != 0)
                    xPos--;
            }
            else if(random == 5)
            {

            }
            else if(random == 6)
            {
                if (xPos != 78)
                    xPos++;
            }
            else if(random == 7)
            {
                if (xPos != 0)
                    xPos--;
                if(yPos != 0)
                    yPos--;
            }
            else if(random == 8)
            {
                if (yPos != 0)
                    yPos--;
            }
            else if(random == 9)
            {
                if (xPos != 78)
                    xPos++;
                if (yPos != 0)
                    yPos--;
            }
        }

    }
}
