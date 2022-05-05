using System;
using System.Numerics;


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
