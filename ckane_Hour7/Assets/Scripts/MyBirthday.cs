using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    public int birthdayMonth;
    public int birthdayDay;

    // Start is called before the first frame update
    void Start()
    {
        for(int currMonth = 1; currMonth <= 12; currMonth++)
        {
            int totalDays;

            switch (currMonth)
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
                if(currMonth == birthdayMonth && currDay == birthdayDay)
                {
                    Debug.Log("It's my birthday!");
                }
                else
                {
                    Debug.Log(currMonth + "/" + currDay);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
