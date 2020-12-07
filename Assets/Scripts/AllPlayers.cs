using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPlayers : MonoBehaviour
{
    public static readonly int MAX_NUMBER_OF_PLAYERS = 8;
    public GameObject playerPrefab;
    public Color[] playerColors = { new Color(0, 0, 0, 1), new Color(1, 0, 0, 1), new Color(0, 1, 0, 1), new Color(0, 0, 1, 1), new Color(1, 1, 0, 1), new Color(1, 0, 1, 1), new Color(0, 1, 1, 1), new Color(1, 1, 1, 1) };

    private void Awake()
    {
        for(int i=0;i< MAX_NUMBER_OF_PLAYERS; i++)
        {
            var newPlayer = Instantiate(playerPrefab);
            newPlayer.transform.SetParent(transform);
            newPlayer.name = Player.PLAYER_GENERIC_GAMEOBJECT_NAME + "_" + (i + 1);
            newPlayer.GetComponent<Player>().playerColor = playerColors[i];
            newPlayer.GetComponent<Player>().UpdatePlayerColor();
            if (i != 0)
            {
                newPlayer.GetComponent<Player>().isPlayerActivated = false;
                newPlayer.SetActive(false);
            }
        }
    }
}
