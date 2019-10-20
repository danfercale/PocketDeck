using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnimationTesting : MonoBehaviour
{

    public int animationTime = 20000;
    public int animationSteps = 400;
    public Image imageToAnimate;

    public void imageAnimationStart()
    {
        //confirm button press + conditions
        
    }

    public void LateUpdate()
    {
        imageToAnimate.fillAmount = imageToAnimate.fillAmount - 0.001f;
    }
}
    
        
            
            
        
    

