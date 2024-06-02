using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatisticsDescription", menuName = "ScriptableObjects/StatsDescription", order = 1)]
public class StatsDescription : ScriptableObject
{
    [SerializeField] string strengthDescription;
    [SerializeField] string agilityDescription;
    [SerializeField] string intelligenceDescription;
    [SerializeField] string vitalityDescription;
    [SerializeField] string charismaDescription;
    [SerializeField] string wisdomDescription;

    public string StrengthDescription {  get { return strengthDescription; } }
    public string AgilityDescription { get { return agilityDescription; } } 
    public string IntelligenceDescription { get { return intelligenceDescription; } }
    public string VitalityDescription { get { return vitalityDescription; } }
    public string CharismaDescription { get { return charismaDescription; } }
    public string WisdomDescription { get { return wisdomDescription; } }
}
