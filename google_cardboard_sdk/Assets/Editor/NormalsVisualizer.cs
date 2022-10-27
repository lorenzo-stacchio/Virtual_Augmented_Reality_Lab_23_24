using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
[CustomEditor(typeof(MeshFilter))]

public class NormalsVisualizer : Editor {

    private const string     EDITOR_PREF_KEY = "_normals_length";
    private       Mesh       mesh;
    private       MeshFilter mf;
    private       Vector3[]  verts;
    private       Vector3[]  normals;
    private       float      normalsLength = 1f;

    private void OnEnable() {
        mf   = target as MeshFilter;
        if (mf != null) {
            mesh = mf.sharedMesh;
        }
        normalsLength = EditorPrefs.GetFloat(EDITOR_PREF_KEY);
    }

    private void OnSceneGUI() {
        if (mesh == null) {
            return;
        }

        Handles.matrix = mf.transform.localToWorldMatrix;
        Handles.color = Color.yellow;
        verts = mesh.vertices;
        normals = mesh.normals;
        int len = mesh.vertexCount;
        
        for (int i = 0; i < len; i++) {
            Handles.DrawLine(verts[i], verts[i] + normals[i] * normalsLength);
        }
    }

    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
        EditorGUI.BeginChangeCheck();
        normalsLength = EditorGUILayout.FloatField("Normals length", normalsLength);
        if (EditorGUI.EndChangeCheck()) {
            EditorPrefs.SetFloat(EDITOR_PREF_KEY, normalsLength);
        }
    }
}