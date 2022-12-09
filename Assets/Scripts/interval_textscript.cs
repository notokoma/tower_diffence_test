using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class interval_textscript : MonoBehaviour
{
    GameObject ButtonSelect1,ButtonSelect2,ButtonSelect3,ButtonSelectPrimal;
    TextMeshProUGUI ButtonSelectTextExp1,ButtonSelectTextExp2,ButtonSelectTextExp3;
    
    void Start(){
        ButtonSelect1 = GameObject.Find("ButtonBuff1");
        ButtonSelectTextExp1 = GameObject.Find("ButtonBuffTextExp1").GetComponent<TextMeshProUGUI>();
        ButtonSelect2 = GameObject.Find("ButtonBuff2");
        ButtonSelectTextExp2 = GameObject.Find("ButtonBuffTextExp2").GetComponent<TextMeshProUGUI>();
        ButtonSelect3 = GameObject.Find("ButtonBuff3");
        ButtonSelectTextExp3 = GameObject.Find("ButtonBuffTextExp3").GetComponent<TextMeshProUGUI>();
        ButtonSelectPrimal = GameObject.Find("ButtonBuffMaster(Clone)");

        if(ButtonSelect1 == this.gameObject && BuffSelect.ButtonBuff1 == -1){
            //Destroy(this.gameObject);
        }
        if(ButtonSelect2 == this.gameObject && BuffSelect.ButtonBuff2 == -1){
            //Destroy(this.gameObject);
        }
        if(ButtonSelect3 == this.gameObject && BuffSelect.ButtonBuff3 == -1){
            //Destroy(this.gameObject);
        }

        switch(BuffSelect.ButtonBuff1){
            case 0:
            ButtonSelectTextExp1.text = "ゴールドを100手に入れる";
            break;

            case 1:
            ButtonSelectTextExp1.text = "Firewallを手に入れる";
            break;

            case 2:
            ButtonSelectTextExp1.text = "Canonを手に入れる";
            break;

            case 3:
            ButtonSelectTextExp1.text = "Pulsarを手に入れる";
            break;

            case 4:
            ButtonSelectTextExp1.text = "全てのトラップのダメージを上昇させる";
            break;

            case 5:
            ButtonSelectTextExp1.text = "全てのトラップのダメージを上昇させる";
            break;
            
            case 6:
            ButtonSelectTextExp1.text = "全てのトラップのダメージ範囲を拡大させる";
            break;

            case 7:
            ButtonSelectTextExp1.text = "全てのトラップのダメージ間隔を減少させる";
            break;

            case 8:
            ButtonSelectTextExp1.text = "全てのトラップのダメージ範囲を拡大させる";
            break;

            case 9:
            ButtonSelectTextExp1.text = "全てのトラップのダメージを上昇させる";
            break;

            case 10:
            ButtonSelectTextExp1.text = "全てのトラップのダメージ間隔を減少させる";
            break;

            case 11:
            ButtonSelectTextExp1.text = "Firewallが継続的にダメージを与えるデバフを獲得し、さらにデバフのダメージを上昇させる";
            break;

            case 12:
            ButtonSelectTextExp1.text = "Firewallが継続的にダメージを与えるデバフを獲得し、さらにFirewallのダメージを上昇させる";
            break;

            case 13:
            ButtonSelectTextExp1.text = "Firewallが継続的にダメージを与えるデバフを獲得し、さらにデバフのダメージ間隔を減少させる";
            break;

            case 14:
            ButtonSelectTextExp1.text = "Canonが着弾した周りの敵にも半分のダメージを与え、さらにCanonのダメージを上昇させる";
            break;

            case 15:
            ButtonSelectTextExp1.text = "Canonが着弾した周りの敵にも半分のダメージを与え、さらにCanonのダメージ範囲を拡大させる";
            break;

            case 16:
            ButtonSelectTextExp1.text = "Canonが着弾した周りの敵にも半分のダメージを与え、さらにCanonのダメージ間隔を減少させる";
            break;

            case 17:
            ButtonSelectTextExp1.text = "Pulsarが敵の移動速度を減少させるデバフを獲得し、さらにPulsarのダメージを上昇させる";
            break;

            case 18:
            ButtonSelectTextExp1.text = "Pulsarが敵の移動速度を減少させるデバフを獲得し、さらにデバフの継続時間を延長させる";
            break;

            case 19:
            ButtonSelectTextExp1.text = "Pulsarが敵の移動速度を減少させるデバフを獲得し、さらにデバフの効果量を上昇させる";
            break;

            case 20:
            ButtonSelectTextExp1.text = "Firewallのダメージを大きく上昇させるが、CanonとPulsarのダメージを減少させる";
            break;

            case 21:
            ButtonSelectTextExp1.text = "全てのトラップのダメージを上昇させる";
            break;

            case 22:
            ButtonSelectTextExp1.text = "Canonのダメージを大きく上昇させるが、ダメージ間隔を延長させる";
            break;

            case 23:
            ButtonSelectTextExp1.text = "全てのトラップのダメージ間隔を減少させる";
            break;

            case 24:
            ButtonSelectTextExp1.text = "Pulsarのダメージを大きく上昇させるが、ダメージ範囲を縮小させる";
            break;

            case 25:
            ButtonSelectTextExp1.text = "全てのトラップのダメージ範囲を拡大させる";
            break;

            case 26:
            ButtonSelectTextExp1.text = "ゴールドを150手に入れる";
            break;

            case 27:
            ButtonSelectTextExp1.text = "ゴールドを300手に入れるが、耐久値を1減少させる";
            break;

            case 28:
            ButtonSelectTextExp1.text = "耐久値を1回復させる";
            break;

            case 29:
            ButtonSelectTextExp1.text = "ゴールドを100手に入れる";
            break;

            default:
            break;
        }
        switch(BuffSelect.ButtonBuff2){
            case 0:
            ButtonSelectTextExp2.text = "ゴールドを100手に入れる";
            break;

            case 1:
            ButtonSelectTextExp2.text = "Firewallを手に入れる";
            break;

            case 2:
            ButtonSelectTextExp2.text = "Canonを手に入れる";
            break;

            case 3:
            ButtonSelectTextExp2.text = "Pulsarを手に入れる";
            break;

            case 4:
            ButtonSelectTextExp2.text = "全てのトラップのダメージを上昇させる";
            break;

            case 5:
            ButtonSelectTextExp2.text = "全てのトラップのダメージを上昇させる";
            break;
            
            case 6:
            ButtonSelectTextExp2.text = "全てのトラップのダメージ範囲を拡大させる";
            break;

            case 7:
            ButtonSelectTextExp2.text = "全てのトラップのダメージ間隔を減少させる";
            break;

            case 8:
            ButtonSelectTextExp2.text = "全てのトラップのダメージ範囲を拡大させる";
            break;

            case 9:
            ButtonSelectTextExp2.text = "全てのトラップのダメージを上昇させる";
            break;

            case 10:
            ButtonSelectTextExp2.text = "全てのトラップのダメージ間隔を減少させる";
            break;

            case 11:
            ButtonSelectTextExp2.text = "Firewallが継続的にダメージを与えるデバフを獲得し、さらにデバフのダメージを上昇させる";
            break;

            case 12:
            ButtonSelectTextExp2.text = "Firewallが継続的にダメージを与えるデバフを獲得し、さらにFirewallのダメージを上昇させる";
            break;

            case 13:
            ButtonSelectTextExp2.text = "Firewallが継続的にダメージを与えるデバフを獲得し、さらにデバフのダメージ間隔を減少させる";
            break;

            case 14:
            ButtonSelectTextExp2.text = "Canonが着弾した周りの敵にも半分のダメージを与え、さらにCanonのダメージを上昇させる";
            break;

            case 15:
            ButtonSelectTextExp2.text = "Canonが着弾した周りの敵にも半分のダメージを与え、さらにCanonのダメージ範囲を拡大させる";
            break;

            case 16:
            ButtonSelectTextExp2.text = "Canonが着弾した周りの敵にも半分のダメージを与え、さらにCanonのダメージ間隔を減少させる";
            break;

            case 17:
            ButtonSelectTextExp2.text = "Pulsarが敵の移動速度を減少させるデバフを獲得し、さらにPulsarのダメージを上昇させる";
            break;

            case 18:
            ButtonSelectTextExp2.text = "Pulsarが敵の移動速度を減少させるデバフを獲得し、さらにデバフの継続時間を延長させる";
            break;

            case 19:
            ButtonSelectTextExp2.text = "Pulsarが敵の移動速度を減少させるデバフを獲得し、さらにデバフの効果量を上昇させる";
            break;

            case 20:
            ButtonSelectTextExp2.text = "Firewallのダメージを大きく上昇させるが、CanonとPulsarのダメージを減少させる";
            break;

            case 21:
            ButtonSelectTextExp2.text = "全てのトラップのダメージを上昇させる";
            break;

            case 22:
            ButtonSelectTextExp2.text = "Canonのダメージを大きく上昇させるが、ダメージ間隔を延長させる";
            break;

            case 23:
            ButtonSelectTextExp2.text = "全てのトラップのダメージ間隔を減少させる";
            break;

            case 24:
            ButtonSelectTextExp2.text = "Pulsarのダメージを大きく上昇させるが、ダメージ範囲を縮小させる";
            break;

            case 25:
            ButtonSelectTextExp2.text = "全てのトラップのダメージ範囲を拡大させる";
            break;

            case 26:
            ButtonSelectTextExp2.text = "ゴールドを150手に入れる";
            break;

            case 27:
            ButtonSelectTextExp2.text = "ゴールドを300手に入れるが、耐久値を1減少させる";
            break;

            case 28:
            ButtonSelectTextExp2.text = "耐久値を1回復させる";
            break;

            case 29:
            ButtonSelectTextExp2.text = "ゴールドを100手に入れる";
            break;

            default:
            break;
        }
        switch(BuffSelect.ButtonBuff3){
            case 0:
            ButtonSelectTextExp3.text = "ゴールドを100手に入れる";
            break;

            case 1:
            ButtonSelectTextExp3.text = "Firewallを手に入れる";
            break;

            case 2:
            ButtonSelectTextExp3.text = "Canonを手に入れる";
            break;
            case 3:
            ButtonSelectTextExp3.text = "Pulsarを手に入れる";
            break;

            case 4:
            ButtonSelectTextExp3.text = "全てのトラップのダメージを上昇させる";
            break;

            case 5:
            ButtonSelectTextExp3.text = "全てのトラップのダメージを上昇させる";
            break;
            
            case 6:
            ButtonSelectTextExp3.text = "全てのトラップのダメージ範囲を拡大させる";
            break;

            case 7:
            ButtonSelectTextExp3.text = "全てのトラップのダメージ間隔を減少させる";
            break;

            case 8:
            ButtonSelectTextExp3.text = "全てのトラップのダメージ範囲を拡大させる";
            break;

            case 9:
            ButtonSelectTextExp3.text = "全てのトラップのダメージを上昇させる";
            break;

            case 10:
            ButtonSelectTextExp3.text = "全てのトラップのダメージ間隔を減少させる";
            break;

            case 11:
            ButtonSelectTextExp3.text = "Firewallが継続的にダメージを与えるデバフを獲得し、さらにデバフのダメージを上昇させる";
            break;

            case 12:
            ButtonSelectTextExp3.text = "Firewallが継続的にダメージを与えるデバフを獲得し、さらにFirewallのダメージを上昇させる";
            break;

            case 13:
            ButtonSelectTextExp3.text = "Firewallが継続的にダメージを与えるデバフを獲得し、さらにデバフのダメージ間隔を減少させる";
            break;

            case 14:
            ButtonSelectTextExp3.text = "Canonが着弾した周りの敵にも半分のダメージを与え、さらにCanonのダメージを上昇させる";
            break;

            case 15:
            ButtonSelectTextExp3.text = "Canonが着弾した周りの敵にも半分のダメージを与え、さらにCanonのダメージ範囲を拡大させる";
            break;

            case 16:
            ButtonSelectTextExp3.text = "Canonが着弾した周りの敵にも半分のダメージを与え、さらにCanonのダメージ間隔を減少させる";
            break;

            case 17:
            ButtonSelectTextExp3.text = "Pulsarが敵の移動速度を減少させるデバフを獲得し、さらにPulsarのダメージを上昇させる";
            break;

            case 18:
            ButtonSelectTextExp3.text = "Pulsarが敵の移動速度を減少させるデバフを獲得し、さらにデバフの継続時間を延長させる";
            break;

            case 19:
            ButtonSelectTextExp3.text = "Pulsarが敵の移動速度を減少させるデバフを獲得し、さらにデバフの効果量を上昇させる";
            break;

            case 20:
            ButtonSelectTextExp3.text = "Firewallのダメージを大きく上昇させるが、CanonとPulsarのダメージを減少させる";
            break;

            case 21:
            ButtonSelectTextExp3.text = "全てのトラップのダメージを上昇させる";
            break;

            case 22:
            ButtonSelectTextExp3.text = "Canonのダメージを大きく上昇させるが、ダメージ間隔を延長させる";
            break;

            case 23:
            ButtonSelectTextExp3.text = "全てのトラップのダメージ間隔を減少させる";
            break;

            case 24:
            ButtonSelectTextExp3.text = "Pulsarのダメージを大きく上昇させるが、ダメージ範囲を縮小させる";
            break;

            case 25:
            ButtonSelectTextExp3.text = "全てのトラップのダメージ範囲を拡大させる";
            break;

            case 26:
            ButtonSelectTextExp3.text = "ゴールドを150手に入れる";
            break;

            case 27:
            ButtonSelectTextExp3.text = "ゴールドを300手に入れるが、耐久値を1減少させる";
            break;

            case 28:
            ButtonSelectTextExp3.text = "耐久値を1回復させる";
            break;

            case 29:
            ButtonSelectTextExp3.text = "ゴールドを100手に入れる";
            break;

            default:
            break;
        }
    }
}
