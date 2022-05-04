using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private FloatVariable obstSpeed;


    private void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, new Vector2
        (transform.position.x - obstSpeed.value, transform.position.y), 0.1f);      //'Pipes' always moving towards the left
    }

    public void ManageSpeed(int amount, IntVariable score)
    {
        if (score.value % 10 == 0)
        {
            obstSpeed.value *= amount;
        }
    }
}
