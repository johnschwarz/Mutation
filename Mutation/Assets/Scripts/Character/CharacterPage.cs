﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class CharacterPage : MonoBehaviour {


	UIControl ui;
	GameObject levelPanel;

	public GameObject Death;
	//stats
    int strength;
	int tempStrength;
	int oldStrength;
	int currentHP; 
	int maxHP;
	
	int energy;
	int tempEnergy;
	int oldEnergy;  
	int maxEnergy;
	int currentEnergy;

	int currentExpPoints;
	int currentLevel;

	int speed;
	int tempSpeed;
    int oldSpeed;

	int accuracy;
	int tempAccuracy;
	int oldAccuracy;	

	int intelligence;
    int tempIntelligence;
    int oldIntelligence;
	
//	int increment = 0;
//	int currExpPoints;
//	int currtLevel ;
	int nextLevelExpPoints;
	
    Mutation head;
    Mutation body;
    Mutation leftArm;
    Mutation rightArm;
    Mutation leftLeg;
    Mutation rightLeg;

	UnityEngine.UI.Text currentHPText; 
    UnityEngine.UI.Text maxHPText;
    UnityEngine.UI.Slider healthSlider;

	UnityEngine.UI.Text currentEnergyText;
	UnityEngine.UI.Text maxEnergyText;
	UnityEngine.UI.Slider energySlider;
	UnityEngine.UI.Text nextLevelExpPointsText;

	UnityEngine.UI.Text expText;
	UnityEngine.UI.Text levelText;

	UnityEngine.UI.Text energyText;
    UnityEngine.UI.Text strengthText;
    UnityEngine.UI.Text speedText;
    UnityEngine.UI.Text intelligenceText;
	UnityEngine.UI.Text accuracyText;
    UnityEngine.UI.Text headText;
    UnityEngine.UI.Text bodyText;
    UnityEngine.UI.Text leftArmText;
    UnityEngine.UI.Text rightArmText;
    UnityEngine.UI.Text leftLegText;
    UnityEngine.UI.Text rightLegText;
    UnityEngine.UI.Text allocatablePointsText;

    int currentNumberOfAllocatablePoints = 5;
    int numberOfPointsPerLevel = 5;

	Item tempItem;
	public bool YouHaveDied ;


	public bool leveledUp;

	void Start () {
		//ui = GetComponent<UIControl>();
		//levelPanel = transform.FindChild("LevelUp").gameObject;
		//tempItem = new Daffodil();
		//tempItem.Init();
		//listOfItems.Add(tempItem);

		//tempItem = new Chloroform();
		//tempItem.Init();
		leveledUp = false;
		//listOfItems.Add(tempItem);
//		sample();
        //We'll want to have this customizeable, once character creation is in
		energy = 11;
		maxEnergy = 10 * energy;
		tempEnergy = energy;
		oldEnergy = 1;
		currentEnergy = maxEnergy;

		strength = 7;
		maxHP = 10 * strength;
		tempStrength = strength;
		oldStrength = 1;
		currentHP = maxHP;


		accuracy = 3;
		tempAccuracy = accuracy;
		oldAccuracy = 1;
		speed = 25;
		intelligence = 10;

		tempSpeed = speed;
		tempIntelligence = intelligence;

		oldSpeed = 1;
        oldIntelligence = 1;

        currentNumberOfAllocatablePoints = numberOfPointsPerLevel;
		currentExpPoints = 9;
		currentLevel = 1;

        head = ScriptableObject.CreateInstance<NoMutation>();
        head.Init();
        body = ScriptableObject.CreateInstance<NoMutation>();
        body.Init();
        leftArm = ScriptableObject.CreateInstance<NoMutation>();
        leftArm.Init();
        rightArm = ScriptableObject.CreateInstance<NoMutation>();
        rightArm.Init();
        leftLeg = ScriptableObject.CreateInstance<NoMutation>();
        leftLeg.Init();
        rightLeg = ScriptableObject.CreateInstance<NoMutation>();
        rightLeg.Init();

        currentHPText = GameObject.Find("HPCurrentText").GetComponent<UnityEngine.UI.Text>();
        maxHPText = GameObject.Find("HPMaxText").GetComponent<UnityEngine.UI.Text>();
        currentHPText.text = currentHP.ToString();
        maxHPText.text = maxHP.ToString();

        healthSlider = GameObject.Find("PlayerHealthSlider").GetComponent<UnityEngine.UI.Slider>();
		energySlider = GameObject.Find("PlayerEnergySlider").GetComponent<UnityEngine.UI.Slider>();
       
		currentEnergyText = GameObject.Find("EnergyCurrentText").GetComponent<UnityEngine.UI.Text>();
		maxEnergyText = GameObject.Find("EnergyMaxText").GetComponent<UnityEngine.UI.Text>();
		currentEnergyText.text = currentEnergy.ToString();
		maxEnergyText.text = maxEnergy.ToString();

		UpdateHealthMeter();
		UpdateEnergyMeter();

		levelText = GameObject.Find("LevelValueText").GetComponent<UnityEngine.UI.Text>();
		expText = GameObject.Find("ExpValueText").GetComponent<UnityEngine.UI.Text>();

		nextLevelExpPointsText = GameObject.Find("ExpToLevelValueText").GetComponent<UnityEngine.UI.Text>();

		accuracyText = GameObject.Find("AccuracyValueText").GetComponent<UnityEngine.UI.Text>();
		strengthText = GameObject.Find("StrengthValueText").GetComponent<UnityEngine.UI.Text>();
		energyText = GameObject.Find("EnergyValueText").GetComponent<UnityEngine.UI.Text>();
        speedText = GameObject.Find("SpeedValueText").GetComponent<UnityEngine.UI.Text>();
        intelligenceText = GameObject.Find("IntelligenceValueText").GetComponent<UnityEngine.UI.Text>();
        headText = GameObject.Find("HeadValueText").GetComponent<UnityEngine.UI.Text>();
        bodyText = GameObject.Find("BodyValueText").GetComponent<UnityEngine.UI.Text>();
        leftArmText = GameObject.Find("LeftArmValueText").GetComponent<UnityEngine.UI.Text>();
        rightArmText = GameObject.Find("RightArmValueText").GetComponent<UnityEngine.UI.Text>();
        leftLegText = GameObject.Find("LeftLegValueText").GetComponent<UnityEngine.UI.Text>();
        rightLegText = GameObject.Find("RightLegValueText").GetComponent<UnityEngine.UI.Text>();
        allocatablePointsText = GameObject.Find("AllocatablePointsValueText").GetComponent<UnityEngine.UI.Text>();

		nextLevelExpPointsText.text = nextLevelExpPoints.ToString();
		levelText.text = currentLevel.ToString();
		expText.text = currentExpPoints.ToString();
        strengthText.text = strength.ToString();
		energyText.text = energy.ToString();
		accuracyText.text = accuracy.ToString();
		//currentEnergyText.text = energy.ToString();

        speedText.text = speed.ToString();
        intelligenceText.text = intelligence.ToString();
        headText.text = head.GetName();
        bodyText.text = body.GetName();
        leftArmText.text = leftArm.GetName();
        rightArmText.text = rightArm.GetName();
        leftLegText.text = leftLeg.GetName();
        rightLegText.text = rightLeg.GetName();
        allocatablePointsText.text = currentNumberOfAllocatablePoints.ToString();
	}
//
//	public List<Item> returnList()
//	{
//		return listOfItems;
//	}
//
//	public List<Item> AddItemToList(Item item)
//	{
//		listOfItems.Add(item);
//		return listOfItems;
//	}
//
//
	bool IncreasedLevel = false;
	int previous= 0;



	public void AwareOfLevelUp()
	{
		leveledUp = false;
	}

	void LevelUp()
	{
		if(currentLevel > previous)
		{
			leveledUp = true;
			//Debug.Log("Level up");
			//ui.AddPanelOnTop(levelPanel);
			currentNumberOfAllocatablePoints += numberOfPointsPerLevel;
			allocatablePointsText.text = currentNumberOfAllocatablePoints.ToString();
			previous = currentLevel;
		}
	}
	public void UpdateExpPoints(int monsterExpPoints)
	{
		currentExpPoints += monsterExpPoints;
		currentLevel = (int)(Mathf.Sqrt(currentExpPoints) * 0.25) ;
		nextLevelExpPoints =  (int)((currentLevel+1)*(currentLevel+1)*16.0f); 

		levelText.text = currentLevel.ToString();
		expText.text = currentExpPoints.ToString();
		nextLevelExpPointsText.text = nextLevelExpPoints.ToString();

		LevelUp();
	}


	public int getPlayerAccuracy()
	{
		return accuracy;
	}

    void UpdateHealthMeter()
    {
        maxHPText.text = maxHP.ToString();
        healthSlider.maxValue = maxHP;
        currentHPText.text = currentHP.ToString();
        healthSlider.value = currentHP;
    }
	void UpdateEnergyMeter()
	{
		maxEnergyText.text = maxEnergy.ToString();
		energySlider.maxValue = maxEnergy;
		currentEnergyText.text = currentEnergy.ToString();
		energySlider.value = currentEnergy;
	}


    public void DoDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP <= 0)
        {
			Death.SetActive(true);

			//StartCoroutine("Death");

            //trigger death
        }
        UpdateHealthMeter();
    }

	public void RestartGame()
	{
		Application.LoadLevel(0);
	}


	public void DoEnergyDamage(int energyDamage)
	{
		currentEnergy -= energyDamage;
		if (currentEnergy <= 0)
		{
			Death.SetActive(true);
			Debug.Log("You died.");
			//trigger death
		}

		UpdateEnergyMeter();
	}

    public void HealDamage(int heal)
    {
        currentHP += heal;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
        currentHPText.text = currentHP.ToString();
		UpdateHealthMeter ();
    }

    public int AttackHead()
    {
        return head.RollHeadDamage() + strength;
    }

    public int AttackLeftArm()
    {
        return leftArm.RollArmDamage() + strength;
    }

    public int AttackRightArm()
    {
        return rightArm.RollArmDamage() + strength;
    }

    public int AttackLeftLeg()
    {
        return leftLeg.RollLegDamage() + strength;
    }

    public int AttackRightLeg()
    {
        return rightLeg.RollLegDamage() + strength;
    }
 
	public void IncreaseEnergy()
	{
		if (currentNumberOfAllocatablePoints > 0)
		{
			tempEnergy++;
			currentNumberOfAllocatablePoints--;
		}
		UpdateStats();
	}

    public void IncreaseStrength()
    {
        if (currentNumberOfAllocatablePoints > 0)
        {
            tempStrength++;
            currentNumberOfAllocatablePoints--;
        }
        UpdateStats();
    }

	public void IncreaseAccuracy()
	{
		if (currentNumberOfAllocatablePoints > 0)
		{
			tempAccuracy++;
			currentNumberOfAllocatablePoints--;
		}
		UpdateStats();
	}

	public void DecreaseAccuracy()
	{
		if (tempAccuracy > oldAccuracy)
		{
			tempAccuracy--;
			currentNumberOfAllocatablePoints++;
		}
		UpdateStats();
	}

	public void DecreaseEnergy()
	{
		if (tempEnergy > oldEnergy)
		{
			tempEnergy--;
			currentNumberOfAllocatablePoints++;
		}
		UpdateStats();
	}

    public void DecreaseStrength()
    {
        if (tempStrength > oldStrength)
        {
            tempStrength--;
            currentNumberOfAllocatablePoints++;
        }
        UpdateStats();
    }

    public void IncreaseSpeed()
    {
        if (currentNumberOfAllocatablePoints > 0)
        {
            tempSpeed++;
            currentNumberOfAllocatablePoints--;
        }
        UpdateStats();
    }

    public void DecreaseSpeed()
    {
        if (tempSpeed > oldSpeed)
        {
            tempSpeed--;
            currentNumberOfAllocatablePoints++;
        }
        UpdateStats();
    }

    public void IncreaseIntelligence()
    {
        if (currentNumberOfAllocatablePoints > 0)
        {
            tempIntelligence++;
            currentNumberOfAllocatablePoints--;
        }
        UpdateStats();
    }

    public void DecreaseIntelligence()
    {
        if (tempIntelligence > oldIntelligence)
        {
            tempIntelligence--;
            currentNumberOfAllocatablePoints++;
        }
        UpdateStats();
    }

    public void UpdateStats()
    {
        strengthText.text = tempStrength.ToString();
        speedText.text = tempSpeed.ToString();
        intelligenceText.text = tempIntelligence.ToString();
		accuracyText.text = tempAccuracy.ToString();
		energyText.text = tempEnergy.ToString();
        allocatablePointsText.text = currentNumberOfAllocatablePoints.ToString();
    }

    public void CommitPoints()
    {
        strength = tempStrength;

		accuracy = tempAccuracy;
		oldAccuracy = accuracy;

		energy = tempEnergy;
		oldEnergy = energy;

        speed = tempSpeed;
        intelligence = tempIntelligence;
        oldStrength = strength;
        oldSpeed = speed;
        oldIntelligence = intelligence;
        
		float energyRatio = (float)currentEnergy / maxEnergy;
		maxEnergy = energy * 10;
		currentEnergy = Mathf.RoundToInt(maxEnergy * energyRatio);

		float healthRatio = (float)currentHP / maxHP;
        maxHP = strength * 10;
        currentHP = Mathf.RoundToInt(maxHP * healthRatio);
        
		UpdateStats();
        UpdateHealthMeter();
		UpdateEnergyMeter();

    }

    public void ResetPoints()
    {
        int strengthDif = tempStrength - strength;
        int speedDif = tempSpeed - speed;
        int intelligenceDif = tempIntelligence - intelligence;

        currentNumberOfAllocatablePoints += strengthDif + speedDif + intelligenceDif;
        tempStrength = strength;
        tempSpeed = speed;
        tempIntelligence = intelligence;
        UpdateStats();
    }
	public int GetStrength()
	{
		return strength;
	}
	public void SetStrength(int offSet)
	{
		strength +=  offSet;
		tempStrength = strength;
		CommitPoints();
	}
	public int GetSpeed()
	{
		return speed;
	}
	public void SetSpeed(int offSet)
	{
		speed += offSet;
		tempSpeed = speed;
		CommitPoints();
	}
	public int GetAccuracy()
	{
		return accuracy;
	}
	public void SetAccuracy(int offSet)
	{
		accuracy += offSet;
		tempAccuracy = accuracy;
		CommitPoints();
	}
	public int GetIntelligence()
	{
		return intelligence;
	}
	public void SetIntelligence(int offSet)
	{
		intelligence += offSet;
		tempIntelligence = intelligence;
		CommitPoints();
	}
	public int GetEnergy()
	{
		return energy;
	}
	public void SetEnergy(int offSet)
	{
		energy += offSet;
		tempEnergy = energy;
		CommitPoints();
	}
	public int GetEnergyPoints()
	{
		return currentEnergy;
	}
	public void SetEnergyPoints(int offSet)
	{
		currentEnergy += offSet;
		if (currentEnergy>maxEnergy)
			currentEnergy=maxEnergy;
		CommitPoints();
	}

	public int GetHitPoints()
	{
		return currentHP;
	}
	public void SetHitPoints(int offSet)
	{
		currentHP += offSet;
		if (currentHP>maxHP)
			currentHP=maxHP;
		CommitPoints();
	}
}