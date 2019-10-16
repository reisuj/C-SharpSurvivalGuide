using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName = "Sword";
    public string description = "Long bladed weapon";
    public Sprite sprite;
    public int attStrength = 100;
    public int goldCost = 10;
    public int durability = 100;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(itemName + ": " + description);
        Debug.Log("Attack Strngth: " + attStrength);
        Debug.Log("Cost: " + goldCost);
        Debug.Log("Durability: " + durability);
    }

    
}
