using UnityEngine;
using System.Collections;

public class PowerControllerScript : MonoBehaviour {

    public bool slowTime = false;
    public bool timeLimit = true;
    public int slowTimeBar = 500;
    private int slowTimeBarCount = 100;

    // Use this for initialization
    void Start() {

    }

    void SlowMo()
    {
        slowTime = true;
    }


    // Update is called once per frame
    void Update() {
        if (slowTimeBarCount < 100) //This counts a second before the slow-mo starts regenerating
        {
            slowTimeBarCount = slowTimeBarCount + 1;
        }

        if (Input.GetKey(KeyCode.E) && slowTime == true && slowTimeBar > 1) //This allows you to slow down time when the player holds the E button once they have unlocked it.
        {
            Time.timeScale = 0.01F;

            Time.fixedDeltaTime = 0.01F;
            slowTimeBar = slowTimeBar - 1; //this counts down the time bar. Once this reaches 0, you can not slow time until it has regenerated.
            if (timeLimit == true)
            {
                slowTimeBarCount = 0; //this restarts the timer for the time bar regen. While the player is holding E, they can not regenerate any of the time bar.
            }
       
        }
        else
        {
            Time.timeScale = 1f;
            Time.fixedDeltaTime = 1f;
        }

        if (slowTimeBar < 500 && slowTimeBarCount == 100)
        {
            slowTimeBar = slowTimeBar + 1; //this regenerates the timebar if it is not full and you haven't used it for 1 second.
        }
        //For testing only
        if (Input.GetKey(KeyCode.S))
        {
            slowTimeBar = slowTimeBar - 1; 
        }

        }
}