using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float fuerzaSalto = 30f;
    public float velocidad = 3f;
    public Transform sueloCheck;
    public float checkRadio;
    public LayerMask queEsPiso;
    public Joystick joy;
    public bool vertical;
    private bool enSuelo;
    public AudioSource audioSource;
    public AudioClip pisada;

    private Rigidbody2D rb2d;
    private Animator animador;
    private SpriteRenderer spriteRenderer;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animador = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

       
    }


    void Update()
    {
        animador.SetFloat("Velocidad", Mathf.Abs(rb2d.velocity.x));
        animador.SetBool("EnSuelo", enSuelo);
    }

    void FixedUpdate()
    {

        enSuelo = Physics2D.OverlapCircle(sueloCheck.position, checkRadio, queEsPiso);

        float horizontal = joy.Horizontal;

        if (horizontal != 0 && Mathf.Abs(rb2d.velocity.x)!=0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(pisada);
            }
        }

        if (vertical && enSuelo)
        {
            rb2d.velocity = Vector2.up * fuerzaSalto;
        }

		vertical = false;
        rb2d.velocity = new Vector2(velocidad * horizontal, rb2d.velocity.y);


        bool flipSprite = (spriteRenderer.flipX ? (horizontal > 0.001f) : (horizontal < 0.001f));
        if (flipSprite)
        {
            if(horizontal != 0f)
            {
                spriteRenderer.flipX = !spriteRenderer.flipX;
            }
        }

       
    }

    public void saltando()
    {
        audioSource.PlayOneShot(pisada);
        vertical = true;
    }
    public void bajando()
    {
        vertical = false;
    }
}