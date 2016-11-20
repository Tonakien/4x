using UnityEngine;
using System.Collections;

public class PlanetManager : MonoBehaviour {

    public ModifiersManager modifierManager;

    public void UpdatePlanetTotalProductivity(ImperiumPlanet Planet) // функция апдейта 4х главных параметров планеты. Включает апдейт модификаторов.
    {
        UpdateZoneModifires(Planet);
        UpdatePlanetProductivity(Planet);
    }

    private void UpdatePlanetProductivity(ImperiumPlanet Planet)
    {
        // Обнуление для пересчета
        Planet.production = 0;
        Planet.science = 0;
        Planet.supply = 0;
        Planet.income = 0;

        foreach (var PlanetZone in Planet.PlanetZonesList.Values) // добавление значений из планетарных зон в саму планету
        {
            if (PlanetZone.owner == Planet.planetOwner) //Проверка принадлежности зоны
            {
                Planet.production += PlanetZone.minerals;
                Planet.science += PlanetZone.science;
                Planet.supply += PlanetZone.supply;
                Planet.income += PlanetZone.income;
            }
        }

        // Прибавление инфраструктурного уровня к продакшену
        Planet.production += Planet.planetInfrastructureLevel;
        Planet.science += Planet.planetInfrastructureLevel;
        Planet.supply += Planet.planetInfrastructureLevel;
        Planet.income += Planet.planetInfrastructureLevel;

        foreach (var modifier in Planet.PlanetZoneModifiersList.Values) // обработка данных по эффектам от зон
        {
            if (modifier.applyType == "PLANET")
            {
                modifierManager.UpdatePlanetByModifier(Planet, modifier);
            }

        }

        foreach (var modifier in Planet.PlanetImperiumModifiersList.Values) // обработка данных по эффектам от Империи
        {
            if (modifier.applyType == "PLANET")
            {
                modifierManager.UpdatePlanetByModifier(Planet, modifier);
            }

        }
    }


    private void UpdateZoneModifires(ImperiumPlanet Planet) //собирает все базовые модификаторы с разработаных зон и складывает в планету
    {
        Planet.PlanetZoneModifiersList.Clear();
        foreach (var PlanetZone in Planet.PlanetZonesList.Values)
        {
            if (PlanetZone.owner == Planet.planetOwner) //Проверка на принадлежность
            {
                Planet.PlanetZoneModifiersList.Add(PlanetZone.name, PlanetZone.zoneModifier);
            }
        }
    }
}
