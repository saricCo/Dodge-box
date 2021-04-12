using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScripta : MonoBehaviour
{
    public GameObject zidovi;
    Vector3 pocetnaPozicijaPlejera;
    List<Transform> listaLeva = new List<Transform>();
    List<Transform> listaDesna = new List<Transform>();
    void Start()
    {
        pocetnaPozicijaPlejera = this.transform.position;
        Debug.Log(zidovi.GetComponentsInChildren<Transform>());
        foreach (Transform t in zidovi.GetComponentsInChildren<Transform>())
        {
          
            if (t.childCount == 0 && t.name.Contains("kvadrat"))
            {
                Debug.Log(t.parent.parent.parent.name);
                if (t.parent.parent.parent.name== "leva")
                {
                    listaLeva.Add(t);

                }

                else if (t.parent.parent.parent.name == "desna")
                {
                    listaDesna.Add(t);

                }

            }


        }
        changePosition(getRandomList(listaLeva), true);
        changePosition(getRandomList(listaDesna), false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 30);
        if (this.transform.position.z > 540)
            this.transform.position = pocetnaPozicijaPlejera;
        
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

