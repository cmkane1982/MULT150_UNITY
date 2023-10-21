using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    private bool isGameOver = false;
    private float elapsedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
            elapsedTime += Time.deltaTime;
        }
    }

    void OnGUI()
    {
        if(isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 40, Screen.height / 2 - 25, 150, 50);
            GUI.Label(rect2, "Your Time: " + ((int)elapsedTime).ToString());
        }
        else
        {
            GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 100, 130, 40), "Your Time:");
            GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 85, 20, 30), ((int)elapsedTime).ToString());
        }
    }
}
