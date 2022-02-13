using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    private Score score;

    void Awake()
    {
        score = gameObject.GetComponent<Score>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            score.number++;
            Debug.Log("Score スクリプトの number: " + score.number);
        }
    }
}
