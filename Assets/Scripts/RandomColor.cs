using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    Renderer targetRenderer;

    private void Awake()
    {
        targetRenderer = this.GetComponent<Renderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        targetRenderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Getter
    public Color GetBodyColor()
    {
        return targetRenderer.material.color;
    }

    // Setter
    public void ChangeBodyColor()
    {
        targetRenderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }
}
