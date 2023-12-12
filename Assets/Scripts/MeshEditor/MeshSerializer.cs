using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using Fusion;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Linq;

public class MeshSerializer : NetworkBehaviour
{
    
    public Mesh NetworkedDeformedMesh { get; set; }

    [Networked]
    NetworkArray<Vector3[]> networkedVertices { get; set; } 
       
 

    [Rpc(RpcSources.All, RpcTargets.StateAuthority)]
    public void SerializedMeshManipulated ( byte[] serializedData) {

          
            Vector3[] meshData = DeserializeMeshData( serializedData );

            networkedVertices = NetworkArray<Vector3>. meshData;

            NetworkedDeformedMesh.vertices = meshData;
            NetworkedDeformedMesh.RecalculateNormals();
            NetworkedDeformedMesh.RecalculateBounds();
           
    }



    public Vector3[] DeserializeMeshData ( byte[] serializedData ) {
        // Deserialize mesh data from byte array (example: using BinaryFormatter)
        // Make sure to adapt this based on your specific deserialization logic
        BinaryFormatter bf = new BinaryFormatter();
        using ( MemoryStream ms = new MemoryStream( serializedData ) ) {
            return (Vector3[])bf.Deserialize( ms );
        }
    }
}
