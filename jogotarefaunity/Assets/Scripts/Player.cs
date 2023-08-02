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
    public float speed;




    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        posInicial = new Vector3(-7f, -1f, 0f);
        transform.position = posInicial;
    }



    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(speed, rig.velocity.y);
        rig.velocity = new Vector2(Input.GetAxis("horizontal") * speed, rig.velocity.y);



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
