using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureKnockback : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 100f;
    private float delay = 0.5f;
    private float radius = 2;
    private float push = 10;
    private Vector3 knockback;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void ApplyKnockback()
    {
        foreach (GameObject gameobjecto in GameObject.FindGameObjectsWithTag("Meow"))
        {
            var distance = Vector3.Distance(gameobjecto.transform.position, gameObject.transform.position);
            Vector3 flyhigh = gameobjecto.transform.position - knockback;
            if (distance <= radius)
            {
                Destroy(gameobjecto, delay);
                return;
            }
            if (distance <= push)
            {
                gameobjecto.GetComponent<Rigidbody>().AddForce(flyhigh.normalized * force);
            }
        }
    }
    private void OnDestroy()
    {
        ApplyKnockback();
    }
}
