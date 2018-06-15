﻿using UnityEngine;

namespace Svelto.ECS.Example.Parallelism
{
#if FOURTH_TIER_EXAMPLE
    public struct BoidEntityView : IEntityStruct
    {
        public Vector3 position;
        public EGID ID { get; set; }
    }
#else
    public class BoidEntityView : EntityView
    {
        public IBoidComponent entityView;
    }
#endif
}