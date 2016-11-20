using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void UpdatePlanetProductivity(ImperiumPlanet Planet)
    {
        UpdatePlanetRawProductivity(Planet);
        UpdateZoneModifires(Planet);
    }

    private void UpdatePlanetRawProductivity(ImperiumPlanet Planet)
    {
        Planet.production = 0;
        Planet.science = 0;
        Planet.supply = 0;
        Planet.income = 0;
        
             foreach (var PlanetZone in Planet.PlanetZonesList.Values)
             {
                 if (PlanetZone.owner == Planet.planetOwner)
                 {
                Planet.production += PlanetZone.minerals;
                Planet.science += PlanetZone.science;
                Planet.supply += PlanetZone.supply;
                Planet.income += PlanetZone.income;
                 }
             }

        Planet.production += Planet.planetInfrastructureLevel;
        Planet.science += Planet.planetInfrastructureLevel;
        Planet.supply += Planet.planetInfrastructureLevel;
        Planet.income += Planet.planetInfrastructureLevel;
    }


    private void UpdateZoneModifires(ImperiumPlanet Planet) //собирает все базовые модификаторы с разработаных зон и складывает в планету
      {
        Planet.PlanetZoneModifiersList.Clear();
          foreach (var PlanetZone in Planet.PlanetZonesList.Values)
          {
              if (PlanetZone.owner == Planet.planetOwner)
              {
                Planet.PlanetZoneModifiersList.Add(PlanetZone.name, PlanetZone.zoneModifier);
              }
          }
      }
}
