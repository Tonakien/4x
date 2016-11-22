using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class Imperium
{
    public string id;
    public string name;
    public Dictionary<string, ImperiumSector> SectorsList = new Dictionary<string, ImperiumSector>();
    public List<BaseModifier> ImperiumModifiersList;
    public ImperiumHero heroRuler;
    public List<Hero> HeroesPull;
    public enum playingType
    {
        Player,
        AI
    }
    public playingType playerType;
}