using Code.Models.Character;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

namespace Code.Views.Character
{
    public class CharacterView: MonoBehaviour
    {
        [SerializeField]
        private Animator _animator;
        private CharacterModel _model = new CharacterModel();

        public Animator Animator => _animator;
    }
}