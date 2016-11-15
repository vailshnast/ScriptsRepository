using UnityEngine;
using System.Collections;
using GlobalVars;
public class PlanetNode : MonoBehaviour {

    public string planetName;
    private Owner owner;
    

	// Use this for initialization
	void Start () {
	
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
}
