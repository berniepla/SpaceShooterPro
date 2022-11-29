using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public or private reference
    // data type
    [SerializeField]
    private float _speed = 3.5f;

    // Start is called before the first frame update
    private void Start()
    {
        // take the current position and assign start position (0,0,0).
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        // get user input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // perform movement based on user input
        //optimized a bit to use one Vector3 object
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

        // check if player position on the y is greater than 0
        // y = 0
        // else if position on y is less than -3.8f
        // y = -3.8f

        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -3.8f)
        {
            transform.position = new Vector3(transform.position.x, -3.8f, 0);
        }

        // if player on x > 11
        // x  = -11
        // else if player on x is less than -11
        // x = 11
    }
}