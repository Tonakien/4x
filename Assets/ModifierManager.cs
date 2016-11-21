using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class ModifierManager : MonoBehaviour
{
        public void UpdatePlanetByModifier(Colony planet, BaseModifier modifier) // обработка модификаторов планет
        {
            if (modifier.effectType == "PLANET_PRODUCTION_BY_POPULATION" && modifier.applyType == "PLANET")
            {
                CalculateMultyply(modifier.type, planet.production, planet.population, modifier.effectValue);
            }

            if (modifier.effectType == "PLANET_SCIENCE_BY_POPULATION" && modifier.applyType == "PLANET")
            {
                CalculateMultyply(modifier.type, planet.science, planet.population, modifier.effectValue);
            }

            if (modifier.effectType == "PLANET_SUPPLY_BY_POPULATION" && modifier.applyType == "PLANET")
            {
                CalculateMultyply(modifier.type, planet.supply, planet.population, modifier.effectValue);
            }

            if (modifier.effectType == "PLANET_INCOME_BY_POPULATION" && modifier.applyType == "PLANET")
            {
                CalculateMultyply(modifier.type, planet.supply, planet.population, modifier.effectValue);
            }

        }

        private void CalculateMultyply(string statement, float variable1, float variable2, float variable3)
        {
            if (statement == "+")
            {
                variable1 += variable2 * variable3;
            }

            if (statement == "*")
            {
                variable1 *= variable2 * variable3;
            }

            if (statement == "-")
            {
                variable1 -= variable2 * variable3;
            }

            if (statement == "/")
            {
                variable1 /= variable2 * variable3;
            }
        }
    }
