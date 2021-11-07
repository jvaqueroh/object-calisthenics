using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectCalisthenics.Rule5.OneDotPerLine{
    class Board{
        List<Location> squares;

        String BoardRepresentation(){
            StringBuilder buf = new StringBuilder();
            foreach (Location l in squares)
                l.AddTo(buf);
            return buf.ToString();
        }

        class Location{
            internal Piece current;
            internal void AddTo(StringBuilder buf){
                current.AddTo(buf);
            }
        }

        class Piece{
            internal String representation;
            
            internal void AddTo(StringBuilder buf){
                buf.Append(RepresentationForBoard());
            }

            private string RepresentationForBoard(){
                return representation.Substring(0, 1);
            }
        }
    }
}