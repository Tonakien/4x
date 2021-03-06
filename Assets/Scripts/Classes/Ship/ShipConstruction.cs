﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class ShipConstruction
{
    public string name;
    public ShipType shipType;
    public float constructionHP;
    public float constructionShield;
    public float constructionArmor;
    public float weaponWeightFromConstruction;
    public float defenceWeightFromConstruction;
    public float ftlPropulsionWeightFromConstruction;
    public float manuveringWeightFromConstruction;
    public float supplyWeightFromConstruction;
    public float sensorWeightFromConstruction;
    public float specialWeightFromConstruction;
    public List<BaseModifier> ConstructionModifiersList = new List<BaseModifier>();
}