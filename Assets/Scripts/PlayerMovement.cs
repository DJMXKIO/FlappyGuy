using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private float jumpForce = 600f;

    [SerializeField] private AudioSource jumpSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 4f, 0);
            jumpSoundEffect.Play();
        }
        if (Input.touchCount > 0 && Input.GetTouch(8).phase == TouchPhase.Began)
        {
           // jumpSoundEffect.Play();
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Force);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        LoadScene("Menu");
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
