using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnPlayer : MonoBehaviour
{
    public CameraControl cc;
    public GameObject[] characters;
    // Start is called before the first frame update
    void Awake()
    {
        

         GameObject clone=Instantiate(characters[PlayerPrefs.GetInt("selectedCharacter")],Vector3.zero,Quaternion.identity);
          cc.cube = clone;


    }

    
}
