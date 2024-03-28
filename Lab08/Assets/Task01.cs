using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task01 : MonoBehaviour
{
    public string[] Names = {"Tom", "Afred", "Freddy", "Frederick", "Leon", "Greg", "Bob", "Billy", "Sherlock", "Watson", "Emilia", "Jerry", "Faye",
        "James", "Richard", "Pam", "Peter", "Sakina", "Bianka", "Yevdokiya" };
    public string[] Letters = { " A", " B", " C", " D", " E", " F", " G", " H", " I", " J", " K", " L", " M", " N", " O", " P", " Q", " R", " S", " T", " U", " V", " W", " X", " Y", " Z" };
    //Create a login simulator
    /*
        • A log-in simulator
        • Have a random name library (20-30 names) and match them with
    random letters to create players
            • Carol A., Adam Z., etc.
        • Create a collection of initial login queue
        • Create coroutines or invoke repeating:
            • Adds a random player to the queue
            • Logs in a player
        • Debug.Log all action
            • “Initial login queue created. There are 5 players in the queue:Carol A., ...”
            • “Carol A. is now inside the game.”
            • “Adam Z. is trying to login and added to the login queue
    */

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hello");
        for (int i = 0; i < Names.Length; ++i)
        {
            int xcount = Random.Range(0, 25);
            Names[i] += Letters[xcount];
            
        }
        Debug.Log("Initial login queue created. ");
    }

    // Update is called once per frame
    void Update()
    {
        Queue<string> LoginQueue = new Queue<string>();


    }
}
  
