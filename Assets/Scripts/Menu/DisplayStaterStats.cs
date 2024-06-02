using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayStaterStats : MonoBehaviour
{
    [SerializeField] Profession professionStarterStatistics;
    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        text.text = "Strength: " + professionStarterStatistics.starterStatistics.Strength;
        text.text += "\nAgility: " + professionStarterStatistics.starterStatistics.Agility;
        text.text += "\nIntelligence: " + professionStarterStatistics.starterStatistics.Intelligence;
        text.text += "\nVitality: " + professionStarterStatistics.starterStatistics.Vitality;
        text.text += "\nCharisma: " + professionStarterStatistics.starterStatistics.Charisma;
        text.text += "\nWisdom: " + professionStarterStatistics.starterStatistics.Wisdom;
    }
}
