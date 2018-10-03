﻿using System.Data;

namespace ATM.Interfaces
{
    public class Position:IPosition
    {
        public Position(int x=0, int y=0)
        {
            x_ = x;
            y_ = y;
        }

        public int x_ { get; set; }
        public int y_ { get; set; }

        public static Position operator-(Position pos1, Position pos2)
        {
            Position pos3 = new Position();
            pos3.x_ = pos1.x_ - pos2.x_;
            pos3.y_ = pos1.y_ - pos2.y_;
            return pos3;
        }
    }
}