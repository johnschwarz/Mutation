﻿using UnityEngine;
using System.Collections;


public class CatMeat : Item {
	
	void Awake()
	{
		itemName = "Cat Meat";
		itemImage = "Enemies/Cat";
		strength = 0;
		speed = 0;
		intelligence = 0;
		energy = 0;
		accuracy = 0;
		energyHealed = 50;
		hitPointsHealed = 35;
		tag = 10;
		numberOfMutations = 4;
		
		mutationList = new Mutation[]{ScriptableObject.CreateInstance<FloppyEars>(),ScriptableObject.CreateInstance<Whiskers>(),
			ScriptableObject.CreateInstance<BushyTail>(), ScriptableObject.CreateInstance<RabbitLegs>(),
		};



	}
	
}