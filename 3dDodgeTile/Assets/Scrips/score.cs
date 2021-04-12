using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text score1;
    // Update is called once per frame
    void Update()
    {
        score1.text =(int)(player.position.z)+"";
        
    }
}
