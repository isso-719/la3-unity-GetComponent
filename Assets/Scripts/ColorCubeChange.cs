using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubeChange : MonoBehaviour
{
    private RandomColor randomColor;
    Renderer cubeRenderer;

    private void Awake()
    {
        randomColor = this.GetComponent<RandomColor>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        cubeRenderer = collision.gameObject.GetComponent<Renderer>();
        cubeRenderer.material.color = randomColor.GetBodyColor();

        randomColor.ChangeBodyColor();
    }
}
