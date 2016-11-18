using UnityEngine;
using System.Collections.Generic;
using GlobalVars;

    public class PlanetNode : MonoBehaviour
    {

        public string planetName;
    
        private Owner owner;

        [SerializeField]
        private List<PlanetNode> connectedPlanets = new List<PlanetNode>();

        [SerializeField]
        private int planetID;

    // Use this for initialization
		void Awake()
        {
            Initialise();
		}

        // Update is called once per frame
        void Update()
        {

        }

        public Owner GetOwner()
        {
            return owner;
        }
        public void SetOwner(Owner newOwner)
        {
            owner = newOwner;
        }
        public int[] GetConnectedPlanets()
        {
			int[] connectedPlanetsArray = new int[connectedPlanets.Count];

			for (int i = 0; i < connectedPlanetsArray.Length; i++)
			{
				  connectedPlanetsArray[i] = connectedPlanets[i].planetID;				  
			}
			return connectedPlanetsArray;
	    }
   	
                 
        public int GetID()
        {
            return planetID;
        }
        protected void Initialise()
        {
            GameObjectLists.planetList.Add(this);
        }


    }
