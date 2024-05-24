using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladordepontuacao 
{
   private static int pontuacao;

    public static int Pontuacao
    {
        get { return pontuacao; } 
        set
        {
            pontuacao = value;
            if (pontuacao < 0)
            {
                pontuacao = 0;
            }
        }
    }

    
}
