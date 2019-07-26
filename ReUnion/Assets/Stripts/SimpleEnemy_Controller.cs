using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy_Controller : MonoBehaviour
{
    public float velocidadmaxima = 1f;
    public float velocidad = 1f;
	public float minY;
	private Rigidbody2D rb2d;
	private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

		if(rb2d.position.y < minY)
		{
			Destroy(gameObject);
		}
        rb2d.AddForce(Vector2.right*velocidad);
        float velocidadlimitada = Mathf.Clamp(rb2d.velocity.x,-velocidadmaxima,velocidadmaxima);
        rb2d.velocity = new Vector2(velocidadlimitada,rb2d.velocity.y);
        if (rb2d.velocity.x > -0.01f && rb2d.velocity.x < 0.01f)
        {
            velocidad = -velocidad;
            rb2d.velocity = new Vector2(velocidad,rb2d.velocity.y);
        }

		bool flipSprite = (spriteRenderer.flipX ? (velocidad > 0.001f) : (velocidad < 0.001f));
		if (flipSprite)
		{
			if (velocidad != 0f)
			{
				spriteRenderer.flipX = !spriteRenderer.flipX;
			}
		}

		
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "proyectiljugador")
        {
            Destroy(gameObject);
        }

	}
}
