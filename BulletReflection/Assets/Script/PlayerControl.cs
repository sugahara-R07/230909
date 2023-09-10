using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject player;
    public Vector3 mousePosition;
    public Camera camera;

    //èeé¸ÇË
    public GameObject bullet;
    public GameObject bulletPoint;
    public float bulletSpeed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        var worldMousePos = camera.ScreenToWorldPoint(mousePosition);
        worldMousePos.z = 0f;
        transform.up = Vector3.MoveTowards(
            transform.up,
            worldMousePos - player.transform.position,
            100.0f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(1))
        {
            Vector3 shotForward = Vector3.Scale((worldMousePos - transform.position), new Vector3(1, 1, 0)).normalized;
            Shot(shotForward);
        }
    }

    public void Shot(Vector3 vec)
    {
        Vector3 startPos = bulletPoint.transform.position;
        GameObject newbullet = Instantiate(bullet,startPos,transform.rotation);
        BulletScript bulletScript = newbullet.GetComponent<BulletScript>();
        bulletScript.GetVelocity(vec);
    }
}
