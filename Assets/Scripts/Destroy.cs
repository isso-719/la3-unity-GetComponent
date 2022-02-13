using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private Renderer highJumpCubeRenderer;

    // Start is called before the first frame update
    void Start()
    {
        highJumpCubeRenderer = this.GetComponent<Renderer>();
        highJumpCubeRenderer.material.color = new Color(0, 255, 0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
