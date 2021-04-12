    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using UnityEngine.UI;
public class moving : MonoBehaviour
{
   
  
    void Start()
    {

      //  lastPos = transform.position.z;
        //  leftSide3 = Instantiate(prefab, new Vector3(leftSide2.transform.position.x, leftSide2.transform.position.y, leftSide2.transform.position.z + 64f), prefab.transform.rotation);
        //  rightSide3 = Instantiate(prefab, new Vector3(rightSide2.transform.position.x,rightSide2.transform.position.y, rightSide2.transform.position.z + 64f), Quaternion.Euler(new Vector3(0, 0, 90)));


       // List<GameObject> lista2 = new List<GameObject>();



        // listaLeva1.Add(new Vector3(t.position.x, t.position.y, t.position.z)) ;
        // Debug.Log(leftSide.transform.GetChild(1).transform.childCount);
        /*    for (int i = 0; i < leftSide.transform.GetChild(1).transform.childCount; i++)
            {   
                GameObject child = leftSide.transform.GetChild(1).transform.GetChild(i).gameObject;//sranje
                if (child.name != "NekiVeci" && child.name != "boja")
                {
              //  Debug.Log("Nesto"); transform.hierarchyCount
                    listaLevihObj.Add(child);
                    float broj = child.transform.localPosition.z;
                    listaLeviObjVec.Add(broj);

                }

            }

            /*  if (t.childCount == 0)
              {

                  listaLeva1.Add(t);

              }*/




        // listaLeva1.Add(new Vector3(t.position.x, t.position.y, t.position.z)) ;
        /*
        for (int i = 0; i < leftSide2.transform.GetChild(1).transform.childCount; i++)
        {
        GameObject child = leftSide2.transform.GetChild(1).transform.GetChild(i).gameObject;//sranje
        if (child.name != "NekiVeci" && child.name != "boja")
        {
            //  Debug.Log("Nesto"); transform.hierarchyCount
            listaDesnihObj.Add(child);
            float broj = child.transform.localPosition.z;
            listaDesnihObjVec.Add(broj);

        }

        // changePosition(getRandomList(listaLeva1));
    }

        */


    }

    /*
    public void changePosition(List<Transform> lista1,bool strana)
    {

        foreach (Transform t in lista1)
        {
          
            int number = Random.Range(1000,5000);
            if(strana)
          t.GetComponent<Rigidbody>().AddForce( number* Time.deltaTime, 0, 0);
            else
                t.GetComponent<Rigidbody>().AddForce(-number * Time.deltaTime, 0, 0);
            // t.position = t.position + new Vector3(200 * Time.deltaTime, 0, 0);

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

    // Update is called once per frame
    bool first = false;
    GameObject leftSide3;
    GameObject rightSide3;
    double lastPos;



    GameObject levaNeki1;



    */



   
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *22.5f);
      /*  if (transform.position.z > leftSide.transform.position.z + 30)
        {
            int i = 0;
            foreach(GameObject go in listaLevihObj)
            {

                float tren = listaLeviObjVec[i];
                go.transform.localPosition = new Vector3(go.transform.localPosition.x,go.transform.localPosition.y,tren);
                go.GetComponent<Rigidbody>().velocity = Vector3.zero;             
                i++;
            }
                leftSide.transform.position = new Vector3(leftSide.transform.position.x, transform.position.y, leftSide.transform.position.z + 127.85f);

           

            foreach (Transform t in leftSide.GetComponentsInChildren<Transform>())
            {
                if (t.childCount == 0 && t.name!="boja")
                {

                    listaLeva1.Add(t);

                }


            }

            changePosition(getRandomList(listaLeva1), true);

        }

        if (transform.position.z > leftSide2.transform.position.z + 30)
        {
            int i = 0;
            Debug.Log("ima gtsx" + listaDesnihObj.Count);
            foreach (GameObject go in listaDesnihObj)
            {
               // Debug.Log(listaDesnihObj.Count);
                float tren = listaDesnihObjVec[i];
                go.transform.localPosition = new Vector3(go.transform.localPosition.x, go.transform.localPosition.y, tren);
                go.GetComponent<Rigidbody>().velocity = Vector3.zero;
                i++;
               
            }
            leftSide2.transform.position = new Vector3(leftSide2.transform.position.x, transform.position.y, leftSide2.transform.position.z + 127.85f);


            foreach (Transform t in leftSide2.GetComponentsInChildren<Transform>())
            {
                if (t.childCount == 0 && t.name != "boja")
                {

                    listaLeva2.Add(t);

                }


            }

            changePosition(getRandomList(listaLeva2), true);

        }

        /*  if (transform.position.z > leftSide.transform.position.z+30)
          {
              Destroy(leftSide);
             leftSide=Instantiate(prefab, new Vector3(leftSide.transform.position.x, transform.position.y, leftSide.transform.position.z+ 191.5f),prefab.transform.rotation);

              listaLeva1 = new List<Transform>();
              foreach (Transform t in leftSide.GetComponentsInChildren<Transform>())
              {
                  if (t.childCount == 0)
                  {
                      listaLeva1.Add(t);
                  }
              }
              changePosition(getRandomList(listaLeva1), true);
          }
         else if(transform.position.z > leftSide2.transform.position.z+30)
          {
              Destroy(leftSide2);
              leftSide2 = Instantiate(prefab, new Vector3(leftSide2.transform.position.x, transform.position.y, leftSide2.transform.position.z + 191.5f), prefab.transform.rotation);
              listaLeva2 = new List<Transform>();
              foreach (Transform t in leftSide2.GetComponentsInChildren<Transform>())
              {
                  if (t.childCount == 0)
                  {

                      listaLeva2.Add(t);

                  }


              }

              changePosition(getRandomList(listaLeva2), true);
          }
          else if (transform.position.z > leftSide3.transform.position.z + 30)
          {

              Destroy(leftSide3);
              leftSide3 = Instantiate(prefab, new Vector3(leftSide2.transform.position.x, transform.position.y, leftSide3.transform.position.z + 191.5f), prefab.transform.rotation);
              List<Transform> listaLeva3 = new List<Transform>();
              foreach (Transform t in leftSide3.GetComponentsInChildren<Transform>())
              {
                  if (t.childCount == 0)
                  {

                      listaLeva3.Add(t);

                  }


              }

              changePosition(getRandomList(listaLeva3), true);
          }


          if (transform.position.z > rightSide.transform.position.z + 30)
          {
              Destroy(rightSide);
              rightSide = Instantiate(prefab, new Vector3(rightSide.transform.position.x, transform.position.y, rightSide.transform.position.z + 191.5f), Quaternion.Euler(new Vector3(0, 0, 90)));
              List<Transform> listaDesna1= new List<Transform>();

              foreach (Transform t in rightSide.GetComponentsInChildren<Transform>())
              {
                  if (t.childCount == 0)
                  {
                      listaDesna1.Add(t);
                  }
              }
              changePosition(getRandomList(listaDesna1),false);
          }
          else if (transform.position.z > rightSide2.transform.position.z + 30)
          {
              Destroy(rightSide2);
             rightSide2 = Instantiate(prefab, new Vector3(rightSide2.transform.position.x, transform.position.y, rightSide2.transform.position.z + 191.5f), Quaternion.Euler(new Vector3(0, 0, 90)));

              List<Transform> listaDesna2 = new List<Transform>();

              listaDesna2 = new List<Transform>();
              foreach (Transform t in rightSide2.GetComponentsInChildren<Transform>())
              {
                  if (t.childCount == 0)
                  {

                      listaDesna2.Add(t);

                  }


              }

              changePosition(getRandomList(listaDesna2), false);
          }

          else if (transform.position.z > rightSide3.transform.position.z + 30)
          {
              Destroy(rightSide3);
              rightSide3 = Instantiate(prefab, new Vector3(rightSide2.transform.position.x, transform.position.y, rightSide3.transform.position.z + 191.5f), Quaternion.Euler(new Vector3(0, 0, 90)));
              List<Transform> listaDesna3 = new List<Transform>();
              foreach (Transform t in rightSide3.GetComponentsInChildren<Transform>())
              {
                  if (t.childCount == 0)
                  {
                      listaDesna3.Add(t);
                  }
              }
              changePosition(getRandomList(listaDesna3), false);
          }



          //if ((transform.position.z > rightSide3.transform.position.z + 30))

              if (lastPos + 12 < transform.position.z)
              {
              lastPos = transform.position.z;
              levaNeki1 Instantiate(neki1, new Vector3(rightSide2.transform.position.x, transform.position.y, rightSide3.transform.position.z + 191.5f), Quaternion.Euler(new Vector3(0, 0, 90)));

          }

          */


        /*

        if (Input.GetKey("a"))
        {
            rb.AddForce(-80 * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(80 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce(0, 80 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(0, -80 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }*/
    }

    bool kraj = false;
    void OnCollisionEnter()
    {



        if (!kraj)
        {
            kraj = true;
       
        ucitajScore();

        StartCoroutine(WaitForIt(3.0F));


        IEnumerator WaitForIt(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            FindObjectOfType<GameManager>().EndGame();
            //Application.Quit();
        }
        }
    }


    
    void ucitajScore()
    {

       

        int max = highscore1.maxScore;

        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://endlesstiles-165a1.firebaseio.com/");

        // Get the root reference location of the database.
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;



        int broj= (int)transform.position.z;
        var myDict = new Dictionary<string, object>
        {
            { "score", broj }
        };
        if (max < broj)
        {   
            Debug.Log(max + " , " + broj);
            reference.UpdateChildrenAsync(myDict);

        }
    }
}
