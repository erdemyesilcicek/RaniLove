using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    public string[] dialogue;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DialogueSystem.instance.AddDialogue(dialogue);
        }
    }
}
