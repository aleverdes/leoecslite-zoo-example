using System;

namespace AleVerDes.LeoEcsLiteZoo.Example
{
    public struct Player
    {
        public struct Input
        {
            public float Horizontal;
            public float Vertical;
        }
    }
        
    [Serializable]
    public struct Health
    {
        public float Current;
        public float Max;
    }
}