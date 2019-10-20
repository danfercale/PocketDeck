using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class CardImages : MonoBehaviour {

    int NumberOfCardsInBoard = 0;
    int DrawToHandPositionx = 0;
    int cardposindex = 0;

    public Vector3[] cardpos;
    
    public GameObject Deck;
    public Image[] CardArt;
    public GameObject[] CardsObjectArray;
    public GameObject Card;
    public List<GameObject> CardObjectsInDeckList;
    public List<GameObject> CardObjectsOnBoardList;

    private void Start()
    {
        
        for (int i = 0; i < CardArt.Length; i++ )
        {
            GameObject Card = new GameObject("card" + i.ToString());
            Card.AddComponent(typeof(Image));
            Card.GetComponent<Image>().sprite = CardArt[i].GetComponent<Image>().sprite;
            //   Card.transform.parent = Deck.transform.parent;
            Card.transform.SetParent(transform, Deck.transform);
            Card.SetActive(false);
            CardsObjectArray[i] = Card;               
            CardObjectsInDeckList.Insert(i, Card);
            
        }
        

    }

    public void DrawCard()
    {
        

        if (CardsObjectArray.Length >= NumberOfCardsInBoard + 1)
         {

            

        int RandomDraw =  Random.Range(0, CardsObjectArray.Length - NumberOfCardsInBoard);

        CardObjectsOnBoardList.Insert(0, CardObjectsInDeckList[RandomDraw]);
        CardObjectsInDeckList.RemoveAt(RandomDraw);
        CardObjectsOnBoardList[0].SetActive(true);
        
        CardObjectsOnBoardList[0].transform.Translate(50+DrawToHandPositionx, 60, 0);
        cardpos[cardposindex] = CardObjectsOnBoardList[0].transform.position;
        Debug.Log(cardpos[1]);
        DrawToHandPositionx = DrawToHandPositionx + 80;
        NumberOfCardsInBoard = NumberOfCardsInBoard + 1;
        cardposindex++;
         }
    }

    public void Shuffle()
    {
        DrawToHandPositionx = 0;
        

        for (int i = 0; i < NumberOfCardsInBoard ; i++ )
        {

         
            CardObjectsInDeckList.Add(CardObjectsOnBoardList[0]);
            CardObjectsOnBoardList[0].transform.position = cardpos[i];
            CardObjectsOnBoardList[0].SetActive(false);            
            CardObjectsOnBoardList.Remove(CardObjectsOnBoardList[0]);
            

        }
        NumberOfCardsInBoard = 0;
    }
}
