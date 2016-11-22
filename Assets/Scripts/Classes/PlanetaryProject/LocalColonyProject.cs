using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class LocalColonyProject : ColonyProject
{
    public Colony owner;
    public float currentCompleteness;
    public float currentUpkeepProduction;
    public float currentUpkeepScience;
    public float currentUpkeepSupply;
    public float currentUpkeepIncome;
    public string state;

}
