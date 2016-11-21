using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class Imperium
{
    public Dictionary<string, ImperiumSector> SectorsList = new Dictionary<string, ImperiumSector>();
    public List<BaseModifier> ImperiumModifiersList;
    public ImperiumHero heroRuler;
}