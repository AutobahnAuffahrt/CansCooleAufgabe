using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureWalk : MonoBehaviour
{
    public GameObject players;
    public GameObject center;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, center.transform.position, speed * Time.deltaTime);
    }
}
