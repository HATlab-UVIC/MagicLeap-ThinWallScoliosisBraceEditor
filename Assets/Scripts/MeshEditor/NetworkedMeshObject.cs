using ExitGames.Client.Photon.StructWrapping;
using Fusion;
using UnityEngine;


//[Networked]
public class NetworkedMeshObject : NetworkBehaviour {
    //private MeshFilter meshFilter;
    private MeshManipulator meshDeformer;

    [Networked, Capacity( 500 )]
    NetworkArray<Vector3> NetworkedVertices { get; }

    // Add other networked properties as needed

    // StateAuthority means we can control the mesh modifications.
    public virtual bool HasControl => Object.HasStateAuthority;

    private void Start () {
        //meshFilter = GetComponent<MeshFilter>();
        meshDeformer = GetComponent<MeshManipulator>();

        // Initialize other variables as needed
    }

    public override void Spawned () {
        base.Spawned();

        //meshFilter = GetComponent<MeshFilter>();
        meshDeformer = GetComponent<MeshManipulator>();

        // Initialize other variables as needed

        // Initialize the networked vertices based on the initial mesh
        for ( int i = 0; i < meshDeformer.movedVertexPositions.Length; i++ ) {
            NetworkedVertices.Set( i, meshDeformer.movedVertexPositions[ i ] );
        }


    }

    public override void FixedUpdateNetwork () {
        // If we can control the mesh modifications
        if ( HasControl ) {
            // Update the networked vertices based on mesh modifications
            for ( int i = 0; i < meshDeformer.movedVertexPositions.Length; i++ ) {
                NetworkedVertices.Set( i, meshDeformer.movedVertexPositions[ i ] );
            }
        }
    }

    public override void Render () {
        if ( !HasControl ) {
            // Apply mesh modifications received from the network
            for ( int i = 0; i < meshDeformer.movedVertexPositions.Length; i++ ) {
                NetworkedVertices.Set( i, meshDeformer.movedVertexPositions[ i ] );
            }
            meshDeformer.MoveVertices( meshDeformer.movedVertexPositions );
        }
    }
}


