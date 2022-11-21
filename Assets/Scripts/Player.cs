using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        // take the current position and assign start position (0,0,0).
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.left * 5 * Time.deltaTime);
    }
}