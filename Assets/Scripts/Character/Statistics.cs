using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Statistics
{
    [SerializeField] int strength; // bonus dmg from two-hand weapons (axes and 2-H swords) / resistance to warrior attacks
    public int Strength {  get { return strength; }}

    [SerializeField] int agility; // bonus dmg from bows and swords / resistance to ranger attacks
    public int Agility { get { return agility; }}

    [SerializeField] int intelligence; // bonus dmg from spells and new spells / resistance to mage attacks
    public int Intelligence { get {  return intelligence; }}

    [SerializeField] int vitality; // bonus health
    public int Vitality { get {  return vitality; }}

    [SerializeField] int charisma; // gold bonus
    public int Charisma { get {  return charisma; }}
    
    [SerializeField] int wisdom; // exp bonus
    public int Wisdom { get {  return wisdom; }}
}
