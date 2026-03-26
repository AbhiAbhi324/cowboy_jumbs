using UnityEngine;
using UnityEngine.UIElements;

public class background : MonoBehaviour
{
    private Vector3 sposs;
    private float size;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sposs = transform.position;
        size = GetComponent<Renderer>().bounds.size.x/2;
        ;   // or x / y depending on direction

    }

    // Update is called once per frame
    void Update()
    {
        
       
        if (transform.position.x < sposs.x-size)
        {
            transform.position=sposs;
        }
    }
}
