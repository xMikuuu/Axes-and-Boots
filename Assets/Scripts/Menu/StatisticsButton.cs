using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class StatisticsButton : MonoBehaviour
{
    [SerializeField] StatsDescription statisticsDescription;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Image textBackground;

    private void OnMouseOver()
    {
        ShowStats();
    }

    private void OnMouseExit()
    {
        textBackground.enabled = false;
        text.text = " ";
    }


    private void ShowStats()
    {
        textBackground.enabled = true;
        text.text = "<b>Strength</b> - " + statisticsDescription.StrengthDescription;
        text.text += "\n<b>Agility</b> - " + statisticsDescription.AgilityDescription;
        text.text += "\n<b>Intelligence</b> - " + statisticsDescription.IntelligenceDescription;
        text.text += "\n<b>Vitality</b> - " + statisticsDescription.VitalityDescription;
        text.text += "\n<b>Charisma</b> - " + statisticsDescription.CharismaDescription;
        text.text += "\n<b>Wisdom</b> - " + statisticsDescription.WisdomDescription;
    }
}
