using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class Imperium
{
    public string id;
    public string name;
    public List<ImperiumSector> SectorsList = new List<ImperiumSector>();
    public List<BaseModifier> ImperiumModifiersList = new List<BaseModifier>();
    public ImperiumHero heroRuler;
    public List<Hero> HeroesPull = new List<Hero>();
    public enum playingType
    {
        Player,
        AI
    }
    public playingType playerType;
}