using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArmyQuantity : MonoBehaviour {

    
    public Slider basicSoldierSlider;
    public Text currentBasicSoldierText;
    double currentBasicSoldierCount;

	public void HireBasicSoldier()
    {

            double tempdouble = basicSoldierSlider.value;          
            currentBasicSoldierText.text = tempdouble.ToString("0.00E+0");       
            currentBasicSoldierCount = tempdouble + currentBasicSoldierCount;
            currentBasicSoldierText.text = currentBasicSoldierCount.ToString("0.00E+0");
        
    }
}
