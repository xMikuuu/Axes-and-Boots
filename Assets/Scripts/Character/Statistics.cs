using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Statistics
{
    [SerializeField] int strength; // bonus dmg from two-hand weapons (axes and 2-H swords) / resistance to warrior attacks
    [SerializeField] int agility; // bonus dmg from bows and swords / resistance to ranger attacks
    [SerializeField] int intelligence; // bonus dmg from spells and new spells / resistance to mage attacks
    [SerializeField] int vitality; // bonus health
    [SerializeField] int charisma; // gold bonus
    [SerializeField] int wisdom; // exp bonus
}
