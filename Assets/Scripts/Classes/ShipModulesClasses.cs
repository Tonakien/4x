using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ShipWeaponModule
{
    public string name;
    public string type;
    public float value;
    public float weight;
}

public class ShipDefenceModule
{
    public string name;
    public string type;
    public float value;
    public float weight;
}

public class ShipFTLPropulsionModule
{
    public string name;
    public float value;
    public float weight;
    public float weightThreshhold;
}

public class ShipManuveringModule
{
    public string name;
    public float value;
    public float weight;
    public float weightThreshhold;
}

public class ShipSupplyModule
{
    public string name;
    public float value;
    public float weight;
    public float weightThreshhold;
}

public class ShipSensorModule
{
    public string name;
    public float sensorPower;
    public float antiStealthPower;
    public float weight;

}

public class ShipSpecialModule
{
    public string name;
    public BaseModifier shipSpecialSystemModifier;
    public float weight;
}
