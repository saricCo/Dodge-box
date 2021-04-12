using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using UnityEngine.UI;
public class highscore1 : MonoBehaviour
{


    public static int maxScore;
    Text theText;
    public Text neki;
    // Start is called before the first frame update
    void Start()
    {

        
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://endlesstiles-165a1.firebaseio.com/");

        // Get the root reference location of the database.
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        theText = GameObject.Find("max").GetComponent<Text>();


        FirebaseDatabase.DefaultInstance
      .GetReference("score")
      .GetValueAsync().ContinueWith(task => {
          if (task.IsFaulted)
          {
              // Handle the error...
          }
          else if (task.IsCompleted)
          {
              DataSnapshot snapshot = task.Result;
              Debug.Log(snapshot.Value.ToString());
              maxScore = int.Parse(snapshot.Value.ToString());
              neki.text=snapshot.Value.ToString();
          }
      });




    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
