using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPulsar : MonoBehaviour
{
    [SerializeField] GameObject lightObject;
    float PulsarInterval;
    float LightInterval;
    bool LightOn = false;
    int damagePulsar = 40;
    int DamageTypePulsar = 2;
    float PulsarRadius = 6.3f;
    int layera;
    Collider[] targets;
    Light lt;

    // Start is called before the first frame update
    void Start()
    {
        layera = LayerMask.NameToLayer("Enemy");
        lt = lightObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        PulsarInterval = PulsarInterval + Time.deltaTime;

        targets = Physics.OverlapSphere(this.transform.position, PulsarRadius, 1 << layera);
        if(PulsarInterval >= 2.5f)
        {
	        foreach (Collider target in targets)
		    {
                if(target.gameObject.tag == "enemy")
                {
                    target.gameObject.GetComponent<EnemyController>().Damaged(damagePulsar,DamageTypePulsar);
                    LightOn = true;
                }
            }
            PulsarInterval = 0.0f;
        }
        if(LightOn == true){
            lt.range = 8f;
            lt.intensity = 10f;
            LightInterval = LightInterval + Time.deltaTime;
        }
        if(LightInterval >= 0.1f){
            lt.range = 3f;
            lt.intensity = 5f;
            LightOn = false;
            LightInterval = 0.0f;
        }
    }
}