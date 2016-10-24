using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CharacterController : MonoBehaviour {
    public float maxSpeed = 10f;
    public float jumpForce = 700f;
    bool facingRight = true;
    bool grounded = false;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float score;
    public float move;

    private GameObject star;

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        move = Input.GetAxis("Horizontal");
    }

    void Update()
    {
        if (grounded && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.gameObject.name == "dieCollider") || (col.gameObject.name == "saw"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if (col.gameObject.tag == "Star")
        {
            score++;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Fire")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 100), "Stars: " + score);
    }

}
