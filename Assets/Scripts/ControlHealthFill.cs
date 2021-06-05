using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlHealthFill : MonoBehaviour
{
    RectTransform fillTransform;
    RectTransform parentTransform;
    private float healthBarWidth;
    private float tenPercentOfMax;

    // Start is called before the first frame update
    void Start()
    {
        fillTransform = GetComponent<RectTransform>();
        parentTransform = GetComponentInParent<RectTransform>();
        healthBarWidth = parentTransform.rect.width;
        tenPercentOfMax = healthBarWidth * .10f;

        Debug.Log(fillTransform.offsetMax);
        Debug.Log(healthBarWidth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) {
            // offsetMax.x will be set to a negative val unless we flip the sign here, no idea why
            fillTransform.offsetMax = new Vector2((fillTransform.offsetMax.x + (-tenPercentOfMax)), fillTransform.offsetMax.y);
        }
    }
}
