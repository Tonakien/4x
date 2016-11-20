using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;


public class BaseModifier
{
    public string name;
    public string applyType; // к чему применяется этот модификатор. Планета, империя и т.д.
    public string type; // тип модификатора. Добавить/Отнять/Умножить/Разделить
    public string effectType; // специальный тип эффекта. Например ADD_PRODUCTION_BY_POPULATION
    public float effectValue; // значение которое будет применено
}






