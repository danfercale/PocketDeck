using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public Slider Soldierslider;
    public double totaltime;
    public Text textuu;
    private bool startcountdown = false;

    public void startCountdown()
    {
        totaltime = Soldierslider.value * 4;
        startcountdown = true;

    }

    private void Update()
    {
        if (startcountdown == true)
        {
            totaltime = totaltime - 1 * Time.deltaTime;
            textuu.text = totaltime.ToString();
        }
    }
}
