using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class GameManager : MonoBehaviour
{

    public int clicks = 0;
    public TMP_Text clcikText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        clcikText.text = "Clicks: " + clicks;
    }

    public void Click() {
        clicks++;
    }
}
