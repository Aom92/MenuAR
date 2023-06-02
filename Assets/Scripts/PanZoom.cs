using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanZoom : MonoBehaviour
{
    public bool Enabled = false;
    public GameObject Target;
    public float panSmoothing;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = Target.transform.position;
    }

    public void AllowMovement()
    {
        Enabled = !Enabled;
        if(!Enabled)
            Target.transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enabled)
        {
            //Panning
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    Vector2 pos = touch.deltaPosition;
                    Vector3 position = new Vector3(pos.x / panSmoothing, 0, pos.y / panSmoothing);
                    Target.transform.position -= position;
                }
            }

            //Zooming
            if (Input.touchCount >= 2)
            {
                var touchZero = Input.GetTouch(0);
                var touchOne = Input.GetTouch(1);

                var touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                var touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                var prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                var currentMagnitude = (touchZero.position - touchOne.position).magnitude;

                float difference = currentMagnitude - prevMagnitude;

                Target.transform.localScale = new Vector3(difference, difference, difference);

            }
        }
    



        


    }
}
