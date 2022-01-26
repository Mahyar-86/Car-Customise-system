using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confirm : MonoBehaviour
{
    public Item selected;
    public Customizer customizer;

    public void SelectItem(Item item)
    {
        selected = item;

        switch (item._Type)
        {
            case Item.Type.Wheels:

                for (int i = 0; i < customizer.position.wheelsPosition.Length; i++)
                {
                    if (customizer.position.wheelsPosition[i].childCount>0)
                    {
                        Destroy(customizer.position.wheelsPosition[i].GetChild(0).gameObject);
                    }


                    Instantiate(customizer.components._Wheels[item.index].model, customizer.position.wheelsPosition[i]);

                }
                
                break;
            
            case Item.Type.Spoiler:

                if (customizer.position.spoiler.childCount>0)
                {
                    Destroy(customizer.position.spoiler.GetChild(0).gameObject);
                }


                Instantiate(customizer.components._Spoiler[item.index].model, customizer.position.spoiler);


                    break;
            
            case Item.Type.RoofScoop:
                
                if (customizer.position.roofScoop.childCount>0)
                {
                    Destroy(customizer.position.roofScoop.GetChild(0).gameObject);
                }


                Instantiate(customizer.components._RoofScoops[item.index].model, customizer.position.roofScoop);
                
                break;
        }
    }


}
