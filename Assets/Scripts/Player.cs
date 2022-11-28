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
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime);
    }
}