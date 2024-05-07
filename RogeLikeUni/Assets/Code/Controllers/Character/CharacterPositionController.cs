using Code.Views.Character;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

namespace Code.Controllers.Character
{
    public class CharacterPositionController: ICharacterPositionController
    {
        private CharacterView _characterView;
        private GameObject _spawnPoint;
        private bool _isActive;
        
        [Inject]
        public void Construct([Inject(Id = "PlayerSpawnPoint")] GameObject playerSpawnPoint, CharacterView characterView)
        {
            _spawnPoint = playerSpawnPoint;
            _characterView = characterView;
        }
        public void Awake()
        {
            _characterView.transform.position += _spawnPoint.transform.position;
        }

        public void Execute()
        {
            if (!_isActive)
            {
                return;
            }
        }

        public void Activate()
        {
            _isActive = true;
        }

        public void Deactivate()
        {
            _isActive = false;
        }

        public bool IsActive => _isActive;
    }
}