using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class TacticGroup
{
    public string name;
    public List<Ship> ShipList = new List<Ship>();
    public string defenceAction;
    public string offenceAction;
    public string moveAction;
}
