using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Ries
{
    // eNum for DeskMaterial
    public enum DeskMaterial
    {
        oak = 200,
        laminate = 100,
        pine = 50,
        rosewood = 300,
        veneer = 125
    }

    // Desk structure (new in 2.0) - has no getters or setters - updated calls in other areas
    // of the code
   public struct Desk
    {
        // Variables - need to be public to be accessed outside of the struct Desk ie from DeskQuote
        public int Width;
        public int Depth;
        public int Drawers;
        public DeskMaterial Material;

        // constants
        public const int WIDTH_MIN   = 24;
        public const int WIDTH_MAX   = 96;
        public const int DEPTH_MIN   = 12;
        public const int DEPTH_MAX   = 48;
        public const int DRAWERS_MIN = 0;
        public const int DRAWERS_MAX = 7;

        // Methods
        public int getArea()
        {
            return Depth * Width;
        }

        // Validators
        public bool isValidWidth(int width)
        {
            if (width >= WIDTH_MIN && width <= WIDTH_MAX)
                return true;
            else
                return false;
        }

        public bool isValidDepth(int depth)
        {
            if (depth >= DEPTH_MIN && depth <= DEPTH_MAX)
                return true;
            else
                return false;
        }

        public bool isValidDrawers(int drawers)
        {
            if (drawers >= DRAWERS_MIN && drawers <= DRAWERS_MAX)
                return true;
            else
                return false;
        }
    }
}
