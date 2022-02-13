using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float power = 500f;
    private Rigidbody cubyRigidBody;

    // Awake is called before the Start method
    private void Awake()
    {
        cubyRigidBody = this.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.cubyRigidBody.AddForce(Vector3.up * power);
        }
    }
}
