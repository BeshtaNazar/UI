using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;
    

    // Update is called once per frame
    void Update()
    {
        slider.value = Mathf.MoveTowards(slider.value, 100f, 0.15f);
    }
}
