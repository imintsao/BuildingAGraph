using UnityEngine;

using static UnityEngine.Mathf;// implicitly using a type 

public static class FunctionLibraryImin //ok,it is "static". so it let us
    // to use

{
    public static float Wave(float x, float t)//ok,public + static, 
        // float means it can produce a result
        //put float into parameter list, so it will be just like for the
        //mathematical function.
    {   //return Mathf.Sin(Mathf.PI * (x + t));
        return Sin(PI * (x + t));
        // now we are inside the method!
        // "return" to return a float value
    }
    public static float MultiWave (float x, float t)//A Second Function
    {
        //return Sin(PI * (x + t));
        //float y = Sin(PI * (x + t));
        float y = Sin(PI * (x + 0.5f * t));
        //y += Sin(2f * PI * (x + t)) / 2f;
        y += 0.5f * Sin(2f * PI * (x + t));
        return y / 1.5f; 
    }
    public static float Ripple (float x, float t)
    {
        float d = Abs(x);
        float y = Sin(PI * (4f * d -t));
        return y / (1f + 10f * d);
    }

}