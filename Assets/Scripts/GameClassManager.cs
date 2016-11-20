using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;


public class BaseModifier
{
    public string name;
    public string applyType;
    public string type;
    public string effectType;
    public float effectValue;
}

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

public class LocalPlanetaryProject: PlanetaryProject
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


public class Imperium
{
    public Dictionary<string, ImperiumSector> SectorsList = new Dictionary<string, ImperiumSector>();
    public Dictionary<string, BaseModifier> ImperiumModifiersList = new Dictionary<string, BaseModifier>();

}

public class ImperiumSector
{
    public Dictionary<string, ImperiumPlanet> PlanetsList = new Dictionary<string, ImperiumPlanet>();
    public Dictionary<string, BaseModifier> SectorModifiersList = new Dictionary<string, BaseModifier>();
    public string name;
    public Imperium owner;
}

public class PlanetBiomeType
{
    public string name;
    public string description;
}

public class PlanetGravityType
{
    public string name;
    public string value;
    public string description;
}

public class PlanetSizeType
{
    public string name;
    public int minZoneCount;
    public int maxZoneCount;
    public string description;
    public int minGravityCount;
    public int maxGravityCount;
}

public class MapPlanet
{
    public Dictionary<string, PlanetZone> PlanetZonesList = new Dictionary<string, PlanetZone>();
    public Vector2 position;
    public string name;
    public PlanetBiomeType biomType;
    public PlanetGravityType gravityType;
    public PlanetSizeType sizeType;
}


public class ImperiumPlanet: MapPlanet
{
    public Imperium planetOwner;
    public Dictionary<string, BaseModifier> PlanetZoneModifiersList = new Dictionary<string, BaseModifier>();
    public Dictionary<string, LocalPlanetaryProject> LocalPlanetaryProjectsList = new Dictionary<string, LocalPlanetaryProject>();
    public int planetInfrastructureLevel;

    public float production;




    public float science;
    public float supply;
    public float income;

}

public class PlanetZone
{
    public BaseModifier zoneModifier;
    public string name;
    public Vector2 position;
    public float minerals;
    public float science;
    public float income;
    public float supply;
    public float defence;
    public Imperium owner;

}

public class Fleet
{

}

public class ShipClass
{
    public string name;
    public string size;
    public float weaponWeight;
    public float defenceWeight;
    public float ftlPropulsionWeight;
    public float manuveringWeight;
    public float supplyWeight;
    public float sensorWeight;
    public float specialWeight;
    public Dictionary<string, BaseModifier> ShipClassModifiersList = new Dictionary<string, BaseModifier>();
}


public class ShipConstruction
{
    public string name;
    public ShipClass shipClass;
    public float constructionHP;
    public float constructionShield;
    public float constructionArmor;
    public float weaponWeightAdd;
    public float defenceWeightAdd;
    public float ftlPropulsionWeightAdd;
    public float manuveringWeightAdd;
    public float supplyWeightAdd;
    public float sensorWeightAdd;
    public float specialWeightAdd;
    public Dictionary<string, BaseModifier> ConstructionModifiersList = new Dictionary<string, BaseModifier>();
}

public class ShipType
{
    public float baseHP;
    public float baseShield;
    public float baseArmor;
    public float manufacturingCost;
    public float baseMaintanceProductionCost;
    public float baseMaintanceIncomeCost;
    public float baseMaintanceScienceCost;
    public float baseFTLSpeed;
    public float baseManuverSpeed;
    public ShipConstruction construction;
    public Dictionary<string, ShipWeaponModule> WeaponsList = new Dictionary<string, ShipWeaponModule>();
    public Dictionary<string, ShipDefenceModule> DefenceList = new Dictionary<string, ShipDefenceModule>();
    public Dictionary<string, ShipFTLPropulsionModule> FTLPropulsionsList = new Dictionary<string, ShipFTLPropulsionModule>();
    public Dictionary<string, ShipManuveringModule> ManuveringsList = new Dictionary<string, ShipManuveringModule>();
    public Dictionary<string, ShipSupplyModule> SupplysList = new Dictionary<string, ShipSupplyModule>();
    public Dictionary<string, ShipSensorModule> SensorsList = new Dictionary<string, ShipSensorModule>();
    public Dictionary<string, ShipSpecialModule> SpecialsList = new Dictionary<string, ShipSpecialModule>();


}

public class Ship: ShipType 
{

    public float currentHP;
    public float currentShield;
    public float currentArmor;
    public float currentMaintanceProductionCost;
    public float currentMaintanceIncomeCost;
    public float currentMaintanceScienceCost;
    public float currentMovementLeft;
}

public class ShipWeaponModule
{
    public string name;
    public string type;
    public float value;
    public float weight;
}

public class ShipDefenceModule
{
    public string name;
    public string type;
    public float value;
    public float weight;
}

public class ShipFTLPropulsionModule
{
    public string name;
    public float value;
    public float weight;
    public float weightThreshhold;
}

public class ShipManuveringModule
{
    public string name;
    public float value;
    public float weight;
    public float weightThreshhold;
}

public class ShipSupplyModule
{
    public string name;
    public float value;
    public float weight;
    public float weightThreshhold;
}

public class ShipSensorModule
{
    public string name;
    public float sensorPower;
    public float antiStealthPower;
    public float weight;

}

public class ShipSpecialModule
{
    public string name;
    public BaseModifier shipSpecialSystemModifier;
    public float weight;
}
