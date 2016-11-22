using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class Colony : MapPlanet
{
    public Imperium planetOwner;
    public ImperiumSector parentSector;
    public List<LocalColonyProject> ColonyProjectsList = new List<LocalColonyProject>();

    public int planetInfrastructureLevel;
    public float population;
    public float production;
    public float science;
    public float supply;
    public float income;

}