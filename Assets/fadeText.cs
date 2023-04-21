/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeText : MonoBehaviour
{
    // Start is called before the first frame update
	[Serializefield] private CanvasGroep canvasgroep;

    private bool Fadein = false;
    private bool Fadeout = false;
    public float TimetoFade;

    // Update is called once per frame
    void Update()
    {
        if(Fadein)
        {
        	if(canvasgroep.alpha < 1)
        	{
        		canvasgroep.alpha += TimetoFade * Time.deltaTime;
        		if(canvasgroep.alpha >= 1)
        		{
        			Fadein = false;
        		}
        	}
        }

         if(FadeOut)
        {
        	if(canvasgroep.alpha >= 0)
        	{
        		canvasgroep.alpha -= TimetoFade * Time.deltaTime;
        		if(canvasgroep.alpha = 0)
        		{
        			FadeOut = false;
        		}
        	}
        }
    }

    public void FadeIn()
    {
    	Fadein = true;
    }

    public void FadeOut()
    {
    	Fadeout = true;
    }
}
*/