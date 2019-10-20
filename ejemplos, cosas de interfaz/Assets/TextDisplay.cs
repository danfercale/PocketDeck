using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextDisplay : MonoBehaviour {

    public Text textToCopy;
    public Text finalTextDisplay;

    private void LateUpdate()
    {
        finalTextDisplay.text = textToCopy.text;

    }
}
