using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon_opener : MonoBehaviour
{
    Button ButtonF;
	Button ButtonC;
	Button ButtonP;
    // Start is called before the first frame update
    void Start()
    {
        ButtonF = GameObject.Find("ButtonFirewall").GetComponent<Button>();
        ButtonC = GameObject.Find("ButtonCanon").GetComponent<Button>();
        ButtonP = GameObject.Find("ButtonPulsar").GetComponent<Button>();
    }
    void Update()
    {
        ButtonF.interactable = TrapBuffs.Buffs[1];
        ButtonC.interactable = TrapBuffs.Buffs[2];
        ButtonP.interactable = TrapBuffs.Buffs[3];
    }
}
