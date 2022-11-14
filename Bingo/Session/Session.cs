using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Session
{
    public sealed class Session
    {

        private static volatile Session? _instance;
        private static object sync = new();

        private Session() {}

        public static Session Instance
        {

            get
            {

                if(_instance == null)
                {

                    lock(sync)
                    {

                        _instance ??= new Session();

                    }

                }

                return _instance;

            }

        }

        /// <summary>
        /// Propertie for positions and balls
        /// </summary>

        public int NextPositionBX { get ; set; }
        public int NextPositionBY { get; set; }
        public int NextPositionIX { get; set; }
        public int NextPositionIY { get; set; }
        public int NextPositionNX { get; set; }
        public int NextPositionNY { get; set; }
        public int NextPositionGX { get; set; }
        public int NextPositionGY { get; set; }
        public int NextPositionOX { get; set; }
        public int NextPositionOY { get; set; }
        public int CurrentBall { get; set; }
    }
}
