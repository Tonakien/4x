using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;


public class Hero
{
    public string name;
    public string type;
    public Dictionary<string, HeroAbility> AbilitiessList = new Dictionary<string, HeroAbility>();
}

public class ImperiumHero: Hero
{
    public string position;
}

public class HeroAbility
{
    
}