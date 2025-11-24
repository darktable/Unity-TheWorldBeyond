// Copyright (c) Meta Platforms, Inc. and affiliates.

using Meta.XR.Samples;
using UnityEngine;

namespace TheWorldBeyond.Environment
{
    [MetaCodeSample("TheWorldBeyond")]
    public class ForegroundObject : MonoBehaviour
    {
        // just a script identifier to know this object should be culled from the room
        public Transform ShadowObject;
    }
}
