using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

public class Player : MonoBehaviour
{
    public static readonly string PLAYER_TAG_NAME="player";
    public static readonly string PLAYER_GENERIC_GAMEOBJECT_NAME = "Player";

    public int playerIndex;
    public Color playerColor;

    public bool isPlayerActivated;
    public bool isPlayerReady;

    public Image cursor;
    public CursorController cursorController;

    public Vector2 cursorLocation;

    private void Awake()
    {
        cursor.color = playerColor;
        cursorController = cursor.GetComponent<CursorController>();
    }

    public void UpdatePlayerColor()
    {
        cursor.color = playerColor;
    }

    public void MenuMovement(CallbackContext context)
    {
        cursorController.inputVector = context.ReadValue<Vector2>();
    }

}
