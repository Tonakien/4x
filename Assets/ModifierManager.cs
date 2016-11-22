using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ModifierManager : MonoBehaviour
{
    private List<BaseModifier> PlusModifiersList;
    private List<BaseModifier> MinusModifiersList;
    private List<BaseModifier> MultiplyModifiersList;
    private List<BaseModifier> DivideModifiersList;

    public void UpdatePlanetByModifier(Colony colony) // обработка модификаторов планет
    {
        PlusModifiersList.Clear();
        MinusModifiersList.Clear();
        MultiplyModifiersList.Clear();
        DivideModifiersList.Clear();

        //сбор модификаторов со строений на планете если они активны
        foreach (var project in colony.ColonyProjectsList)
        {
            if (project.state == "ACTIVE")
            {
                foreach (var modifier in project.projectModifiersList)
                {
                    StoreModifiersByType("PLANET", modifier);
                }
            }
        }

        // сбор модификаторов с сектора
        foreach (var modifier in colony.parentSector.SectorModifiersList)
        {
            StoreModifiersByType("PLANET", modifier);
        }

        //сбор модификаторов с империи
        foreach (var modifier in colony.planetOwner.ImperiumModifiersList)
        {
            StoreModifiersByType("PLANET", modifier);
        }

        // сбор модификаторов с героя сектора
        foreach (var ability in colony.parentSector.heroManager.AbilitiesList)
        {
            StoreModifiersByType("PLANET", ability.abilityModifier);
        }
        
        // сбор модификаторов с империи
        foreach (var modifier in colony.planetOwner.ImperiumModifiersList)
        {
            StoreModifiersByType("PLANET", modifier);
        }

        // сбор модификаторов с героя империи
        foreach (var ability in colony.planetOwner.heroRuler.AbilitiesList)
        {
            StoreModifiersByType("PLANET", ability.abilityModifier);
        }

        ApplyColonyModifiers(colony, PlusModifiersList);
        ApplyColonyModifiers(colony, MinusModifiersList);
        ApplyColonyModifiers(colony, MultiplyModifiersList);
        ApplyColonyModifiers(colony, DivideModifiersList);

    }

    // Если мофификатор подходящего типа (планета, сектор и т.д.) то сохранить его
    private void StoreModifiersByType(string applyType, BaseModifier modifier)
    {
        if (applyType == modifier.applyType)
        {

         if (modifier.type == "+")
         {
             PlusModifiersList.Add(modifier);
         }
         if (modifier.type == "-")
         {
             MinusModifiersList.Add(modifier);
         }
         if (modifier.type == "*")
         {
             MultiplyModifiersList.Add(modifier);
         }
         if (modifier.type == "/")
         {
             DivideModifiersList.Add(modifier);
         }
        }
    }

    // Расчеты согласно особому типу эффекта. Кладем лист модификаторов что бы иметь возможность проходить применение эффектов в определенном порядке. Т.е. сначала плюсы, потом минусы и т.д.
    private void ApplyColonyModifiers(Colony colony, List<BaseModifier> modifiers)
    {
        foreach (var modifier in modifiers)
        {
            if (modifier.effectType == "PRODUCTION_BY_POPULATION")
            {
                MultyplyByType(modifier.type, colony.production, colony.population, modifier.effectValue);
            }
            if (modifier.effectType == "SCIENCE_BY_POPULATION")
            {
                MultyplyByType(modifier.type, colony.science, colony.population, modifier.effectValue);
            }

            if (modifier.effectType == "SUPPLY_BY_POPULATION")
            {
                MultyplyByType(modifier.type, colony.supply, colony.population, modifier.effectValue);
            }

            if (modifier.effectType == "INCOME_BY_POPULATION")
            {
                MultyplyByType(modifier.type, colony.income, colony.population, modifier.effectValue);
            }
        }
        
    }

    private void MultyplyByType(string type, float result, float variable1, float variable2)
    {
        if (type == "+")
        {
            result += variable1 * variable2;
        }

        if (type == "-")
        {
            result -= variable1 * variable2;
        }

        if (type == "*")
        {
            result *= variable1 * variable2;
        }

        if (type == "/")
        {
            result /= variable1 * variable2;
        }
    }



}







//if (modifier.applyType == "PLANET")
//           {
//               if (modifier.effectType == "PRODUCTION_BY_POPULATION")
//                   {
//                       CalculateMultyply(modifier.type, planet.production, planet.population, modifier.effectValue);
//                   }
//
//                   if (modifier.effectType == "SCIENCE_BY_POPULATION")
//                   {
//                       CalculateMultyply(modifier.type, planet.science, planet.population, modifier.effectValue);
//                   }
//
//                   if (modifier.effectType == "SUPPLY_BY_POPULATION")
//                   {
//                       CalculateMultyply(modifier.type, planet.supply, planet.population, modifier.effectValue);
//                   }
//
//                   if (modifier.effectType == "INCOME_BY_POPULATION")
//                   {
//                       CalculateMultyply(modifier.type, planet.supply, planet.population, modifier.effectValue);
//                   }
//
//       }