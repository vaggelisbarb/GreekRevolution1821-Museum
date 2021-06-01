using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColliderScript : MonoBehaviour
{

    private const KeyCode URL_KeyCode = KeyCode.F;
    private const KeyCode ImageShow_KeyCode = KeyCode.E;

    [SerializeField]
    private string urlToOpen;

    [SerializeField]
    private GameObject objectToShow;

    [SerializeField]
    private Material materialToPut;

    [SerializeField]
    TextMesh text;

    private bool isInRange = false;
    private bool imageIsActive = false;
    private bool isKeyPressed = false;

    private void SetTheMaterial()
    {
        if (objectToShow == null || materialToPut == null)
        {
            return;
        }

        objectToShow.GetComponent<MeshRenderer>().material = materialToPut;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isInRange)
        {
            return;
        }

        if (Input.GetKeyDown(URL_KeyCode))
        {
            isKeyPressed = !isKeyPressed;
            OpenURL();
        }

        if (Input.GetKeyDown(ImageShow_KeyCode))
        {
            isKeyPressed = !isKeyPressed;
            ShowTheImage();
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (!isKeyPressed)
            text.gameObject.SetActive(true);
        else
            text.gameObject.SetActive(false);
        isInRange = true;
    }

    private void OnTriggerExit(Collider collider)
    {
        text.gameObject.SetActive(false);
        isInRange = false;
        DeactivateImageObject();
    }

    private void OpenURL()
    {
        if (string.IsNullOrWhiteSpace(urlToOpen))
        {
            return;
        }

        Application.OpenURL(urlToOpen);
    }

    private void ShowTheImage()
    {
        if (imageIsActive)
        {
            DeactivateImageObject();
            return;
        }

        SetTheMaterial();

        objectToShow?.SetActive(true);
        imageIsActive = true;
    }

    private void DeactivateImageObject()
    {
        objectToShow?.SetActive(false);
        imageIsActive = false;
        isKeyPressed = false;
    }
}
