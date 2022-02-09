using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Card : MonoBehaviour
{
    public string type;
    public int damage;
    int rndType;

    public Card()
    {
        generateCard();
    }

    public void Awake()
    {
       damage = Random.Range(500, 900);
       rndType = Random.Range(0, 4);
   }

    // Start is called before the first frame update
   void Start()
   {

   }

    // Update is called once per frame
   void Update()
   {

   }
    //create a card
   void generateCard()
   {

    if (rndType == 0) type = "attack";
    else if (rndType == 1) type = "counter";
    else if (rndType == 2) type = "dodge";
    else if (rndType == 3) type = "grapple";
    else if (rndType == 4) type = "heal";
}

}
