using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldManager : MonoBehaviour
{
    [SerializeField] int gold;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        gold = 0;
    }

   public int getGolds()
   {
        return gold;
   }

    public void achete(int price, char x)
    {
        gold -= price;
        if(x == 'a') //attack
        {

        }
        else if (x == 's')//speed
        {

        }
        else if (x == 'p')//pv
        {

        }
        else if (x == 'r')//range
        {

        }
    }

    public void rich(int golds)
    {
        gold += golds; 
    }
}
