using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
   public void OnMouseDown()
   {
        transform.localScale = new Vector3(0.55f, 0.55f, 0.55f);
        SceneManager.LoadScene("start");
   }
   public void OnMouseUp()
   {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
   }

    // Update is called once per frame

}
