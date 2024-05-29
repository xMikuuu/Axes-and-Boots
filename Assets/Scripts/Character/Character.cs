using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    // protected: public for child classes
    [SerializeField] protected string characterName;
    public string CharacterName { get { return characterName; } }

    Statistics statistics;
    Profession profession;


}
