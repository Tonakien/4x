using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class MapPlanet
{
    public List<PlanetZone> PlanetZonesList = new List<PlanetZone>();
    public Vector2 position;
    public string name;
    public PlanetBiomeType biomType;
    public PlanetGravityType gravityType;
    public PlanetSizeType sizeType;
}