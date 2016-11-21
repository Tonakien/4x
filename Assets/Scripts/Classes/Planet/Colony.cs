using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class Colony : MapPlanet
{
    public Imperium planetOwner;
    public ImperiumSector parentSector;
    public List<LocalColonyProject> ColonyProjectsList;

    public int planetInfrastructureLevel;
    public float population;
    public float production;
    public float science;
    public float supply;
    public float income;

}