using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

[Serializable]
public class Hero
{
    public string name;
    public string type;
    public List<HeroAbility> AbilitiesList = new List<HeroAbility>();
}