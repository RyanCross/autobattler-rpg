using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackTimer : MonoBehaviour
{
    public Slider attackTimerSlider;
    public float curTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        attackTimerSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        attackTimerSlider.value += curTime + Time.deltaTime;
        if (attackTimerSlider.value == attackTimerSlider.maxValue)
             attackTimerSlider.value = 0;
    }

    
}
