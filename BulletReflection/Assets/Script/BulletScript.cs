using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float life = 5f;
    private Vector3 velocity;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life -= Time.deltaTime;
        if(life < 0)
        {
            Destroy(this.gameObject);
        }

        this.transform.position += velocity * speed * Time.deltaTime;
    }

    public void GetVelocity(Vector3 velo)
    {
        velocity = velo;
    }
}
