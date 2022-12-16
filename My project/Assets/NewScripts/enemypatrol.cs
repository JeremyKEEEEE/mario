using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{

    [SerializeField] private GameObject chicken;
    [SerializeField] private float speed = 1.5f;

   void Start(){

   }
    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, chicken.transform.position, speed*Time.deltaTime);
    }

}
