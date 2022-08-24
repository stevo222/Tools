using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;
    int myLives = 3;
    double myDoubleint = 200;
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        myLives = Health();
        Debug.Log(myInt);
    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
        
    }
    int Health()
    {
        int result;
        result = 3;
        return result;
    }

    private double Double1 (int number)
    {
        double result;
        double Double1 = number++;
        result = 2205.4F;
        return result;
    }

    
}
