using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

public class Task02 : MonoBehaviour
{
    public string[] Names = {"Tom", "Afred", "Freddy", "Frederick", "Leon", "Greg", "Bob", "Billy", "Sherlock", "Watson", "Emilia", "Jerry", "Faye",
        "James", "Richard", "Pam", "Peter", "Sakina", "Bianka", "Yevdokiya" };
    
    public string[] randNames;
    HashSet<string> NamesHash = new HashSet<string>();
    HashSet<string> duplicatePlayers = new HashSet<string>();
    // Start is called before the first frame update
    void Start() {

        //Name array is created 
        AssignRandName(randNames, Names);
        DisplayArray(randNames);
        foreach (string name in randNames)
        {
            int i = 0;
            if (!NamesHash.Add(name))
            {
                duplicatePlayers.Add(name);
                /*Debug.Log(name);*/
            }
            /*i++;*/
        }

        foreach (string name in duplicatePlayers)
        {
            Debug.Log($"This array has duplicate names: {name}");
        }
        /*foreach (string name in NamesHash)
        {
            Debug.Log(name);
        }*/


    }
    void AssignRandName(string[] randNames, string[] Names) //assigns random names to the array
    {
        for (int i = 0; i < 15; i++)
        {
            int xcount = Random.Range(0, 19);
            randNames[i] = Names[xcount];
            /*Debug.Log(randNames[i]);*/
        }
    }
    void DisplayArray(string[] randNames) //Displays the names that are in the array
    {
        Debug.Log($"Created the name array: {randNames[0]}, {randNames[1]}, {randNames[2]}, {randNames[3]}, {randNames[4]}, {randNames[5]}, {randNames[6]}, {randNames[7]}," +
            $" {randNames[8]}, {randNames[9]}, {randNames[10]}, {randNames[11]}, {randNames[12]}, {randNames[13]}, {randNames[14]}");
    }
}
