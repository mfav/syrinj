﻿using Syrinj.Attributes;
using Syrinj.Injection;
using UnityEngine;

namespace Syrinj.Resolvers
{
    public class FindObjectOfTypeResolver : IResolver
    {
        public object Resolve(MonoBehaviour monoBehaviour, Injectable injectable)
        {
            return Object.FindObjectOfType(((FindObjectOfTypeAttribute) injectable.Attribute).ComponentType);
        }
    }
}