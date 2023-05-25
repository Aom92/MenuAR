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
       canvasAnimation.Play("CanvasShowAnim");
    }

    public void HideCanvas()
    {
       canvasAnimation.Play("CanvasHideAnim");
    }


}
