using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecimento : MonoBehaviour
{
    public float tempoDesaparecimento = 1f; // Tempo em segundos para o objeto desaparecer completamente
    private Renderer rendererObjeto;
    private Color corInicial;

    void Start()
    {
        rendererObjeto = GetComponent<Renderer>();
        corInicial = rendererObjeto.material.color;
        Invoke("Desaparecer", tempoDesaparecimento);
    }

    void Desaparecer()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float tempoDecorrido = 0f;
        while (tempoDecorrido < tempoDesaparecimento)
        {
            float alpha = Mathf.Lerp(1f, 0f, tempoDecorrido / tempoDesaparecimento);
            Color novaCor = new Color(corInicial.r, corInicial.g, corInicial.b, alpha);
            rendererObjeto.material.color = novaCor;
            tempoDecorrido += Time.deltaTime;
            yield return null;
        }
        // Garantir que a cor final seja completamente transparente
        rendererObjeto.material.color = new Color(corInicial.r, corInicial.g, corInicial.b, 0f);
        // Opcional: Destruir o objeto após desaparecer completamente
        // Destroy(gameObject);
    }
}