﻿using UnityEngine;
using System.Collections;


public class BearMeat : Item {
	
	void Awake()
	{
		itemName = "Bear Meat";

		strength = 0;
		speed = -5;
		intelligence = -5;
		energy = 0;
		accuracy = -5;
		count = 1;
		tag = 4;
//		base.Init();
	}
	
}