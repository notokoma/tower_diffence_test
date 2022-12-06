using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPulsar : MonoBehaviour
{
    [SerializeField] GameObject lightObject;
    float PulsarInterval;
    float PulsarIntervalMax = 2.3f;
    float LightInterval;
    bool LightOn = false;
    int damagePulsar;
    int damagePulsarPrimal = 40;
    int DamageTypePulsar = 2;
    float PulsarRadius = 3.5f;
    float PulsarFreezeTime = 1.5f;
    float PulsarFreezeEffect = 0.75f;
    int layera;
    int Damagebuffs;
    bool PulsarEX;
    Collider[] targets;
    Light lt;

    // Start is called before the first frame update
    void Start()
    {
        layera = LayerMask.NameToLayer("Enemy");
        lt = lightObject.GetComponent<Light>();
        damagePulsar = damagePulsarPrimal;

        PulsarEX = false;
        int i=0;
        while(i<30){
            if(TrapBuffs.Buffs[i] == true){
                switch(i){

                    case 4:
                    Damagebuffs = Damagebuffs + 20;
                    break;

                    case 5:
                    Damagebuffs = Damagebuffs + 20;
                    break;    

                    case 6:
                    PulsarRadius = PulsarRadius + 0.8f;
                    break;

					case 7:
                    PulsarIntervalMax = PulsarIntervalMax * 0.7f;
                    break;

                    case 9:
                    Damagebuffs = Damagebuffs + 20;
                    break;

                    case 10:
                    PulsarIntervalMax = PulsarIntervalMax * 0.7f;
                    break;

                    case 17:
					PulsarEX = true;
                    Damagebuffs = Damagebuffs + 50;
                    break;

                    case 18:
					PulsarEX = true;
                    PulsarFreezeTime = PulsarFreezeTime * 1.5f;
                    break;

                    case 19:
					PulsarEX = true;
                    PulsarFreezeEffect = PulsarFreezeEffect - 0.25f;
                    break;

					case 20:
                    Damagebuffs = Damagebuffs - 30;
                    break;

					case 21:
                    Damagebuffs = Damagebuffs + 40;
                    break;
					
					case 23:
                    PulsarIntervalMax = PulsarIntervalMax * 0.7f;
                    break;

                    case 24:
                    Damagebuffs = Damagebuffs + 50;
                    PulsarIntervalMax = PulsarIntervalMax * 0.7f;
                    PulsarRadius = PulsarRadius - 1.0f;
                    break;

                    case 25:
                    PulsarRadius = PulsarRadius + 0.8f;
                    break;

                    default:
                    break;
                }
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PulsarInterval = PulsarInterval + Time.deltaTime;

        targets = Physics.OverlapSphere(this.transform.position, PulsarRadius, 1 << layera);
        if(PulsarInterval >= PulsarIntervalMax)
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