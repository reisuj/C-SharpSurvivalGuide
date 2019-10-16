using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string myName = "Brian";
    public int myAge = 49;
    public float mySpeed = 18;
    public int myHealth = 18;
    public int score = 20;
    public float speed = 18;
    public bool areAllKeysCollected = false;
    public int ammo = 100;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + myName + " and I am " + myAge + " years old. I have a speed of " + mySpeed + " and my health is " + myHealth + ".");
        Debug.Log("My score is " + score + " and the speed of " + speed + ". I have " + ammo + " and my collected keys is " + areAllKeysCollected + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
