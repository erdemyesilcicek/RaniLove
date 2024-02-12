using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem instance;

    public GameObject dialoguePanel;

    public List<string> dialogueLines = new List<string>();

    public Button contButton;
    Text dialogueText;
    int dialogueIndex;

    private void Awake()
    {
        dialogueText = dialoguePanel.transform.GetChild(0).GetChild(0).GetComponent<Text>();
        dialoguePanel.SetActive(false);

        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void AddDialogue(string[] lines)
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>(lines.Length);
        dialogueLines.AddRange(lines);
        CreateDialogue();
    }
    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        dialoguePanel.SetActive(true);
        Time.timeScale = 0;
        AudioListener.volume = 0;
    }
    public void ContinueDialogue()
    {
        if(dialogueIndex < dialogueLines.Count -1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            dialoguePanel.SetActive(false);
            Time.timeScale = 1;
            AudioListener.volume = 1;
        }
    }
}
