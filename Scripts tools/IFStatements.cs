using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    [SerializeField]
    float hotLimitTemerature = 70.0f;
    [SerializeField]
    float coldLimitTemperature = 40.0f;
    [SerializeField]
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TempatureTest();

            coffeeTemperature -= Time.deltaTime * 5f;
        }

    }

    void TempatureTest()
    {
        if (coffeeTemperature > hotLimitTemerature)
        {
            print("Coffee is too hot.");
        }
        else if(coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}
