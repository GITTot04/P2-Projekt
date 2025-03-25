using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using JetBrains.Annotations;
using Random = UnityEngine.Random;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class Messaging : MonoBehaviour
{
    public Sprite profilePic;
    public GameObject messageBoble;
    public TextMeshPro messageText;
    public string[] messages = { "I am loving Lego", "We are NOT gamers in distress, we are GAMERS IN POWER!!!!!", "Send Nudes", "I believe that we should legalize something, not sure what tho", "Play games, Gain Bitches", "Who is my best friend from somewhere far below this line of balls" };
    public int randomNumber;
    public GameObject emojiButton;
    public GameObject emojiPanel;
    public GameObject emoji1;
    public GameObject emojiPlacement;
    
    public void Start()
    {
        randomNumber = Random.Range(0, messages.Length);
        //messages = new string[randomNumber];
        messageText.text = messages[randomNumber];
        
        Instantiate(messageBoble, messageText.rectTransform); 
        {
            
        }
        emojiButton.SetActive(true);
        emojiPanel.SetActive(false);
        emoji1.SetActive(false);
    }
    public void Update()
    {
        
    }
    public void EmojiButton()
    {
        emojiButton.SetActive(false);
        emojiPanel.SetActive(true);
    }
    public void EmojiPanel()
    {  emojiPanel.SetActive(false);
       emojiPlacement = Instantiate(emoji1, transform.position += new Vector3(0,0,-5), transform.rotation);
        emojiPlacement.SetActive(true);
        
    }
}
