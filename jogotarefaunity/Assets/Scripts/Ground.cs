using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Player player;
    
    void Start()
    {
        player = gameObject.transform.parent.gameObject.GetComponent<Player>();
    }
    //quando eu comecar a colidir
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            Debug.Log("COLIDIU");
        }
    }
    //quando parar colidir
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("PAROU DE COLIDIR!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
