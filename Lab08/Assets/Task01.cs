using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task01 : MonoBehaviour
{
    public string[] Names = {"Tom", "Afred", "Freddy", "Frederick", "Leon", "Greg", "Bob", "Billy", "Sherlock", "Watson", "Emilia", "Jerry", "Faye",
        "James", "Richard", "Pam", "Peter", "Sakina", "Bianka", "Yevdokiya" };
    public string[] Letters = { " A", " B", " C", " D", " E", " F", " G", " H", " I", " J", " K", " L", " M", " N", " O", " P", " Q", " R", " S", " T", " U", " V", " W", " X", " Y", " Z" };
    private int x = 0;
    
    // Start is called before the first frame update

    Queue LoginQueue = new Queue();
    private string nameHolder;
    void Start()
    {
        Debug.Log("Initial login queue created.");
        for (int i = 0; i < Names.Length; ++i)
        {
            int xcount = Random.Range(0, 25);
            Names[i] += Letters[xcount];
        }

        for (int i = 0; i < Names.Length; ++i)
        {
            int joinTime = Random.Range(1, 4);
            int randomDequeueTime = Random.Range(1, 6);
            Invoke("JoinQueue", joinTime);
            Invoke("PrintLogin", randomDequeueTime);
        }
    }

    void JoinQueue()
    {
        LoginQueue.Enqueue(Names[x]);
        nameHolder = Names[x];
        ++x;
            Debug.Log(nameHolder + " is trying to login and added to the login queue");
    }

    void PrintLogin()
    {
        Debug.Log("There are " + LoginQueue.Count + " player(s) in the queue: ");
        nameHolder = (string)LoginQueue.Dequeue();
        Debug.Log(nameHolder + " is now inside the game.");

    }
}