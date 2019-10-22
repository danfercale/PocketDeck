using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardProperties : MonoBehaviour
{
    public Card card;

    public GameObject cardobject;
    public string cardname;
    public int value;
    public string type;
    public Sprite sprite;
    public string location;
    public int handSlot;

   public void Start()
    {

        cardname = card.Cardname;
        value = card.Cardvalue;
        type = card.Cardtype;
        sprite = card.Cardsprite;
        location = card.Cardlocation;
        handSlot = card.CardhandSlot;
        cardobject.AddComponent(typeof(Image));
        cardobject.AddComponent(typeof(Button));
        cardobject.GetComponent<Image>().sprite = sprite;
        cardobject.GetComponent<RectTransform>().sizeDelta = new Vector2(75, 100);
        cardobject.SetActive(false);

        


    }






}

