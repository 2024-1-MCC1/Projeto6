using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class interação : MonoBehaviour
{
    interação playerControler;
    
    public GameObject trigo;
    public int Pontuacao = 36;
    private int itens_coletados = 0; 
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        controladordepontuacao.Pontuacao++;
        //Debug.Log("coletou");
        Destroy(trigo);
    
       

    }
    
        

}
   
