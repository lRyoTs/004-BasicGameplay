using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed = 10f;
    public float xRange = 10f;
    public GameObject Projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if player is out of bounds
        PlayerBounds();
        
        //get horizontal movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        //CHeck if FireProjectile is called by SPACE
        if (Input.GetKeyDown(KeyCode.Space)) {
            FireProjectile();
        }
    }

    //Check if the movement is out of bounds
    private void PlayerBounds() {
        Vector3 pos = transform.position;
        if (pos.x < -xRange) {
            transform.position = new Vector3(-xRange, pos.y, pos.z); //Limit movement in -X axis
        }
        if (pos.x > xRange) {
            transform.position = new Vector3(xRange, pos.y, pos.z); //Limit Movement in X axis
        }
    }

    //Create object projectile
    private void FireProjectile() {
        Instantiate(Projectile, transform.position, Quaternion.identity);
    }
}
