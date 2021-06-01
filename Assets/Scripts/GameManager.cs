using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private Canvas mainCanvas;

    [SerializeField]
    private FirstPersonAIO playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        EnableGame(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNormalGame()
    {
        EnableGame(true);
    }

    private void EnableGame(bool enableGame)
    {
        if (mainCanvas != null)
        {
            mainCanvas.enabled = !enableGame;
        }

        if (playerMovement != null)
        {
            playerMovement.enabled = enableGame;
        }

        Cursor.lockState = enableGame ? CursorLockMode.Locked : CursorLockMode.None;
    }


}
