using UnityEngine;

namespace Code.Views.Hub
{
    public class HubView: MonoBehaviour
    {
        [SerializeField] private GameObject _playerSpawnPoint;

        public GameObject PlayerSpawnPoint => _playerSpawnPoint;
    }
}