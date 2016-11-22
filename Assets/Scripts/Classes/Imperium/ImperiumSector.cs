using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class ImperiumSector
{
    public List<Colony> PlanetsList = new List<Colony>();
    public List<BaseModifier> SectorModifiersList;
    public string name;
    public Imperium owner;
    public ImperiumHero heroManager;
    public List<Fleet> FleetsList;
}