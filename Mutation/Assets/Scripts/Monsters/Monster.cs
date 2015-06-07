﻿using UnityEngine;
using System.Collections;

public class Monster : ScriptableObject {
    protected string monsterName;
    protected int strength;
    protected int speed;
    protected int intelligence;
    protected int currentHP;
    protected int maxHP;

    protected int headMinDamage;
    protected int headMaxDamage;
    protected int armMinDamage;
    protected int armMaxDamage;
    protected int legMinDamage;
    protected int legMaxDamage;
    protected int bonusDamage;
	protected int expPointsGained;
	protected string monsterDescription;
	protected string hideDescription;

	public virtual void Start()
	{
	}
	public virtual void Init()
    {
        currentHP = 10 * strength;
        maxHP = currentHP;
	}

	public string GetHideDescription()
	{
		return hideDescription;
	}

	public string GetDescription()
	{
		return monsterDescription;
	}

    public string GetName()
    {
        return monsterName;
    }

    public int GetMaxHealth()
    {
        return maxHP;
    }

    public int GetHealth()
    {
        return currentHP;
    }

	public int GetExpPointsGained()
	{
		return expPointsGained;
	}

    public bool DoDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP <= 0)
        {
            return true;
        }
        return false;
    }



    public void HealDamage(int heal)
    {
        currentHP += heal;
        if (currentHP >= maxHP)
        {
            currentHP = maxHP;
        }
    }



    public int RollHeadDamage()
    {
        return RollDamage(headMinDamage, headMaxDamage);


    }

    public int RollArmDamage()
    {
        return RollDamage(armMinDamage, armMaxDamage);
    }

    public int RollLegDamage()
    {
        return RollDamage(legMinDamage, legMaxDamage);
    }

    int RollDamage(int minDamage, int maxDamage)
    {
        int baseDamage = Random.Range(minDamage, maxDamage);
        baseDamage += bonusDamage;
        return baseDamage;
    }

    public int GetSpeed()
    {
        return speed;
    }
}
