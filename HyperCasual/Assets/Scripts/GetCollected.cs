using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCollected : MonoBehaviour
{
    public AbilityManagement ability;
    public int index;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            ability.Collected(index);
        }
    }
}
