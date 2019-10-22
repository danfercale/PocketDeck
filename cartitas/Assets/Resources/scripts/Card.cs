using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]

//scriptable object hace que se pueda crear con el botón derecho 
public class Card : ScriptableObject
{

    public int CardhandSlot;
    public string Cardname;
    public int Cardvalue;
    public string Cardtype;
    public Sprite Cardsprite;
    public string Cardlocation;
                                  //propiedades de la carta.
    

}
