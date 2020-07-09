using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_assistant : MonoBehaviour
{
    [SerializeField] private TextWriter textWriter;
    private Text messageText;
    private void Awake()
    {
        messageText = transform.Find("Dialogue").Find("DialogueText").GetComponent<Text>();
        messageText.text = "Thanks for saving me!";
    }

    private void Start()
    {
        messageText.text = "Thanks for finding me!                      I'm surprised that someone could reach here.                              But this does not end here.. there's more to all of this.                 I've been researching about this alien life and I concluded that I'm in dire need of someone to help.                 So let's reveal the mystery together!";
        textWriter.AddWriter(messageText, "Thanks for finding me!                      I'm surprised that someone could reach here.                              But this does not end here.. there's more to all of this.                 I've been researching about this alien life and I concluded that I'm in dire need of someone to help.                 So let's reveal the mystery together!", .1f);
    }
}
