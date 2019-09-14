using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BackButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public TextEditor buttonText;
    public TextMesh text1;
    public TextMesh text2;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("BackVRButton");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        text1 = GameObject.Find("BackButtonText").GetComponent<TextMesh>();
        text1.text = "Text Reviews";
        counter = 0;

        text2 = GameObject.Find("BackText").GetComponent<TextMesh>();
        text2.text = "My Side of the Mountain\n" +
                         "by Jean Craighead\n" +
                         "Language: English\n" +
                         "Number of Pages: 177\n" +
                         "Year Published: 2004";
    }

    public void OnButtonPressed(VirtualButtonBehaviour b)
    {
        ++counter;
        if (counter % 3 == 1)
        {
            text1.text = "Video Reviews";
            text2.text = "Great read!  10/10!!!";
        }
        else if (counter % 3 == 2)
        {
            text1.text = "Book Info";
            text2.text = "";
        }
        else
        {
            text1.text = "Text Reviews";
            text2.text = "My Side of the Mountain\n" +
                         "by Jean Craighead\n" +
                         "Language: English\n" +
                         "Number of Pages: 177\n" +
                         "Year Published: 2004";
        }
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
