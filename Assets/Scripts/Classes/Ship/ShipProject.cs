using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

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
    public Dictionary<string, ShipWeaponModule> WeaponsList = new Dictionary<string, ShipWeaponModule>();
    public Dictionary<string, ShipDefenceModule> DefenceList = new Dictionary<string, ShipDefenceModule>();
    public Dictionary<string, ShipFTLPropulsionModule> FTLPropulsionsList = new Dictionary<string, ShipFTLPropulsionModule>();
    public Dictionary<string, ShipManuveringModule> ManuveringsList = new Dictionary<string, ShipManuveringModule>();
    public Dictionary<string, ShipSupplyModule> SupplysList = new Dictionary<string, ShipSupplyModule>();
    public Dictionary<string, ShipSensorModule> SensorsList = new Dictionary<string, ShipSensorModule>();
    public Dictionary<string, ShipSpecialModule> SpecialsList = new Dictionary<string, ShipSpecialModule>();
}