using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Map : MonoBehaviour {

    public Map_cell MapCell;
    public GameObject deleteObject;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void MapGenerate(int width , int height) {
        if (deleteObject != null) {
            Destroy(deleteObject);
        }
        for (var y = 0; y < height; ++y) {
            for (var x = 0; x < width; ++x) {
                Map_cell cell;
                cell = Instantiate(MapCell);
                cell.gameObject.SetActive(true);
                cell.transform.SetParent(transform);
                cell.setPoint(x , y);
            }
        }
    }

    public List<PointandValue> getMoveCostToCells(Map_cell from) {
        var infos = new List<PointandValue>();
        infos.Add(new PointandValue(from.X, from.Y, 0));
        var i = 0;
        while (true)
        {
            var appendInfo = new List<PointandValue>();
            for (int a = 0; a < appendInfo.Count; ++a)
            {
                // 多分リストが入っていない for文とforeach文の違いに着目すべき？
                var calcTargetInfo = infos.FindAll(info => info.value == i);
                //var calcTargetPoint = calcTargetInfo.point;
            }
            foreach (var calcTargetInfo_foreach in infos.Where(info => info.value == i)) {
                var calcTargetPoint_foreach =  calcTargetInfo_foreach.point;
                var aroundCellsPoints_foreach = new Point[] {
                    new Point(calcTargetPoint_foreach.x - 1, calcTargetPoint_foreach.y),
                    new Point(calcTargetPoint_foreach.x + 1, calcTargetPoint_foreach.y),
                    new Point(calcTargetPoint_foreach.x, calcTargetPoint_foreach.y - 1),
                    new Point(calcTargetPoint_foreach.x, calcTargetPoint_foreach.y + 1),
                };
            }
        }
        return null;
    }

    //PointandValue[] enableMoveRange(Map_cell cells, int moveAmount) {
    //    var info = new List<PointandValue>();
    //    info.Add(new PointandValue(cells.X, cells.Y, moveAmount));
    //    return null;
    //}

    public class PointandValue {
        public readonly Point point;
        public readonly int value;
        public PointandValue(int x, int y, int value) {
            this.point = new Point(x , y);
            this.value = value;
        }
    }

    public class Point{
        public readonly int x;
        public readonly int y;
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
}
