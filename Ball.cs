using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeprojectname
{
    internal class Ball
    {
        private string color;
        private int quality;
        public Ball(string color = "Red", int quality = 20)
        {
            this.color = color;
            this.quality = quality;
        }
        public string Color  
        {
            get { return color; }
            set
            {
                if (Color == StorePantry.Red.ToString() || Color == StorePantry.Yellow.ToString() || Color == StorePantry.Pink.ToString() || Color == StorePantry.Gold.ToString())
                {
                    color = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }        
        public int Quality
        {
            get
            {
                return quality;
            }
            set
            { 
                quality = value;               
            }
        }
        public void LowerQuality(int lowerQuality)
        {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("________________________________");
                Console.WriteLine("Quality for the ball decreases with " + lowerQuality);
                Console.WriteLine("________________________________");
                Console.ResetColor();            
            quality = quality - lowerQuality;
            if (quality < 0)
            {
                System.Threading.Thread.Sleep(2000);
                quality = 0;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("________________");
                Console.WriteLine("Ball destroyd!");
                Console.WriteLine("________________");                
            }
        }

        public override string ToString()
        {
            return "Quality on ball: " + quality + ". Color on ball: " + color;
        }

    }
}
