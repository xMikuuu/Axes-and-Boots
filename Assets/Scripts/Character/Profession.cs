using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ProfessionScriptableObject", menuName = "ScriptableObjects/Profession", order = 0)]

public class Profession : ScriptableObject
{
    [SerializeField] string professionName;
    [SerializeField] Statistics starterStatistics;
}
