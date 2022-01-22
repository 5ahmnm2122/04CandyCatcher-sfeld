using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    GameObject player;
    [SerializeField]
    float speed;
    [SerializeField]
    float xMin;
    [SerializeField]
    float xMax; 

    Vector3 position; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        //print(Input.GetAxis("Horizontal"));
        position = player.transform.position; 
        Vector3 newPos = position + new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        if (newPos.x < xMin || newPos.x > xMax)
            newPos = position;

        player.transform.position = newPos;

    }
}
