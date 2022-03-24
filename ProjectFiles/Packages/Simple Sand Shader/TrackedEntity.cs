using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace vEKUGames.SimpleSand
{
    public class TrackedEntity : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody m_rigidbody;
        [SerializeField]
        private Collider m_collider;
        [SerializeField]
        public float m_radius = 0.1f;

        public float Radius { get { return m_radius; } }
        public Vector3 Velocity { get { return m_rigidbody.velocity; } }
        public Vector3 Position { get { return transform.position; ; } }

    }
}
