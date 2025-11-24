// Copyright (c) Meta Platforms, Inc. and affiliates.

using Meta.XR.Samples;
using UnityEngine;

namespace TheWorldBeyond.SamplePrefabs
{
    [MetaCodeSample("TheWorldBeyond")]
    public class SelfDestruct : MonoBehaviour
    {
        public float SelfDestructionTimer = 5.0f;

        private void Update()
        {
            SelfDestructionTimer -= Time.deltaTime;
            if (SelfDestructionTimer <= 0.0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
