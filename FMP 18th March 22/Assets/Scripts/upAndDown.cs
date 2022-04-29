using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upAndDown : MonoBehaviour
{
    //adjust this to change speed
    public float speed = 5f;
    //adjust this to change how high it goes
    public float height = 0.5f;

    //    public GameObject[] waypoints;
    //    int current = 0;
    //    float rotSpeed;
    //    public float speed;
    //    float WPradius = 1;


    //    // Start is called before the first frame update

    private float startY;

    private void Awake()
    {
        startY = transform.position.y;
    }


    //    // Update is called once per frame
    //    void Update()
    //    {
    //        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius) {
    //            current++;


    //            current = Random.Range(0, waypoints.Length);
    //            if (!(current >= waypoints.Length)){

    //                current = 0;

    //            }

    //            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    //        }


    //    }

    void Update()
    {
        //get the objects current position and put it in a variable so we can access it later with less code
        Vector3 pos = transform.position;
        //calculate what the new Y position will be
        float newY = (Mathf.Sin(Time.time * speed) * height) + startY;
        //set the object's Y to the new calculated Y
        transform.position = new Vector3(pos.x, newY, pos.z);
    }














}
