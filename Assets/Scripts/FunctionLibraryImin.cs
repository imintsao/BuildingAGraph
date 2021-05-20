using UnityEngine;

using static UnityEngine.Mathf;// implicitly using a type 

public static class FunctionLibraryImin //ok,it is "static". so it let us
    // to use

{
    public static float Wave(float x, float z, float t)//ok,public + static, 
        // float means it can produce a result
        //put float into parameter list, so it will be just like for the
        //mathematical function.
    {   //return Mathf.Sin(Mathf.PI * (x + t));
        return Sin(PI * (x + t));
        // now we are inside the method!
        // "return" to return a float value
    }

    public delegate float Function(float x, float z, float t);//a method signature
                                                     //without an implementation
    public enum FunctionName {Wave, MultiWave, Ripple }

    static Function[] functions = { Wave, MultiWave, Ripple };

    public static Function GetFunction (FunctionName name)
    {
        return functions[(int)name];
        //if (index == 0)
        //{
        //    return Wave;
        //}
        //else if (index == 1)
        //{
        //    return MultiWave;
        //}
        //else
        //{
        //    return Ripple;
        //}
    }

    public static float MultiWave (float x, float z, float t)//A Second Function
    {
        //return Sin(PI * (x + t));
        //float y = Sin(PI * (x + t));
        float y = Sin(PI * (x + 0.5f * t));
        //y += Sin(2f * PI * (x + t)) / 2f;
        y += 0.5f * Sin(2f * PI * (x + t));
        return y / 1.5f; 
    }
    public static float Ripple (float x, float z, float t)
    {
        float d = Abs(x);
        float y = Sin(PI * (4f * d - t));  //final result
        return y / (1f + 10f * d);

        //float y = Sin(4f * PI * d);
        //return y;

        
    }

}