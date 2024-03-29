using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task01 : MonoBehaviour
{
    private string[] Names = {"Tom", "Afred", "Freddy", "Frederick", "Leon", "Greg", "Bob", "Billy", "Sherlock", "Watson", "Emilia", "Jerry", "Faye",
        "James", "Richard", "Pam", "Peter", "Sakina", "Bianka", "Yevdokiya" };
    //Last name initials
    private string[] Letters = { " A", " B", " C", " D", " E", " F", " G", " H", " I", " J", " K", " L", " M", " N", " O", " P", " Q", " R", " S", " T", " U", " V", " W", " X", " Y", " Z" };

    //since Invoke can't use parameters, this int is used to track and make sure the array index doesn't go out of bounds
    private int x = 0;
    
    // Start is called before the first frame update

    Queue LoginQueue = new Queue();
    private string nameHolder;
    void Start()
    {
        //assign last name initials to names
        Debug.Log("Initial login queue created.");
        for (int i = 0; i < Names.Length; ++i)
        {
            int xcount = Random.Range(0, 25);
            Names[i] += Letters[xcount];
        }

        //random range used to simulate realistic joining
        for (int i = 0; i < Names.Length; ++i)
        {
            int joinTime = Random.Range(1, 4);
            int randomDequeueTime = Random.Range(1, 6);
            Invoke("JoinQueue", joinTime);
            Invoke("PrintLogin", randomDequeueTime);
        }

        //Because of the random timings, the current playercount may not be displayed after all the logins
        //This will call a method that shows that the queue is truly empty after 10 seconds (Which should be enough for all the calculations to be done by then)
        Invoke("DisplayPlayerCount", 10f);
    }

    void DisplayPlayerCount()
    {
        Debug.Log("There are " + LoginQueue.Count + " player(s) in the queue");
    }

    //uses int x to queue the Names string[], nameholder used to prevent any misnamings displayed
    void JoinQueue()
    {
        LoginQueue.Enqueue(Names[x]);
        nameHolder = Names[x];
        ++x;
            Debug.Log(nameHolder + " is trying to login and added to the login queue");
    }

    //Shows queue, dequeues and assigns dequeued name to nameholder to display in debug log
    void PrintLogin()
    {
        Debug.Log("There are " + LoginQueue.Count + " player(s) in the queue");
        nameHolder = (string)LoginQueue.Dequeue();
        Debug.Log(nameHolder + " is now inside the game.");

    }
}