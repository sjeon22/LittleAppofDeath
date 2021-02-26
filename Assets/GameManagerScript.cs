using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public string fileName = "default.txt";
    public Text displayName; // makes a place for 'GameManageScript' to attach regenerated name to the text box in unity 

    private string[] studentNames;

    // Start is called before the first frame update
    void Start()
    {
        LoadStudentNames();
        ButtonClick(); // this will give a name when game starts
    }

    private void LoadStudentNames() // Load the file of student names
    {
        this.studentNames = File.ReadAllLines(fileName); // 'this' is referring to the object, something global and not local 
    }

    public void ButtonClick()
    {
        int i = UnityEngine.Random.Range(0, this.studentNames.Length); //25 = 0-24
        string name = this.studentNames[i]; // gives 'name' to int 'i'
        displayName.text = name; // print that random 'name'
    }
}
