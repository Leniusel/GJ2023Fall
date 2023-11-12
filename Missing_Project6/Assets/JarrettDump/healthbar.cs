using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int HP) //Max health setup
    {
        slider.maxValue = HP;
        slider.value = HP;
    }
    public void SetHealth(int HP) //Set health
    {
        slider.value = HP;
    }

}
