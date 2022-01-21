using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovePlayer=0f;
    public float JumpPower=0f;
    bool canJump=false;
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left") ||Input.GetKey("a")){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-MovePlayer*Time.deltaTime,0));
        }
         if(Input.GetKey("right") ||Input.GetKey("d")){
             gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(MovePlayer*Time.deltaTime,0));
        }
        if(Input.GetKeyDown("up") && canJump){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,JumpPower));
            canJump=false;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.transform.tag=="ground"){
            canJump=true;
        }
    }
}