﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float fuerzaSalto = 30f;
    public float velocidad = 3f;
    public Transform sueloCheck;
    public float checkRadio;
    public LayerMask queEsPiso;
    public Joystick joy;

    private bool enSuelo;
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
        float vertical = joy.Vertical;

        if (vertical > 0 && enSuelo)
        {
            rb2d.velocity = Vector2.up * fuerzaSalto;
        }

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
}