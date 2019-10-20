//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Card : MonoBehaviour
//{

//    public int Cardvalue;
//    public string Cardtype;
//    public Image CardImage;
//    public string Cardlocation;
    

//    public Card(int value, string type, Image image, string location)
//    {
//        this.Cardvalue = value;
//        this.Cardtype = type;
//        this.CardImage = image;
//        this.Cardlocation = location;
//    }

//    public GameObject pepe;
//    public Image[] CardImages;
//    public List<Card> Deck; 
    
//    private void Start()
//    {
//     pepe.AddComponent(typeof(Card));

//        //   Deck.Add(new Card(2, "tu", CardImages[1], "Deck"));
//        //   Deck[1] = new Card(2, "tu", CardImages[1], "Deck");
//        //  Deck[2] = new Card(6, "el", CardImages[2], "Deck");
//        //   Deck[3] = new Card(9, "nostros", CardImages[3], "Deck");
//        // Deck[4] = new Card(0, "vostros", CardImages[4], "Deck");


//    }
//    public void DrawCard()
//    {
        
//        int RandomDraw = Random.Range(0, Deck.Count);
        
//        Deck.RemoveAt(RandomDraw);
//    }

//}
