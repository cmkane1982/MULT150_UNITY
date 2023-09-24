using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int month = 1; month <= 12; month++)
        {
            int totalDays;

            switch (month)
            {
                case 1: 
                    totalDays = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    totalDays = 30;
                    break;
                default:
                    totalDays = 31;
                    break;
            }

            for(int currDay = 1; currDay <= totalDays; currDay++)
            {
                if(month == 1 && currDay == 19)
                {
                    print("It's my birthday!");
                }
                else
                {
                    print(month + "/" + currDay);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
