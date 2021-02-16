using UnityEngine;

namespace Code.Engine.Areas
{
    public class GizmoDrawer : MonoBehaviour
    {
        [SerializeField] private GizmoType gizmoType = GizmoType.Always;

        private void OnDrawGizmos()
        {
            if (gizmoType == GizmoType.Always)
            {
                Draw();
            }
        }

        private void OnDrawGizmosSelected()
        {
            if (gizmoType == GizmoType.Selected)
            {
                Draw();
            }
        }

        public virtual void Draw()
        {
        }
    }
}