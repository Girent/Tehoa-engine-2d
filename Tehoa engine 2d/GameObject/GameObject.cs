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
        public Vector2 position { get; set; }
        public string name { get; set; }
        public string spritePath { get; set; }
        
    }
}
