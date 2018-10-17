using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Ries
{
    // eNum //
    public enum DeskMaterial
    {
        oak = 200,
        laminate = 100,
        pine = 50,
        rosewood = 300,
        veneer = 125
    }

    public class Desk
    {
        // Variables
        private int    Width;
        private int    Depth;
        private int    Drawers;
        public DeskMaterial Material { get; set; }

        // constants
        public const int WIDTH_MIN   = 24;
        public const int WIDTH_MAX   = 96;
        public const int DEPTH_MIN   = 12;
        public const int DEPTH_MAX   = 48;
        public const int DRAWERS_MIN = 0;
        public const int DRAWERS_MAX = 7;

        // Constructor
        public Desk()
        {
            ;
        }

        // getters and setters
        public int getWidth()
        {
            return this.Width;
        }

        public void setWidth(int width)
        {
            if (isValidWidth(width))
                this.Width = width;
            //else
                // invalid input
        }

        public int getDepth()
        {
            return this.Depth;
        }

        public void setDepth(int depth)
        {
            if (isValidDepth(depth))
                this.Depth = depth;
            //else
                // invalid input
        }

        public int getDrawers()
        {
            return this.Drawers;
        }

        public void setNumdrawers(int drawers)
        {
            if (isValidDrawers(drawers))
                this.Drawers = drawers;
            //else
                // invalid input
        }

        public int getArea()
        {
            return getWidth() * getDepth();
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
