using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSprites : MonoBehaviour

{
    public Sprite[] EspaCardSprites;
    public Image CartaDePrueba;
    public Slider CartaDePruebaSlider; //lo que está debajo del botón de Cambiar carta, nose como se dice en español jeje 

    public void Awake()    // el awake va antes del start y en este caso se encarga de que todos los sprites derivados de EspaCard se metan en el array EspaCardSprites
    {                      // se puede ver este array una vez se le da al play en el objeto "las scripts"
        EspaCardSprites = Resources.LoadAll<Sprite>("EspaCard");
    }

    public void cambiarfoto()
    {

        CartaDePrueba.sprite = EspaCardSprites[(int)CartaDePruebaSlider.value];  //cambia el sprite de la carta en función del valor del slider (está puesto de 0 a 50)

    }

}
