using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    [SerializeField] Text scoreValueText;
    private void Update() => transform.Rotate(new Vector3(0f, 0.5f, 0f));
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int scorevalue = int.Parse(scoreValueText.text);
            scorevalue += 25;
            scoreValueText.text = scorevalue.ToString();
            Destroy(gameObject);
        }
    }
}