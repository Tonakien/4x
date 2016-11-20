using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class PlanetaryProject //базовый класс для хранения в словаре проектов
{
    public string name;
    public int infrastructureLevel;
    public float baseProductionCost;
    public float baseUpkeepProduction;
    public float baseUpkeepScience;
    public float baseUpkeepSupply;
    public float baseUpkeepIncome;
    public float startThreshold;
    public BaseModifier outcomeModifierType;

}

public class LocalPlanetaryProject : PlanetaryProject
{
    public ImperiumPlanet owner;
    public float currentCompleteness;
    public float currentUpkeepProduction;
    public float currentUpkeepScience;
    public float currentUpkeepSupply;
    public float currentUpkeepIncome;
    public string state;
    public float currentOutcomeValue;

}
