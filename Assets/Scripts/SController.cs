using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SController : MonoBehaviour
{
    //Erdem
    private float sSpeedX;
    [SerializeField] float speed;
    [SerializeField] float jumpPower;

    private Rigidbody2D sRigidbody;
    private Animator sAnimator;
    private Vector3 defaultLocalScale;

    public bool onGround;
    private bool canDoubleJump;
    void Start()
    {
        sRigidbody = GetComponent<Rigidbody2D>();
        sAnimator = GetComponent<Animator>();
        defaultLocalScale = transform.localScale;    }
    void Update()
    {
        #region speed
        sSpeedX = Input.GetAxis("Horizontal");
        sAnimator.SetFloat("Speed", Mathf.Abs(sSpeedX));
        sRigidbody.velocity = new Vector2 (sSpeedX * speed, sRigidbody.velocity.y);
        
        if (sSpeedX > 0)
        {
            transform.localScale = new Vector3(defaultLocalScale.x, defaultLocalScale.y, defaultLocalScale.z);
        }
        else if(sSpeedX < 0)
        {
            transform.localScale = new Vector3 (-defaultLocalScale.x, defaultLocalScale.y, defaultLocalScale.z);
        }
        #endregion

        #region jump
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) 
        {
            if(onGround == true) 
            {
                sRigidbody.velocity = new Vector2(sRigidbody.velocity.x, jumpPower);
                canDoubleJump = true;
                sAnimator.SetTrigger("Jump");
            }
            else
            {
                if(canDoubleJump == true)
                {
                    sRigidbody.velocity = new Vector2(sRigidbody.velocity.x, jumpPower);
                    canDoubleJump = false;
                }
            }
        }
        #endregion
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            int presentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(presentScene + 1);

            Debug.Log("FINISH");
            Destroy(collision.gameObject);
        }
    }
}