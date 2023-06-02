using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayText : MonoBehaviour
{

    public TMP_Text dishName;
    public TMP_Text dishDescription;
    public TMP_Text dishPrice;

    private DisplayFood DispFoodReference;

    // Start is called before the first frame update
    void Start()
    {
        DispFoodReference = GetComponent<DisplayFood>();
        FoodTextUpdate();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FoodTextUpdate()
    {
        //Update the text on screen for each new food. 
        

        switch (DispFoodReference.foodIndex)
        {
            //Apple
            case 0:
                dishName.text = "Manzana Fresca";
                dishDescription.text = "Una jugosa manzana Granny Smith asada al horno, caramelizada con azúcar moreno y canela.";
                dishPrice.text = ". . . 15 MXN ";

                break;
            //Spaguetti
            case 1:
                dishName.text = "Spaguetti con Carne";
                dishDescription.text = "Un plato clásico y reconfortante que combina espagueti al dente con una generosa porción " +
                                       "de salsa boloñesa casera. " +
                                       "La carne molida sazonada con hierbas frescas, tomates maduros y " +
                                       "especias crea un sabor robusto y delicioso. ";
                dishPrice.text = ". . . 55 MXN";
                break;
            // Papa
            case 2:
                dishName.text = "Tortas de Papa";
                dishDescription.text = "Estas tortas están hechas con papa rallada, cebolla, queso y especias, " +
                                       "todo mezclado en una combinación perfecta.";
                dishPrice.text = ". . . 45 MXN";
                break;
            default:
                break;
        }

    }
}
