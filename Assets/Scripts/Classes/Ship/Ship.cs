using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class Ship : ShipProject
{

    public float currentHP;
    public float currentShield;
    public float currentArmor;
    public float currentMaintanceProductionCost;
    public float currentMaintanceIncomeCost;
    public float currentMaintanceScienceCost;
    public float currentMovementLeft;
}