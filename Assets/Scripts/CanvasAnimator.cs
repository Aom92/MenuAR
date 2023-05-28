using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAnimator : MonoBehaviour
{

    public Animator canvasAnimation;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCanvas()
    {
        Debug.Log("Showed Canvas");
       canvasAnimation.Play("CanvasShowAnim");
    }

    public void HideCanvas()
    {
        Debug.Log("Hide Canvas");
        canvasAnimation.Play("CanvasHideAnim");
    }


}
