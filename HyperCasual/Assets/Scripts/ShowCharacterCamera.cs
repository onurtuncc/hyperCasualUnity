using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCharacterCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform character;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(character);
        transform.Translate(Vector3.right * 7 * Time.deltaTime);
    }
}
