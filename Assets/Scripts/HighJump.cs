using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighJump : MonoBehaviour
{
    private Rigidbody highJumpCubeRigidBody;
    private Rigidbody collisionRigidBody;
    private Renderer highJumpCubeRenderer;
    public float force = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        highJumpCubeRigidBody = this.GetComponent<Rigidbody>();

        highJumpCubeRenderer = this.GetComponent<Renderer>();
        highJumpCubeRenderer.material.color = new Color(255, 0, 0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.highJumpCubeRigidBody.AddForce(Vector3.up * force);

        collisionRigidBody = collision.gameObject.GetComponent<Rigidbody>();
        collisionRigidBody.AddForce(Vector3.down * force);
    }
}
