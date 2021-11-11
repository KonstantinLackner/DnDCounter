using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace DefaultNamespace
{
    public class ListSorter : MonoBehaviour
    {
        private List<GameObject> abilities;

        private GameObject rectView;

        private GameObject protoAbility;

        private void Start()
        {
            rectView = GameObject.Find("RectView");
            protoAbility = GameObject.Find("ProtoAbility");
        }

        private void sortList()
        {
            var result = abilities.OrderBy(attack => attack.GetComponent<Ability>().cooldownRounds).ThenBy(attacks => attacks.GetComponent<Ability>().hero);
            abilities = result.ToList();
        }

        // TODO: Why can I not use the ability as a script for a gameObject?
        private void initList()
        {
            Vector3 initialPostion = protoAbility.transform.position;
            foreach (var ability in abilities)
            {
                GameObject newAbility = Instantiate(protoAbility, initialPostion, Quaternion.identity, rectView.transform);
                newAbility.transform.SetParent(rectView.transform);
                initialPostion.y = initialPostion.y - 120;
                newAbility.AddComponent(ability);
                ability.init();
            }
        }
    }
}