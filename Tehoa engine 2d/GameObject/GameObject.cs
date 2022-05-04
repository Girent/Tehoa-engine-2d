using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tehoa_engine_2d
{
    public class GameObject : Object
    {
        public GameObject()
        {

        }
        public Vector2 Position { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        public string SpritePath { get; set; }
        
    }
}
