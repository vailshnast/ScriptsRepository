using UnityEngine;
using System.Collections.Generic;
using GlobalVars;


public class PlanetNode : MonoBehaviour {

    public string planetName;
    public int planetID;

    private Owner owner;

    private List<PlanetNode> connectedPlanet = new List<PlanetNode>();

	// Use this for initialization
	void Start () {
        Initialise();
        Debug.Log(GameObjects.planetList);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Owner GetOwner()
    {
        return owner;
    }
    public void SetOwner(Owner newOwner)
    {
        owner = newOwner;
    }

    protected void Initialise()
    {
        GameObjects.planetList.Add(this);
    }

    //private SetConnectedPlanets
}
