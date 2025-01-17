using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoPhongDijkstra
{
    public class DijkstraAllPaths
    {
        public static (Dictionary<T, List<List<T>>> paths, List<T> visitedOrder) FindAllShortestPathsWithOrder<T>(Dictionary<T, Dictionary<T, int>> graph, T start)
        {
            if (graph == null || !graph.ContainsKey(start))
            {
                return (null, null);
            }

            var distances = new Dictionary<T, int>();
            var paths = new Dictionary<T, List<List<T>>>();
            var priorityQueue = new SortedSet<(int distance, T node)>(Comparer<(int distance, T node)>.Create((x, y) =>
            {
                int distanceComparison = x.distance.CompareTo(y.distance);
                if (distanceComparison != 0) return distanceComparison;
                return Comparer<T>.Default.Compare(x.node, y.node);
            }));
            var visitedOrder = new List<T>();

            foreach (var node in graph.Keys)
            {
                distances[node] = int.MaxValue;
                paths[node] = new List<List<T>>();
            }

            distances[start] = 0;
            paths[start].Add(new List<T> { start });
            priorityQueue.Add((0, start));

            while (priorityQueue.Count > 0)
            {
                var current = priorityQueue.Min;
                priorityQueue.Remove(current);
                int currentDistance = current.distance;
                T currentNode = current.node;

                if (currentDistance > distances[currentNode])
                {
                    continue;
                }

                if (!visitedOrder.Contains(currentNode))
                {
                    visitedOrder.Add(currentNode);
                }

                if (graph.ContainsKey(currentNode))
                {
                    foreach (var neighbor in graph[currentNode])
                    {
                        int distance = currentDistance + neighbor.Value;

                        if (distance < distances[neighbor.Key])
                        {
                            distances[neighbor.Key] = distance;
                            paths[neighbor.Key].Clear();
                            foreach (var path in paths[currentNode])
                            {
                                paths[neighbor.Key].Add(path.Concat(new[] { neighbor.Key }).ToList());
                            }
                            priorityQueue.Remove((distances[neighbor.Key], neighbor.Key)); 
                            priorityQueue.Add((distance, neighbor.Key)); 
                        }
                        else if (distance == distances[neighbor.Key])
                        {
                            foreach (var path in paths[currentNode])
                            {
                                paths[neighbor.Key].Add(path.Concat(new[] { neighbor.Key }).ToList());
                            }
                        }
                    }
                }
            }

            return (paths, visitedOrder);
        }
    }
}
