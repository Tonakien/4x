using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class Imperium
{
    public Dictionary<string, ImperiumSector> SectorsList = new Dictionary<string, ImperiumSector>();
    public Dictionary<string, BaseModifier> ImperiumModifiersList = new Dictionary<string, BaseModifier>();
    public ImperiumHero heroRuler;
}

public class ImperiumSector
{
    public Dictionary<string, ImperiumPlanet> PlanetsList = new Dictionary<string, ImperiumPlanet>();
    public Dictionary<string, BaseModifier> SectorModifiersList = new Dictionary<string, BaseModifier>();
    public string name;
    public Imperium owner;
    public ImperiumHero heroManager;
}
