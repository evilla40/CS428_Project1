using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("VRButton");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        character = GameObject.Find("Stacy");
        character.GetComponent<GameObject>();
        character.SetActive(false);

    }

    public void OnButtonPressed(VirtualButtonBehaviour b)
    {
        if (character.activeSelf == true)
            character.SetActive(false);
        else character.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour b)
    {
        //Do nothing
    }

    // Update is called once per frame
    void Update()
    {

    }
}
