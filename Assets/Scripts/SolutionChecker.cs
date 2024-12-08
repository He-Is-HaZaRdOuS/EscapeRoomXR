using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionChecker : MonoBehaviour
{
    //declare bool array of 5 elements
    public bool[] solution = new bool[5];
    public GameObject button;

    public void Start()
    {
        //initialize all elements of the array to false
        for (int i = 0; i < solution.Length; i++)
        {
            solution[i] = false;
        }
    }

    public void inputSolution(int index)
    {
        //if the element at the index is false, set it to true
        if (solution[index] == false)
        {
            solution[index] = true;
        }
        spawnButton();
    }

    public void spawnButton()
    {
        //if all elements of the array are true, spawn the button
        for (int i = 0; i < solution.Length; i++)
        {
            if (solution[i] == false)
            {
                return;
            }
        }
        button.SetActive(true);
    }
}
