using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayFood : MonoBehaviour
{

    public GameObject[] foodModel;
    public int foodIndex = 0;
    public Animator ContainerAnimation;


    // Start is called before the first frame update
    void Start()
    {
        // Hide everything
        foreach(GameObject food in foodModel)
        {
            food.SetActive(false);
        }

        // Show the first one
        if(foodModel.Length > 0)
        {
            foodModel[0].SetActive(true);
        }

        this.ContainerAnimation = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextFood()
    {
        // Spin first, then change food.
        ContainerAnimation.Play("FoodContainerSpin");

        Debug.Log("length is:" + foodModel.Length);
        if(foodIndex >= foodModel.Length - 1)
        {
            foodModel[foodIndex].SetActive(false);
            foodModel[0].SetActive(true);
            foodIndex = 0;
        }
        else
        {
            foodModel[foodIndex].SetActive(false);
            foodModel[foodIndex + 1].SetActive(true);
            foodIndex++;
        }

        


    }



}
