using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class ShipFTLPropulsionModule: ShipModule
{
    public float value;
    public float weightThreshhold;
    public ShipType installType;
}