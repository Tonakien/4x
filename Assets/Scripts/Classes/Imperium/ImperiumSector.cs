using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ImperiumSector
{
    public Dictionary<string, Colony> PlanetsList = new Dictionary<string, Colony>();
    public List<BaseModifier> SectorModifiersList;
    public string name;
    public Imperium owner;
    public ImperiumHero heroManager;
    public List<Fleet> FleetsList;
}