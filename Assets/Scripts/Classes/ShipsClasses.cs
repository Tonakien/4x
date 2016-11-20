using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ShipClass
{
    public string name;
    public string size;
    public float weaponWeight;
    public float defenceWeight;
    public float ftlPropulsionWeight;
    public float manuveringWeight;
    public float supplyWeight;
    public float sensorWeight;
    public float specialWeight;
    public Dictionary<string, BaseModifier> ShipClassModifiersList = new Dictionary<string, BaseModifier>();
}


public class ShipConstruction
{
    public string name;
    public ShipClass shipClass;
    public float constructionHP;
    public float constructionShield;
    public float constructionArmor;
    public float weaponWeightAdd;
    public float defenceWeightAdd;
    public float ftlPropulsionWeightAdd;
    public float manuveringWeightAdd;
    public float supplyWeightAdd;
    public float sensorWeightAdd;
    public float specialWeightAdd;
    public Dictionary<string, BaseModifier> ConstructionModifiersList = new Dictionary<string, BaseModifier>();
}

public class ShipType
{
    public float baseHP;
    public float baseShield;
    public float baseArmor;
    public float manufacturingCost;
    public float baseMaintanceProductionCost;
    public float baseMaintanceIncomeCost;
    public float baseMaintanceScienceCost;
    public float baseFTLSpeed;
    public float baseManuverSpeed;
    public ShipConstruction construction;
    public Dictionary<string, ShipWeaponModule> WeaponsList = new Dictionary<string, ShipWeaponModule>();
    public Dictionary<string, ShipDefenceModule> DefenceList = new Dictionary<string, ShipDefenceModule>();
    public Dictionary<string, ShipFTLPropulsionModule> FTLPropulsionsList = new Dictionary<string, ShipFTLPropulsionModule>();
    public Dictionary<string, ShipManuveringModule> ManuveringsList = new Dictionary<string, ShipManuveringModule>();
    public Dictionary<string, ShipSupplyModule> SupplysList = new Dictionary<string, ShipSupplyModule>();
    public Dictionary<string, ShipSensorModule> SensorsList = new Dictionary<string, ShipSensorModule>();
    public Dictionary<string, ShipSpecialModule> SpecialsList = new Dictionary<string, ShipSpecialModule>();


}

public class Ship : ShipType
{

    public float currentHP;
    public float currentShield;
    public float currentArmor;
    public float currentMaintanceProductionCost;
    public float currentMaintanceIncomeCost;
    public float currentMaintanceScienceCost;
    public float currentMovementLeft;
}

