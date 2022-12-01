using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8f;

    // Update is called once per frame
    private void Update()
    {
        //translate laser up
        transform.Translate(transform.up * _speed * Time.deltaTime);

        if (transform.position.y >= 8f)
        {
            Destroy(gameObject);
        }
    }
}