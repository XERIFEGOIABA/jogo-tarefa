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
    //variavel forca pulo
    public float JumpForce;
    //controlar o pulo
    public bool isJumping;
    private Vector3 posInicial;
    public Animator animator;
    private bool isMoving;
    public static float health = 1;
    public GameObject gameOverPanel;



  // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<RigidBody2D>();
        posInicial = new Vector3(0, 0, 0);
        transfom.position = posInicial;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
