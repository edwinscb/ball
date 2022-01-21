using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //Variables
    public float maxAngle = 0f;
    public float centre = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rotation(rotacionPerDistance());
    }

    // Update is called once per frame
    void Update()
    {
        rotation(rotacionPerDistance());
    }
    private float checkCoordsBall()
    {
        float ballPosition = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        return ballPosition;
    }
    //angle valores desde -45 a 45
    private void rotation(float angle)
    {
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
    private float rotacionPerDistance()
    {
        float xBall = checkCoordsBall();
        float a = (gameObject.transform.localScale.x / 2) + centre;
        float b = gameObject.transform.localScale.x - a;
        if (xBall != centre)
        {

            if (xBall < centre)
            {
                return (xBall * maxAngle) / a;
            }
            else
            {
                print(xBall + "dife" + centre);
                return (xBall * maxAngle) / b;
            }
        }
        else
        {
            print(xBall + "iguales" + centre);
            return 0;
        }
    }
}
