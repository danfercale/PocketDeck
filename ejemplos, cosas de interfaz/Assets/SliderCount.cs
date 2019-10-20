using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderCount : MonoBehaviour {

    public Slider sliderValue;
    public Text sliderValueText;
    public string startString;

	public void SliderToNumber()
    {
        double tempdouble = sliderValue.value;
        sliderValueText.text = startString + tempdouble.ToString("0.00E+0");
        

    }
}
