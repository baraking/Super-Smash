using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static readonly string PLAYER_TAG_NAME="player";
    public static readonly string PLAYER_GENERIC_GAMEOBJECT_NAME = "Player";

    public int playerIndex;
    public Color playerColor;

    public bool isPlayerActivated;

    public Image cursor;

    private void Awake()
    {
        cursor.color = playerColor;
    }

    public void UpdatePlayerColor()
    {
        cursor.color = playerColor;
    }

}
