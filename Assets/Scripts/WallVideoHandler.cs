using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallVideoHandler : MonoBehaviour
{

    [SerializeField]
    private GameObject video;

    // Start is called before the first frame update
    void Start()
    {
        video.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        video.SetActive(true);
    }
}
