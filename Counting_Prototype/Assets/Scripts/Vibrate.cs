using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibrate : MonoBehaviour
{
    float vibrationRange = 0.07f;
    float originalYPosition = 1;
    float vibrationSpeed = 0.01f;
    bool isGoingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        originalYPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGoingUp)
        {
            if (originalYPosition + vibrationRange < transform.position.y)
                isGoingUp = false;
        }
        else
        {
            if (originalYPosition - vibrationRange > transform.position.y)
                isGoingUp = true;
        }

        if (isGoingUp)
            transform.Translate(Vector3.up * vibrationSpeed);
        else
            transform.Translate(Vector3.down * vibrationSpeed);
    }
}
