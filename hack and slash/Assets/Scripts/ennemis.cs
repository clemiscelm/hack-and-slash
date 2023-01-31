using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ennemis : MonoBehaviour
{

    public GameObject goldManager;
    public float pv = 15;
    public float speed = 1;
    public Slider slider;
    public int prix = 10;
    public bool tr = false;
    public GameObject player;
    public Rigidbody2D rb;
    public int dmg = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        goldManager = GameObject.FindGameObjectWithTag("Gold");
        slider = GetComponentInChildren<Slider>();
        slider.maxValue = pv;
        slider.value = pv;
        player = GameObject.FindGameObjectWithTag("Player");
        rb = gameObject.GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        follow();

    }
    // Update is called once per frame
    void Update()
    {
        if(pv == slider.maxValue)
        {
            slider.gameObject.SetActive(false);
        }
        else
            slider.gameObject.SetActive(true);

        if (tr == true)
            getHit(2);
    }
    public void getHit(float dmg)
    {
        pv -= dmg;
        if(pv <= 0)
        {
            this.gameObject.SetActive(false);
            goldManager.GetComponent<goldManager>().rich(prix);
        }

        slider.value = pv;
        tr = false;
        
        
    }

    public void follow()
    {
        float dir = (player.transform.position.x - this.transform.position.x);

        Vector3 newPos = new Vector3(dir, this.transform.position.y, this.transform.position.z).normalized;

        transform.Translate(newPos * Time.deltaTime * speed);
    }
    public void push(Vector2 force)
    {
        rb.AddForce(force);
    }
  
}
