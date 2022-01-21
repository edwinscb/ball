using System.Threading;
using System;
using System.IO.Compression;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position=new Vector3(0,0,0);
        Rotation();
    }
    private void Rotation(){
        float ballPosition=GameObject.FindGameObjectWithTag("Player").transform.position.x;
        var  z=gameObject.transform.rotation.eulerAngles;
        if(ballPosition<=-90){
 
            if(z.z<45||z.z>315){
            transform.Rotate(0.0f,0.0f,-20.0f*Time.deltaTime);
            }
        }
        if(ballPosition>=90){
            if(z.z<45||z.z>315){
            transform.Rotate(0.0f,0.0f,20.0f*Time.deltaTime);
            }
        }
                if(ballPosition<=-80 && ballPosition>-90){
            if(z.z<45||z.z>320){
            transform.Rotate(0.0f,0.0f,-10.0f*Time.deltaTime);
            }
        }
        if(ballPosition>=80 && ballPosition<90){
            if(z.z<40||z.z>315){
            transform.Rotate(0.0f,0.0f,10.0f*Time.deltaTime);
            }
        }
        if(ballPosition<=-70 && ballPosition>-80){
 
            if(z.z<45||z.z>325){
            transform.Rotate(0.0f,0.0f,-7.0f*Time.deltaTime);
            }
        }
        if(ballPosition>=70 && ballPosition<80){
            if(z.z<35||z.z>315){
            transform.Rotate(0.0f,0.0f,7.0f*Time.deltaTime);
            }
        }
        if(ballPosition<=-60 && ballPosition>-70){
 
            if(z.z<45||z.z>330){
            transform.Rotate(0.0f,0.0f,-6.0f*Time.deltaTime);
            }
        }
        if(ballPosition>=60 && ballPosition<70){
            if(z.z<30||z.z>315){
            transform.Rotate(0.0f,0.0f,6.0f*Time.deltaTime);
            }
        }
        if(ballPosition<=-50 && ballPosition>-60){
            if(z.z<45||z.z>335){
            transform.Rotate(0.0f,0.0f,-5.0f*Time.deltaTime);
            }
        }
        if(ballPosition>=50 && ballPosition<60){
            if(z.z<25||z.z>315){
            transform.Rotate(0.0f,0.0f,5.0f*Time.deltaTime);
            }
        }
        if(ballPosition<=-40 && ballPosition>-50){
            if(z.z<45||z.z>340){
            transform.Rotate(0.0f,0.0f,-4.0f*Time.deltaTime);
            }
        }
        if(ballPosition>=40 && ballPosition<50){
            if(z.z<20||z.z>315){
            transform.Rotate(0.0f,0.0f,4.0f*Time.deltaTime);
            }
        }
        if(ballPosition<=-30 && ballPosition>-40){
            if(z.z<45||z.z>345){
            transform.Rotate(0.0f,0.0f,-3.0f*Time.deltaTime);
            }
        }
        if(ballPosition>=30 && ballPosition<40){
            if(z.z<15||z.z>315){
            transform.Rotate(0.0f,0.0f,3.0f*Time.deltaTime);
            }
        }
        if(ballPosition<=-20 && ballPosition>-30){
            if(z.z<45||z.z>350){
            transform.Rotate(0.0f,0.0f,-2.0f*Time.deltaTime);
            }
        }
        if(ballPosition>=20 && ballPosition<30){
            if(z.z<10||z.z>315){
            transform.Rotate(0.0f,0.0f,2.0f*Time.deltaTime);
            }
        }
        if(ballPosition<=-10 && ballPosition>-20){
            if(z.z<45||z.z>355){
            transform.Rotate(0.0f,0.0f,-1.0f*Time.deltaTime);
            }
        }
        if(ballPosition>=10 && ballPosition<20){
            if(z.z<5||z.z>315){
            transform.Rotate(0.0f,0.0f,1.0f*Time.deltaTime);
            }
        }
    }
    private void checkCoordsBall(){
        float ballPosition=GameObject.FindGameObjectWithTag("Player").transform.position.x;
    }
}
