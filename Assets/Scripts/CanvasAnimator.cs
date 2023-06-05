using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAnimator : MonoBehaviour
{

    public Animator canvasAnimation;
    public Animator SideBarAnimation;
    public Animator SideBarAnimation2;

    private bool sidebartoogle = false;

    // Start is called before the first frame update
    void Start()
    {
        HideCanvas();
        HideSideBar();

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

    private void ShowSideBar()
    {
        Debug.Log("Showed SideBar");
        SideBarAnimation.Play("CanvasSideBarShow");
        SideBarAnimation2.Play("hh");
        
    }

    private void HideSideBar()
    {
        Debug.Log("Hide SideBar");
        SideBarAnimation.Play("CanvasSideBarHide");
        SideBarAnimation2.Play("ss");
    }

    public void SideBarToogle()
    {
        sidebartoogle = !sidebartoogle;
        if (sidebartoogle)
        {
            ShowSideBar();
        }
        else
        {
            HideSideBar();
        }
    }

}
