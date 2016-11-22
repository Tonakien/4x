using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class ShipProject
{
    public string shipProjectName;
    public float baseHP;
    public float baseShield;
    public float baseArmor;
    public float manufacturingCost;
    public float baseMaintanceProductionCost;
    public float baseMaintanceIncomeCost;
    public float baseMaintanceScienceCost;
    public float baseFTLSpeed;
    public float baseManuverSpeed;
    public ShipConstruction shipConstruction;
    public List<ShipWeaponModule> WeaponsList = new List<ShipWeaponModule>();
    public List<ShipDefenceModule> DefenceList = new List<ShipDefenceModule>();
    public List<ShipFTLPropulsionModule> FTLPropulsionsList = new List<ShipFTLPropulsionModule>();
    public List<ShipManuveringModule> ManuveringsList = new List<ShipManuveringModule>();
    public List<ShipSupplyModule> SupplysList = new List<ShipSupplyModule>();
    public List<ShipSensorModule> SensorsList = new List<ShipSensorModule>();
    public List<ShipSpecialModule> SpecialsList = new List<ShipSpecialModule>();
}