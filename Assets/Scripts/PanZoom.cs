using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanZoom : MonoBehaviour
{
    public bool Enabled = false;
    public GameObject Target;
    private Vector3 startPos;

    private float initialDistance;
    private Vector3 initialScale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AllowMovement()
    {
        Enabled = !Enabled;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Enabled)
        {
            

            //Zooming
            if (Input.touchCount == 2)
            {
                var touchZero = Input.GetTouch(0);
                var touchOne = Input.GetTouch(1);


                //Si se  levanta alguno de los dos dedos, cancelar la accion.
                if (touchZero.phase == TouchPhase.Ended || touchZero.phase == TouchPhase.Canceled ||
                    touchOne.phase == TouchPhase.Ended || touchOne.phase == TouchPhase.Canceled)
                {
                    return;
                }


                if(touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
                {
                  initialDistance = Vector2.Distance(touchZero.position, touchOne.position);
                  initialScale = Target.transform.localScale;

                }
                else 
                {
                    var currentDistance = Vector2.Distance(touchZero.position, touchOne.position);
                    // if accidental touch or movement really small
                    if (Mathf.Approximately(initialDistance, 0))
                    {
                        return;
                    }

                    var factor = currentDistance / initialDistance;
                    Target.transform.localScale = initialScale * factor;
                }
             
                

                

            }
        }
    



        


    }
}
