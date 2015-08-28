﻿using UnityEngine;
using System.Collections;


public class SnakeMeat : Item {
	
	void Awake()
	{
		itemName = "Snake Meat";
		itemImage = "Enemies/Snake";
		strength = 0;
		speed = 0;
		intelligence = 0;
		energy = 0;
		accuracy = 0;
		energyHealed = 50;
		hitPointsHealed = 8;
//		count = 5;
		tag = 6;

		numberOfMutations = 4;
		
		mutationList = new Mutation[]{ScriptableObject.CreateInstance<FloppyEars> (),ScriptableObject.CreateInstance<Whiskers> (),
			ScriptableObject.CreateInstance<BushyTail> (), ScriptableObject.CreateInstance<RabbitLegs> (),};

	}
	
}