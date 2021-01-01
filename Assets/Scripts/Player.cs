using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
//using static UnityEngine.InputSystem.InputAction;

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

    //public PlayerControls controls;

    public InputAction wasd;

    private void Awake()
    {
        //controls = new PlayerControls();
        cursor.color = playerColor;
        cursorController = cursor.GetComponent<CursorController>();
    }

    private void Update()
    {
        //cursorLocation=controls.Gameplay.Move.ReadValue<Vector2>();
        cursorLocation = wasd.ReadValue<Vector2>();
        cursorController.inputVector = wasd.ReadValue<Vector2>();
        Debug.Log(wasd.ReadValue<Vector2>().ToString());
        print(cursorLocation);
    }

    public void UpdatePlayerColor()
    {
        cursor.color = playerColor;
    }

    public void Button_1()
    {
        print("Button_1");
    }

    /*public void MenuMovement(CallbackContext context)
    {
        cursorController.inputVector = context.ReadValue<Vector2>();
    }*/

    public void OnEnable()
    {
        //controls.Gameplay.Enable();
        wasd.Enable();
    }

    public void OnDisable()
    {
        //controls.Gameplay.Disable();
        wasd.Disable();
    }

}
