using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    [SerializeField] GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<SController>().onGround = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.GetComponent<SController>().onGround = false;
    }
}