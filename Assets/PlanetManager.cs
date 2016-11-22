using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class PlanetManager : MonoBehaviour {

    public ModifierManager modifierManager;

    // полный апдейт всего производства планеты
    public void UpdatePlanetProductivity(Colony Planet)
    {

        // Обнуление для пересчета
        Planet.production = 0;
        Planet.science = 0;
        Planet.supply = 0;
        Planet.income = 0;

        // Прибавление инфраструктурного уровня к продакшену
        Planet.production += Planet.planetInfrastructureLevel;
        Planet.science += Planet.planetInfrastructureLevel;
        Planet.supply += Planet.planetInfrastructureLevel;
        Planet.income += Planet.planetInfrastructureLevel;

        //апдейт того что дают зоны
        foreach (var zone in Planet.PlanetZonesList)
        {
            Planet.production += zone.minerals;
            Planet.science += zone.science;
            Planet.supply += zone.supply;
            Planet.income += zone.income;
        }

        // апдейт того что дают модификаторы применительно к данной планете
        modifierManager.UpdatePlanetByModifier(Planet);



    }
 
}
