using UnityEngine;
using System.Collections.Generic;
using GlobalVars;
using System.Linq;


namespace GlobalVars
{
    public class GlobalFuntions
    {      
        public static PlanetNode GetNode(int ID)
        {
            for (int i = 0; i < GameObjectLists.planetList.Count; i++)
            {
                if (GameObjectLists.planetList[i].GetComponent<PlanetNode>().GetID() == ID)
                    return GameObjectLists.planetList[i];
            }
            return null;		 
		 }

        public static List<int> SetIDList(List<int> IDList, int Count)
        {
            IDList.Clear();
            for (int i = 0; i < Count; i++)
            {
                IDList.Add(i);
            }
            return IDList;

        }
        public static List<int> SetPlanetNeighbours(List<int> IDList)
        {
            for (int i = 0; i < IDList.Count; i++)
            {
                GameObjectLists.planetNeighbours.Add(GetNode(i).GetConnectedPlanets());
            }
            return null;
        }
    }

}


