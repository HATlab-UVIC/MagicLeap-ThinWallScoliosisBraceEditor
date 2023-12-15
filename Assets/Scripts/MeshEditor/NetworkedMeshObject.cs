using ExitGames.Client.Photon.StructWrapping;
using Fusion;
using UnityEngine;

public class NetworkedMeshObject : NetworkBehaviour {

    private MeshManipulator meshManipulator;

    [Networked, Capacity( 100 )] NetworkArray<Vector3> NetworkedVertices { get; }

    private Vector3[] movedVertices;


    public virtual bool HasControl => Object.HasStateAuthority;

    private void Start () {

        meshManipulator = GetComponent<MeshManipulator>();

    }

    public override void Spawned () {
        base.Spawned();

        meshManipulator = GetComponent<MeshManipulator>();
    }

    public override void FixedUpdateNetwork () {
        if ( HasControl ) {
     
                for ( int i = 0; i < meshManipulator.networkedmovedvertices.Length; i++ ) {
                    NetworkedVertices.Set( i, meshManipulator.networkedmovedvertices[i]);
                }
        }
        
    }

    public override void Render () {
            // Apply mesh modifications received from the network
            for ( int i = 0; i < NetworkedVertices.Length; i++ ) {
                movedVertices[i] = NetworkedVertices.Get(i);
            }

            meshManipulator.MoveVertices( movedVertices );

    }
}


