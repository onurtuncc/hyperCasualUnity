using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityManagement : MonoBehaviour
{
    public Ability[] abilities;
    public Button[] buttons;
    public Animator anim;
    public float checkPointZ=25f;
    public Transform player;
    public Boss boss;
    int buttonIndex=0;
    bool alreadyInCheckPoint = true;
    private void Awake()
    {
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        
        foreach(Button b in buttons)
        {
            b.gameObject.SetActive(false);
            b.interactable = false;
        }
    }
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        if (player.position.z >= checkPointZ && alreadyInCheckPoint)
        {
            BossFight();
        }
    }

    public void Collected(int i)
    {
        int c = buttonIndex;
        buttons[buttonIndex].GetComponent<Image>().sprite = abilities[i].sprite;
        buttons[buttonIndex].gameObject.SetActive(true);
        buttons[buttonIndex].onClick.AddListener(delegate { DoDamage(abilities[i].damage,c);
        });
        buttonIndex++;
        
    }
    void DoDamage(int damage,int a)
    {
        if (a == 0)
        {
            anim.SetTrigger("punchTrigger");
        }
        if (a == 1)
        {
            anim.SetTrigger("kickTrigger");
        }
        //Doing damage to the boss
        boss.TakeDamage(damage);
        buttons[a].gameObject.SetActive(false);
        
        
    }
    void BossFight()
    {
        foreach(Button b in buttons)
        {
            b.interactable = true;
            player.gameObject.GetComponent<Movement>().BossFightState();
        }
       
    }

    
    
    
}
