using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        pozicijaPlejera = transform.position.z;
    }
    public GameObject neki1;
  List<GameObject> listaObj=new List<GameObject>();

    // Update is called once per frame
    double pozicijaPlejera;
    float sledecaPozicija =  68.4f;
    
    void Update()
    {
        if(pozicijaPlejera+12< transform.position.z)
        {
            pozicijaPlejera = transform.position.z;
            sledecaPozicija += 12f;
       
             listaObj.Add(Instantiate(neki1, new Vector3(-7.3f, transform.position.y, sledecaPozicija), neki1.transform.rotation));
               
           

        }
        

        
        //126.4




    }
   
}
