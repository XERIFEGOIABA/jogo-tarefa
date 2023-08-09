using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variavel para o rigidBody
    private Rigidbody2D rig;
    //vetor da posição inicial do player
    private Vector3 posInicial;
    //variavel velocidade
    public float Speed;
    public Animator animator;
    public float JumpForce;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        posInicial = new Vector3(0f, 0f, 0f);
        transform.position = posInicial;
    }


    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(Speed, rig.velocity.y);
        rig.velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, rig.velocity.y);
        //se o player se movimenta na horizontal
        if(Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
        //verifica se a tecla espaço foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
        //verifica se a tecla A foi pressionada
        if (Input.GetKeyDown(KeyCode.A) && transform.localScale.x > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            Debug.Log("Tecla A foi Pressionada");
        }
        //verifica se a tecla D foi pressionada
        if (Input.GetKeyDown(KeyCode.D) && transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            Debug.Log("Tecla D foi Pressionada");

        }
    }
}
