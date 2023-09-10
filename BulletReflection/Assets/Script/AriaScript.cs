using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AriaScript : MonoBehaviour
{
    public float count = 0;
    public GameObject ariaBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;

        if(count > 5)
        {
            Shot(new Vector3(1, 1, 0));
            count = 0;
        }
    }

    public void Shot(Vector3 vec)
    {
        Vector3 startPos = this.transform.position;
        GameObject newbullet = Instantiate(ariaBullet, startPos, transform.rotation);
        AriaBulletScript bulletScript = newbullet.GetComponent<AriaBulletScript>();
        bulletScript.GetVelocity(vec);
    }
}
