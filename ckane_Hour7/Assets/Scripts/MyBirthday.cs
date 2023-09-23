using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int totalDays;

        for(int month = 1; month <= 12; month++)
        {
            if(month == 2)
            {
                totalDays = 28;
            }
            else if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                totalDays = 30;
            }
            else
            {
                totalDays = 31;
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
