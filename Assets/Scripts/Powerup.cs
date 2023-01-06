using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;

    //ID for Powerups
    //0 is tripleshot
    //1 is speed
    //2 is shields
    [SerializeField]
    private int _powerupID;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -4.5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();

            if (player != null)
            {
                //if powerup id is 0
                if (_powerupID == 0)
                {
                    player.TripleShotActive();
                }
                else if (_powerupID == 1)
                {
                    Debug.Log("got speed powerup");
                }
                else if (_powerupID == 2)
                {
                    Debug.Log("got shield powerup");
                }
                // else if powerup is 1, play speed powerup
                //else if powerup is 2, shields powerup
            }
            Destroy(this.gameObject);
        }
    }
}