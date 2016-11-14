using UnityEngine;
using UnityEngine.SceneManagement;

public class CharController : MonoBehaviour
{
    public float maxSpeed = 10f;
    public float jumpForce = 700f;

    bool facingRight = true;
    bool isGrounded = false;
    Animator animator;
    CharState State
    {
        get { return (CharState)animator.GetInteger("State"); }
        set { animator.SetInteger("State", (int)value); }
    }

    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float move;


    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        move = Input.GetAxis("Horizontal");
    }

    void Update()
    {
        State = CharState.Idle;
        if (!isGrounded) State = CharState.Jump;
        else if (move != 0) State = CharState.Run;

        if (isGrounded && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space)))
            Jump();

        Run();

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.gameObject.tag)
        {
            case "Star":
                Data.Stars++;
                Destroy(collider.gameObject);
                break;
            case "Die":
            case "Fire":
            case "Saw":
                CharacterDeath();
                break;
            case "NewLevel":
                Data.CompletedLevels++;
                LoadNewLevel();
                break;
        }
    }

    /// <summary>
    /// Бег
    /// </summary>
    void Run()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }

    /// <summary>
    /// Прыжок
    /// </summary>
    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
    }

    /// <summary>
    /// Разворот игрока
    /// </summary>
    void Flip()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    /// <summary>
    /// Смерть игрока
    /// </summary>
    void CharacterDeath()
    {
        Data.Lives--;
        Data.Stars = 0;
        if (Data.Lives <= 0)
        {
            Data.Lives = 5;
            Data.Stars = 0;
            Data.CompletedLevels = 0;
            Data.StarTotal = 0;
            SceneManager.LoadScene(0);
        }
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// Новый уровень
    /// </summary>
    void LoadNewLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Game.Save();
    }
}
