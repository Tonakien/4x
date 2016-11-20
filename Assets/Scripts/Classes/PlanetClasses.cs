using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;


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


public class ImperiumPlanet : MapPlanet
{
    public Imperium planetOwner;
    public Dictionary<string, BaseModifier> PlanetZoneModifiersList = new Dictionary<string, BaseModifier>();
    public Dictionary<string, BaseModifier> PlanetImperiumModifiersList = new Dictionary<string, BaseModifier>();
    public Dictionary<string, LocalPlanetaryProject> LocalPlanetaryProjectsList = new Dictionary<string, LocalPlanetaryProject>();
    public int planetInfrastructureLevel;

    public float population;
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
