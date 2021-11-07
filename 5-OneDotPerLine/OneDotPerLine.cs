using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectCalisthenics.Rule5.OneDotPerLine{
    class Board{
        List<Location> squares;

        String BoardRepresentation(){
            StringBuilder buf = new StringBuilder();
            foreach (Location l in squares)
                buf.Append(l.current.representation.Substring(0, 1));
            return buf.ToString();
        }

        class Piece{
            internal String representation;
        }

        class Location{
            internal Piece current;
        }
    }
}