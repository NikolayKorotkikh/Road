using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class RoadNetwork : MonoBehaviour {
    public List<CrossRoad> crossRoad;

    public RoadNetwork(List<CrossRoad> crossRoad)
    {
        this.crossRoad = crossRoad;
    }
}
