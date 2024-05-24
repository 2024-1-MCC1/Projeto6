using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class caminhao : MonoBehaviour
{
    public Transform destination;
    public float speed = 5f;
    public int pontuacao_final = 0;
    public Transform final_destination;
    private void Update()
    {
        if (destination != null)
        {
            Vector3 direction = (destination.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, destination.position) < 0.1f)
            {
                //Debug.Log("Caminhao chegou no destino");
                // SetNewDestination();
                destination = null;
                StartCoroutine(saida_caminhao());
            }
        }
    }

    IEnumerator saida_caminhao()
    {

        yield return new WaitForSeconds(30);
        destination = final_destination;
    }
    void GameOver()
    {
        SceneManager.LoadScene(2);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            //Debug.Log("Depositou");
            pontuacao_final = controladordepontuacao.Pontuacao;
            controladordepontuacao.Pontuacao = 0;
            
        }
        else if (other.gameObject.CompareTag("Destino_Final"))
        {
            Debug.Log("Chegou");
            if (pontuacao_final >= 36)
            {
                Ganhou();
            }
            else
            {
                GameOver();
            }
        }
       
        
        //Destroy(trigo);
        //if (itens_coletados >= Pontuacao)
        //{
        //    Ganhou();
        //}


    }

    void Ganhou()
    {
        
        Debug.Log("Ganhou");
        SceneManager.LoadScene(3);
    }

        
    /*
    private void SetNewDestination()
    {
        float randomX = Random.Range(-10f, 10f);
        float randomZ = Random.Range(-10, 10f);
        destination.position = new Vector3(randomX,0f,randomZ);
    }
    */
}
    