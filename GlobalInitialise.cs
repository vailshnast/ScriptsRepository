using UnityEngine;
using System.Collections;
using GlobalVars;
public class GlobalInitialise : MonoBehaviour {

	// Start is called after Awake
	void Start()
	{
			GlobalFuntions.SetIDList(GameObjectLists.planetIDList, GameObjectLists.planetList.Count);
			GlobalFuntions.SetPlanetNeighbours(GameObjectLists.planetIDList);
	}

	  // First is called Awake
	  void Awake()
	  {

	  }
}
