using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour { 
    public Character[] characters;
    public Transform spot;
    public GameObject playerChosen;
    private List<GameObject> chars;
    private int currentIndex;

    // Start is called before the first frame update
    void Start()
    {
        chars = new List<GameObject>();

        foreach(var character in characters)
        {
            GameObject go = Instantiate(character.chooseScreenPrefab, spot.position, Quaternion.identity,spot);
            go.SetActive(false);
            chars.Add(go);
        }
        ShowCharacterFromList();
    }
    void ShowCharacterFromList()
    {
        chars[currentIndex].SetActive(true);
    }
    // Update is called once per frame
    public void OnClickPrevious()
    {
        chars[currentIndex].SetActive(false);
        if (currentIndex == 0)
        {
            currentIndex = chars.Count - 1;
        }
        else
        {
            currentIndex--;
        }
        ShowCharacterFromList();
    }
    public void OnClickNext()
    {
        chars[currentIndex].SetActive(false);
        if(currentIndex < chars.Count - 1)
        {
            ++currentIndex;
        }
        else
        {
            currentIndex = 0;
        }
        ShowCharacterFromList();
    }
    public void Play()
    {
        PlayerPrefs.SetInt("selectedCharacter", currentIndex);
        SceneManager.LoadScene(1);
        
    }
}
