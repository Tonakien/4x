﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class ShipManuveringModule: ShipModule
{
    public float value;
    public float weightThreshhold;
    public ShipType installType;
}