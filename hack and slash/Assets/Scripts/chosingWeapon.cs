using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chosingWeapon : MonoBehaviour
{

    public weapon weapon;
    public void hache()
    {
        weapon.currentWeapon = "mage ";
        SceneManager.LoadScene(1);
    }
    public void faux()
    {
        weapon.currentWeapon = "faux ";
        SceneManager.LoadScene(1);
    }
    public void poings()
    {
        weapon.currentWeapon = "poings ";
        SceneManager.LoadScene(1);
    }
    public void epee()
    {
        weapon.currentWeapon = "epee ";
        SceneManager.LoadScene(1);
    }
}
