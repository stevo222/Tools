using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public int intelligence = 5;

    // Update is called once per frame
    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("Why hello there");
                break;
            case 4:
                print("K! Have a good day");
                break;
            case 3:
                print(" =Whadya want?");
                break;
            case 2:
                print("STOP TALKING");
                break;
            case 1:
                print("I SAID STOP!");
                break;
            default:
                print("Incorecct intelligene level.");
                break;
        }
    }
}
