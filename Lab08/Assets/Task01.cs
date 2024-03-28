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

    Queue LoginQueue = new Queue();
    void Start()
    {
        for (int i = 0; i < Names.Length; ++i)
        {
            int xcount = Random.Range(0, 25);
            Names[i] += Letters[xcount];
            
        }
        Debug.Log("Initial login queue created. ");

        for(int i = 0; i < Names.Length; ++i)
        {
            string nameHolder;
            nameHolder = Names[i];
            StartCoroutine(JoinQueue(nameHolder));
            Debug.Log("There are " + LoginQueue.Count + " player(s) in the queue: ");
            nameHolder = (string)LoginQueue.Dequeue();
            StartCoroutine(PrintLogin(nameHolder));
        }
    }

    IEnumerator JoinQueue(string x)
    {
        LoginQueue.Enqueue(x);
        Debug.Log(x + " is trying to login and added to the login queue");
        yield return new WaitForSeconds(2f);
    }

    IEnumerator PrintLogin(string x)
    {
        Debug.Log(x + " is now inside the game.");
        yield return new WaitForSeconds(8f);
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
  
