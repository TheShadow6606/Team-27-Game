using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInfo : MonoBehaviour
{
    public Transform[] characterSpawns;
    public Hand hand;
    public GameObject healthBar1, healthBar2, energyBar1, energyBar2;
    public GameObject winScreen, LoseScreen;
    
    public static PlayerInfo instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else
        {
            if (instance != null && instance != this)
            {
                Destroy(this.gameObject);
                instance = this;
            }
        }
    }
}
