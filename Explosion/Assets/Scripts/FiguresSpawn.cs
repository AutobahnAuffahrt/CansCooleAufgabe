using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FiguresSpawn : MonoBehaviour
{
    public Button spawn;
    public GameObject[] spwnlocation;
    public GameObject spwnplayer;
    public GameObject blub;
    private int meow = 0;
    private int count = 0;
    private float ded = 30;
    private bool routine;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Awake()
    {
        spwnlocation = GameObject.FindGameObjectsWithTag("Respawn");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn()
    {
        var gam = Instantiate(spwnplayer, spwnlocation[meow % spwnlocation.Length].transform.position, Quaternion.identity);
        meow++;
        count++;
        gam.name = "Figure" + count;
        Destroy(gam, ded);
    }
}
