using UnityEngine;

namespace GoToApps.ObjectsPool
{
    /// <summary>
    /// Poolable item abstract wrapper.
    /// </summary>
    public abstract class PoolableItem : MonoBehaviour
    {
        private PoolManager _pool;
        
        /// <summary>
        /// Set parent object pool.
        /// </summary>
        /// <param name="pool">Pool manager</param>
        public void SetPool(PoolManager pool) => _pool = pool;
        
        /// <summary>
        /// Return game object to parent pool.
        /// </summary>
        public void ReturnToPool() => _pool.AddItemToPool(this);
    }
}