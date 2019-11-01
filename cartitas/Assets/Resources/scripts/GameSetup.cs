using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class GameSetup : MonoBehaviour
{
    public PlayerManager playermanager;
    public Camera MainCamera;

    int maxcardsinhand = 8;                                    //número máximo de cartas permitidas en la mano
    public List<Vector3> movetohandSlotposition;               //vector 3 dimensional que se encarga de mover las cartas a su sitio
    int deckcardnumber = 0;                                    //cartas en la baraja
    int cardsinhand = 0;                                       //castas en la mano
    public bool firstmovement = true;                          // controla si se ha realizado el primer movimiento

  
    public List<bool> cardinhandSlot;          //controla si un hueco de la mano esta ocupado o no, siendo false que está vacío

    public GameObject Cards;             //el array que contiene todos los objetos que tienen dentro los atributos de la carta
    public GameObject[] DeckArray;             //el array que contiene todos los objetos que tienen dentro los atributos de la carta
    public List<GameObject> DeckList;          //lista de cartas de la baraja
    public List<GameObject> CardsinPlayerHand; //lista de cartas en la mano del jugador
    public List<GameObject> CardsinBoard;      //lista de cartas en la mesa(¿zona de juego?)
    public GameObject LastplayedCard;          //última carta jugada
    

    
    void Start()
    {
        Cards = Cards;
        for(int i = 0; DeckArray.Length > i; i++)     //este bucle se encarga de meter las cartas en el array deck y de guardar su numero en una variable
        {
            DeckList.Add(DeckArray[i]);
            deckcardnumber++;
            
        }

        for(int i = 0; maxcardsinhand > i ; i++)      //este bucle se encarga de asignar la posición de los huecos en la mano e inicializarlos como no ocupados (false)
        {

            //movetohandSlotposition.Insert(i, new Vector3(1.18f*i, 0, 0));  //antes era 80i, lo he tenido que cambiar porque me enviaba las cartas a partla al cambiar el tipo de canvas

            Vector3 tempvector3 = MainCamera.ViewportToWorldPoint(new Vector3(0.1f + (0.15f * i), 0.1f, MainCamera.nearClipPlane)); 
            movetohandSlotposition.Insert(i, tempvector3);
            cardinhandSlot.Insert(i, false);
        }
           

    }


    public void drawcard()                            // funcion que se llama al cliclar en la imagen de la baraja y se encarga de llevar una carta de la baraja a la mano
    {

        Debug.Log("deckcardnumber: " + deckcardnumber + ", maxcardsinhand: " + maxcardsinhand + ", cardsinhand: " + cardsinhand);
        if ((deckcardnumber > 0) && (maxcardsinhand > cardsinhand))
        {
            bool drawn = false;
            for ( int i = 0 ; cardinhandSlot[i] == false && drawn == false || cardinhandSlot.Contains(false) == true; i++)
            {
                if (cardinhandSlot[i] == false)
                {
                    int RandomDraw = Random.Range(0, deckcardnumber);
                    DeckList[RandomDraw].SetActive(true);
                    DeckList[RandomDraw].layer = 7 + playermanager.selectedplayer;                  //se encarga de meter la carta en una capa que solo pueda ver la cámara de ese jugador
                    DeckList[RandomDraw].GetComponent<CardProperties>().location = "Playerhand";
                    DeckList[RandomDraw].GetComponent<CardProperties>().handSlot = i;
                    DeckList[RandomDraw].GetComponent<RectTransform>().SetPositionAndRotation(movetohandSlotposition[i], new Quaternion(0,0,0,0));
                    DeckList[RandomDraw].GetComponent<Button>().onClick.AddListener(movetoboard);
                    CardsinPlayerHand.Add(DeckList[RandomDraw]);
                    DeckList.Remove(DeckList[RandomDraw]);
                    cardinhandSlot[i] = true;
                    cardsinhand++;
                    deckcardnumber--;
                    drawn = true;
                    break;
                }

            }

            




        }
    }   
        


    public void movetoboard()         //funcion que se encarga de mover las cartas de la mano a la mesa de juego

        {

        if(firstmovement == true || LastplayedCard.GetComponent<CardProperties>().value < EventSystem.current.currentSelectedGameObject.GetComponent<CardProperties>().value )
        {
            //Vector3 tempxyz = EventSystem.current.currentSelectedGameObject.GetComponent<RectTransform>().transform.localPosition.normalized;
            //EventSystem.current.currentSelectedGameObject.GetComponent<RectTransform>().transform.Translate(-tempxyz);  
            Vector3 p = MainCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, MainCamera.nearClipPlane));                                       //MainCamera.ViewportToWorldPoint se encarga de poner un objeto en un lugar determinado de la pantalla gracias a un Vector3, siendo (0,0...) la esquina inferior izquierda y (1,1..) la esquina superior derecha
            EventSystem.current.currentSelectedGameObject.GetComponent<RectTransform>().SetPositionAndRotation(p, new Quaternion(0, 0, 0, 0));    //lo dicho en la anterior linea mas el quaternion, que no entiendo muy bien que es así que lo dejo en 0 todo
            LastplayedCard = EventSystem.current.currentSelectedGameObject;
            CardsinPlayerHand.Remove(EventSystem.current.currentSelectedGameObject);
            cardinhandSlot[EventSystem.current.currentSelectedGameObject.GetComponent<CardProperties>().handSlot] = false;
            
            firstmovement = false;
            cardsinhand--;
            EventSystem.current.currentSelectedGameObject.GetComponent<CardProperties>().handSlot = -2;

            if (LastplayedCard.GetComponent<CardProperties>().value > 11)
            {
                Debug.Log("hasganaoQUEBUENOERES");
            }
        }





        }

    public void startgameagain()

    {
        DeckList.Clear();
        CardsinPlayerHand.Clear();
        CardsinBoard.Clear();
        deckcardnumber = DeckArray.Length;
        cardsinhand = 0;


        for (int i = 0; DeckArray.Length > i; i++)
        {
            Debug.Log(DeckArray[i].GetComponent<RectTransform>().localPosition);
            DeckArray[i].GetComponent<RectTransform>().localPosition.Set(-100, -265, 0);
            DeckArray[i].SetActive(false);
            
        }
        for (int i = 0; DeckArray.Length > i; i++)
        {
            DeckList.Add(DeckArray[i]);
            deckcardnumber++;

        }
        for (int i = 0; maxcardsinhand > i; i++)
        {
            bool tempbool = cardinhandSlot[i];
            tempbool = false;
            cardinhandSlot[i] = false;

        }


    }

    
}
