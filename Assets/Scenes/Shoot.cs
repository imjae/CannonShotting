using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Shoot : MonoBehaviour
{
    float gaugeStartTime = 0f;
    public float powerGauge = 0f;

    public TextMeshProUGUI powerGaugeText;
    public Transform bullet;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 왼쪽 버튼을 눌렀을 때의 처리
            gaugeStartTime = Time.time;
        }

        if(Input.GetMouseButton(0))
        {
            float gaugeEndTime = Time.time;
            powerGauge = (gaugeEndTime - gaugeStartTime) * 1000f;

            if(powerGaugeText != null)
                powerGaugeText.text = powerGauge.ToString();
        }

        if (Input.GetMouseButtonUp(0))
        {
            // 마우스 왼쪽 버튼을 뗄 때의 처리
            Instantiate(bullet);
        }

        
    }
}
