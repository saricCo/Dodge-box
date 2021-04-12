using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject player;
    List<Transform> listaLeva= new List<Transform>();
    List<Transform> listaDesna= new List<Transform>();
    void Start()
    {
        Destroy(this.gameObject,6);
        foreach (Transform t in this.GetComponentsInChildren<Transform>())
        {
            if (t.childCount == 0 && t.name != "Red")
            {
                if (t.parent.name == "leva")  {
                        listaLeva.Add(t);
                   
                    }
              
                else if(t.parent.name == "desna")
                    {
                        listaDesna.Add(t);
                   
                }
               
            }


        }
        changePosition(getRandomList(listaLeva), true);
        changePosition(getRandomList(listaDesna), false);
    }


    public void changePosition(List<Transform> lista1, bool strana)
    {
        foreach (Transform t in lista1)
        {
            int number = Random.Range(1000, 5000);
            if (strana)
                t.GetComponent<Rigidbody>().AddForce(number * Time.deltaTime, 0, 0);
            else
                t.GetComponent<Rigidbody>().AddForce(-number * Time.deltaTime, 0, 0);
            
        }
    }

    public List<Transform> getRandomList(List<Transform> lista1)
    {
        List<Transform> lista = new List<Transform>();
        int number;
        foreach (Transform t in lista1)
        {
            number = Random.Range(0, 10);
            if (number == 1)
            {
                lista.Add(t);
            }
        }
        return lista;
    }
}
