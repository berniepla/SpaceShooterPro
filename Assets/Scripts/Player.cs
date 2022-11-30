using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public or private reference
    // data type
    [SerializeField]
    private float _speed = 3.5f;

    [SerializeField]
    private GameObject _laserPrefab;

    // Start is called before the first frame update
    private void Start()
    {
        // take the current position and assign start position (0,0,0).
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        CalculateMovement();

        // if spacekey hit=> spawn gameobject
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_laserPrefab, transform.position, Quaternion.identity);
            //laser needs to travel upwards
        }
    }

    private void CalculateMovement()
    {
        // get user input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0), 0);

        if (transform.position.x >= 11.3f)
        {
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }
        else if (transform.position.x < -11.3f)
        {
            transform.position = new Vector3(11.3f, transform.position.y, 0);
        }
    }
}