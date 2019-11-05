using UnityEngine;
using UnityEngine.SceneManagement;
 
 public class baryükleme : MonoBehaviour
 {
     public void LoadNewScene()
     {
        int mainmenu = 1;
         SceneManager.LoadScene(mainmenu);        
     }
 }