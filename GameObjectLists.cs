using UnityEngine;
using System.Collections.Generic;
using GlobalVars;

namespace GlobalVars
{
    public class GameObjectLists
    {
        public static List<int> planetIDList = new List<int>();

        public static List<PlanetNode> planetList = new List<PlanetNode>();

        public static List<int[]> planetNeighbours = new List<int[]>();
    }
    
}