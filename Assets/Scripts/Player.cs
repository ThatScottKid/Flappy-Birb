using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    //private SpriteRenderer sr;
    
    [SerializeField] private float jumpHeight;
    public AudioEvent flapAudioEvent;
    public AudioSource flapAudioSource;     //Child GO
    public AudioEvent pointAudioEvent;
    public AudioSource pointAudioSource;     //Child GO
    public AudioEvent deathAudioEvent;
    public AudioSource deathAudioSource;     //Child GO
    
    public UnityEvent scorePoint;
    public UnityEvent playerDied;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnEnable()
    {
        Vector3 pos = transform.position;
        pos.y = 0;
        transform.position = pos;       //Resets character pos when game is restarted
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(0, jumpHeight);
            flapAudioEvent.Play(flapAudioSource);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)      //When players hits a 'Pipe'
    {
        playerDied.Invoke();
        deathAudioEvent.Play(deathAudioSource);
    }

    private void OnTriggerEnter2D(Collider2D collision)     //When player passed through a 'Pipe'
    {
        scorePoint.Invoke();
        pointAudioEvent.Play(pointAudioSource);
    }
}
