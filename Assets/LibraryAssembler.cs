using System.IO;
using SimpleJSON;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEditor;

public class LibraryAssembler : MonoBehaviour {

    private JSONNode JHeroesLib;
    public GameData gameData;
    public List<Hero> HeroesList = new List<Hero>();


    void Awake()
    {
        Hero hero = new Hero();
        HeroesList.Add(hero);
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
