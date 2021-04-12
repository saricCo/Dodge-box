using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
public class DBManager : MonoBehaviour
{

   
    Text theText;
    // Start is called before the first frame update
    void Start()
    {
        // Set up the Editor before calling into the realtime database.
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://endlesstiles-165a1.firebaseio.com/");

        // Get the root reference location of the database.
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        theText = GameObject.Find("nesto").GetComponent<Text>();
        vratiScore();
    }

    void vratiScore()
    {
        FirebaseDatabase.DefaultInstance
      .GetReference("Score")
      .GetValueAsync().ContinueWith(task => {
          if (task.IsFaulted)
          {
              // Handle the error...
          }
          else if (task.IsCompleted)
          {
             
              DataSnapshot snapshot = task.Result;
              Debug.Log(snapshot.Value);
              theText.text = "ha3sh";
              theText.fontSize = 28;
          //  max.text+=snapshot.Value + "";
          }
      });
    }
    // Update is called once per frame
    void Update()
    {
        
            
           
          
        
    }
}
