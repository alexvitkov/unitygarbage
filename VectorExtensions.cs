using UnityEngine;

public static class VectorExtensions {

    public static Vector3 WithX(this Vector3 v, float x)
        => new Vector3(x, v.y, v.z);

    public static Vector3 WithY(this Vector3 v, float y)
        => new Vector3(v.x, y, v.z);

    public static Vector3 WithZ(this Vector3 v, float z)
        => new Vector3(v.x, v.y, z);

    public static Vector2 WithMagnitude(this Vector3 vec, float mag)
        => vec.normalized * mag;



    public static Vector2 WithX(this Vector2 v, float x)
        => new Vector2(x, v.y);

    public static Vector2 WithY(this Vector2 v, float y)
        => new Vector2(v.x, y);
    
    public static Vector3 WithZ(this Vector2 v, float z)
        => new Vector3(v.x, v.y, z);

    public static Vector2 WithMagnitude(this Vector2 vec, float mag)
        => vec.normalized * mag;
        
    public static float ToAngle(this Vector2 dir) 
        => Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

}
