﻿using UnityEngine;
using System.Collections;

public class FrogMonster : Monster {

	string[] monsterText = new string[5];
	

	
	public override void Start()
	{
		
		// index 0,1,2 are for encuontering the monster when you make the fight or hide choice
		monsterText[0] = "Two bugging eyes catch your attention. Lo and behold, a giant, green frog!\n\n";
		monsterText[1] = "Lost in thought, wondering among the foliage, you suddenly feel a wet thwat against your neck! What could it be! You turn to see: A slimy, green frog!\n\n";
		monsterText[2] = "The croaking of long off frogs fills your mind with tranquility. Suddenly a booming croak blasts right behind you. Before you know it, you are staring at a huge frog!\n\n";
		
		// index 3 is for hiding
		monsterText[3] = "You take a few step back and are suddenly very far from the frog.";

		monsterText[4] = "The frog collapses in exhaustion and defeat! You won!";
		droppedItemsList = new Item[]{ ScriptableObject.CreateInstance<Daffodil>(),ScriptableObject.CreateInstance<Chloroform>(),ScriptableObject.CreateInstance<RabbitMeat>()};
	}
	public override void Init()
	{
		
		monsterName = "Frog";
		expPointsGained = Random.Range(10 , 20);
		monsterDescription = monsterText[Random.Range(0,3)];
		hideDescription = monsterText[3];
		victoryText = monsterText[4];
		setMonsterImage(Resources.Load <Sprite>("Enemies/Bunny"));
		strength = Random.Range(1,3);
		speed = Random.Range(20, 40);
		intelligence = 5;
		energy = 10;
		
		itemReleased = droppedItemsList[Random.Range(0,3)];
		headMinDamage = 2;
		headMaxDamage = 4;
		armMinDamage = 1;
		armMaxDamage = 1;
		legMinDamage = 2;
		legMaxDamage = 4;
		bonusDamage = 0;
		
		base.Init();
	}
	
}