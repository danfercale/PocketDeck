using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// script que contiene las cámaras de los jugadores, el canvas del tablero, y los propios jugadores.

public class PlayerManager : MonoBehaviour {

    public GameObject[] playerCameras;
    public Canvas BoardCanvas;
    public Player[] players;
    public int selectedplayer = 1;


    private void Update()      //activar / desactivar la cámara correspondiente al seleccionar un jugador con las teclas 1,2,3,4
    {

        if (Input.GetButtonDown("keyboard1"))
        {
            selectedplayer = players[0].Playernumber;
            Debug.Log("player " + selectedplayer + " selected");
            playerCameras[0].SetActive(true);
            playerCameras[1].SetActive(false);
            playerCameras[2].SetActive(false);
            playerCameras[3].SetActive(false);
            BoardCanvas.worldCamera = playerCameras[0].GetComponent<Camera>();
        }
  
        if (Input.GetButtonDown("keyboard2"))
        {
            selectedplayer = players[1].Playernumber;
            Debug.Log("player " + selectedplayer + " selected");
            playerCameras[0].SetActive(false);
            playerCameras[1].SetActive(true);
            playerCameras[2].SetActive(false);
            playerCameras[3].SetActive(false);
            BoardCanvas.worldCamera = playerCameras[1].GetComponent<Camera>();


        }

        if (Input.GetButtonDown("keyboard3"))
        {
            selectedplayer = players[2].Playernumber;
            Debug.Log("player " + selectedplayer + " selected");
            playerCameras[0].SetActive(false);
            playerCameras[1].SetActive(false);
            playerCameras[2].SetActive(true);
            playerCameras[3].SetActive(false);
            BoardCanvas.worldCamera = playerCameras[2].GetComponent<Camera>();
        }

        if (Input.GetButtonDown("keyboard4"))
        {
            selectedplayer = players[3].Playernumber;
            Debug.Log("player " + selectedplayer + " selected");
            playerCameras[0].SetActive(false);
            playerCameras[1].SetActive(false);
            playerCameras[2].SetActive(false);
            playerCameras[3].SetActive(true);
            BoardCanvas.worldCamera = playerCameras[3].GetComponent<Camera>();
        }
   
    }
}
