using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpck : MonoBehaviour
{
    public player play;

    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        play.jumpcount = 1;
    }
}
