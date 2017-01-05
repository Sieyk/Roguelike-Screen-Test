using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Player
    {

        uint yPos;
        uint xPos;

        public Player(uint y, uint x)
        {
            yPos = y;
            xPos = x;
        }

        public Player()
        {
            yPos = 0;
            xPos = 0;
        }

        public void xPosMinus()
        {
            if(xPos != 0)
                xPos--;
        }

        public void yPosMinus()
        {
            if(yPos != 0)
                yPos--;
        }

        public void xPosAdd()
        {
            if(xPos != 78)
                xPos++;
        }

        public void yPosAdd()
        {
            if(yPos != 24)
                yPos++;
        }

        public uint getX()
        {
            return xPos;
        }

        public uint getY()
        {
            return yPos;
        }

    }
}
