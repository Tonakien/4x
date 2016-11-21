using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ShipType
{
    public string name;
    public string size;
    public float shipTypeHP;
    public float shipTypeShield;
    public float shipTypeArmor;
    public float weaponWeightFromType;
    public float defenceWeightFromType;
    public float ftlPropulsionWeightFromType;
    public float manuveringWeightFromType;
    public float supplyWeightFromType;
    public float sensorWeightFromType;
    public float specialWeightFromType;
    public Dictionary<string, BaseModifier> ShipClassModifiersList = new Dictionary<string, BaseModifier>();
}