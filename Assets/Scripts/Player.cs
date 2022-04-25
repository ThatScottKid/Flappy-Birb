using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpHeight; //8f
    
    public UnityEvent scorePoint;
    public UnityEvent playerDied;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        Vector3 pos = transform.position;
        pos.y = 0;
        transform.position = pos;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(0, jumpHeight);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerDied.Invoke();
        Debug.Log("Collided");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scorePoint.Invoke();
        Debug.Log("Score+");
    }
}