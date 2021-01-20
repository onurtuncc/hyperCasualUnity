using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Ability")]
public class Ability : ScriptableObject
{
    public GameObject prefab;
    public int damage;
    public string abilityName;
    public Sprite sprite;

}
