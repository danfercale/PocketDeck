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
        //sprite = card.Cardsprite;
        location = card.Cardlocation;
        handSlot = card.CardhandSlot;
        this.cardobject.AddComponent(typeof(Image));
        this.cardobject.AddComponent(typeof(Button));
        this.cardobject.GetComponent<Image>().sprite = sprite;
        this.cardobject.GetComponent<RectTransform>().sizeDelta = new Vector2(75, 100);
        this.cardobject.SetActive(false);
    }

}

