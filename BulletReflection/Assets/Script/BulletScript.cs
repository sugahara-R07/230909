using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float life = 5f;
    private Vector3 velocity;
    public float speed;
    public Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(life < 0)
        {
            Destroy(this.gameObject);
        }
       
        this.transform.position += velocity * speed * Time.deltaTime;
    }

    public void GetVelocity(Vector3 velo)
    {
        velocity = velo;
        //rigidbody2D.AddForce(velocity * speed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "TopWall")
        {
            velocity.y *= -1;
            life -= 1;
        }
        if(collision.gameObject.tag =="SideWall")
        {
            velocity.x *= -1;
            life -= 1;
        }
        if(collision.gameObject.tag == "Bullet")
        {
            velocity *= -1;
        }
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "AriaBullet")
        {
            Destroy(this.gameObject);
        }
    }

}
