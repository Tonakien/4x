using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class PlanetZone
{
    public BaseModifier zoneModifier;
    public string name;
    public Vector2 position;
    public float minerals;
    public float science;
    public float income;
    public float supply;
    public float defence;
    public Imperium owner;

}