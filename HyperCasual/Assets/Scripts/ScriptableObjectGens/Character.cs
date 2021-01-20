using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName ="Character")]
public class Character : ScriptableObject
{
    public int health=100;
    public string nameOfCharacter = "Default";
    public Ability[] abilityList;
    public GameObject characterPrefab;
    public GameObject chooseScreenPrefab;
}
