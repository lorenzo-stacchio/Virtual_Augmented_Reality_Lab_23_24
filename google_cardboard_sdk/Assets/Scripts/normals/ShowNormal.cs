using UnityEditor;
using UnityEngine;


public class ShowNormal : MonoBehaviour
{
    #if UNITY_EDITOR // AVOID COMPILING IT FOR ANDROID, IT WOULDN'T COMPILE!
    public bool isShowNormal;
    public Color color = Color.yellow;
    public float normalsLength = 1f;

    private void OnDrawGizmosSelected()
    {
        if (!isShowNormal) return;

        if (!TryGetComponent<MeshFilter>(out var meshFilter)) return;

        var mesh = meshFilter.mesh;
        if (mesh == null) return;

        var defaultColor = Handles.color;
        Handles.matrix = transform.localToWorldMatrix;
        Handles.color = color;
        var verts = mesh.vertices;
        var normals = mesh.normals;
        int len = mesh.vertexCount;

        for (int i = 0; i < len; i++)
        {
            Handles.DrawLine(verts[i], verts[i] + normals[i] * normalsLength);
            // if(i==0){
            //    Debug.Log(normals[i]);     
            // }         

        }

        Handles.color = defaultColor;
    }
    #endif  // !UNITY_EDITOR
}

