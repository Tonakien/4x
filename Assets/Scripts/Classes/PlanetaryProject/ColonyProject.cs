using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class ColonyProject
{
    public string name;
    public int infrastructureLevelNeed;
    public float baseProductionCost;
    public float baseScienceCost;
    public float baseIncomeCost;
    public float baseUpkeepProduction;
    public float baseUpkeepScience;
    public float baseUpkeepSupply;
    public float baseUpkeepIncome;
    public float startThreshold;
    public List<BaseModifier> projectModifiersList = new List<BaseModifier>();

}