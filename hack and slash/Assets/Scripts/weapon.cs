using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public string currentWeapon;
    public epee epee = new epee(4, 7, 1, 12);
    public mage mage = new mage(3, 10, 2, 10);
    public faux faux = new faux(7, 4, 1.5f, 8);
    public poings poings = new poings(10, 3, 0.5f, 15);
    public Dictionary<string, float> dic = new Dictionary<string, float>();

    void Start()
    {
        dic["epee V"] = epee.speed;
        dic["epee F"] = epee.force;
        dic["epee R"] = epee.range;
        dic["epee L"] = epee.pv;
        dic["mage V"] = mage.speed;
        dic["mage F"] = mage.force;
        dic["mage L"] = mage.pv;
        dic["mage R"] = mage.range;
        dic["poings V"] = poings.speed; 
        dic["poings F"] = poings.force;
        dic["poings R"] = poings.range;
        dic["poings L"] = poings.pv;
        dic["faux V"] = faux.speed;
        dic["faux F"] = faux.force;
        dic["faux R"] = faux.range;
        dic["faux L"] = faux.pv;
    }
    
}
public struct epee
{
    
    public epee(float Speed, float Force, float Range, float Pv)
    {
        speed = Speed;
        force = Force;
        range = Range;
        pv = Pv;
    }
    public float speed { get; }
    public float force { get; }
    public float range { get; }
    public float pv { get; }


}

public struct mage
{
    public mage(float Speed, float Force, float Range, float Pv)
    {
        speed = Speed;
        force = Force;
        range = Range;
        pv = Pv;
    }
    public float speed { get; }
    public float force { get; }
    public float range { get; }
    public float pv { get; }
}
public struct poings
{
    public poings(float Speed, float Force, float Range, float Pv)
    {
        speed = Speed;
        force = Force;
        range = Range;
        pv = Pv;
    }
    public float speed { get; }
    public float force { get; }
    public float range { get; }
    public float pv { get; }
}
public struct faux
{
    public faux(float Speed, float Force, float Range, float Pv)
    {
        speed = Speed;
        force = Force;
        range = Range;
        pv = Pv;
    }
    public float speed { get; }
    public float force { get; }
    public float range { get; }
    public float pv { get; }
}


