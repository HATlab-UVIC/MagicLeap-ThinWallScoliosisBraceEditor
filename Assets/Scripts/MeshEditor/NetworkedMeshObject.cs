using ExitGames.Client.Photon.StructWrapping;
using Fusion;
using UnityEngine;


//[Networked]
public class NetworkedMeshObject : NetworkBehaviour {

    private MeshManipulator meshManipulator;

    [Networked, Capacity( 100 )] NetworkArray<Vector3> NetworkedVertices { get; }

    private Vector3[] movedVertices;

    // Add other networked properties as needed

    // StateAuthority means we can control the mesh modifications.
    public virtual bool HasControl => Object.HasStateAuthority;

    private void Start () {

        meshManipulator = GetComponent<MeshManipulator>();

    }

    public override void Spawned () {
        base.Spawned();

        meshManipulator = GetComponent<MeshManipulator>();

        // Initialize other variables as needed

        // Initialize the networked vertices based on the initial mesh

            

        //*/

    }

    public override void FixedUpdateNetwork () {
        // If we can control the mesh modifications
        if ( HasControl ) {
            // Update the networked vertices based on mesh modifications           
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


