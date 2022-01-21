using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public KeyCode a;
    public KeyCode b;
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void checkPressed(){
        if(Input.GetKey(a) ||Input.GetKey(b)){
            gameObject.GetComponent<SpriteRenderer>().enabled=true;
        }else{
            gameObject.GetComponent<SpriteRenderer>().enabled=false;
        }
    }
}
