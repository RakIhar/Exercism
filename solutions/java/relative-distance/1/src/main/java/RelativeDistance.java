import java.util.*;

class RelativeDistance {

    Map<String, List<String>> graph = new HashMap<>();

    RelativeDistance(Map<String, List<String>>  familyTree) {
        converseTreeToGraph(familyTree);
    }

    int degreeOfSeparation(String personA, String personB) {
        if (personA.equals(personB))
            return 0;
        if (!graph.containsKey(personA) || !graph.containsKey(personB))
            return -1;

        Map<String, Integer> distances = new HashMap<>();
        distances.put(personA, 0);
        Queue<String> queue = new ArrayDeque<>();
        queue.add(personA);

        while (!queue.isEmpty()) {
            String curPerson = queue.remove();
            int curDistance = distances.get(curPerson);
            for (String neighbor : graph.get(curPerson)) {
                if (neighbor.equals(personB))
                    return curDistance + 1;

                if (!distances.containsKey(neighbor)) {
                    distances.put(neighbor, curDistance + 1);
                    queue.add(neighbor);
                }
            }
        }

        return -1;
    }

    //связать братьев и сестер, связать детей с их предками
    void converseTreeToGraph(Map<String, List<String>>  familyTree) {
        for (var parentChildrenPair : familyTree.entrySet()) {
            String parent = parentChildrenPair.getKey();
            List<String> children = parentChildrenPair.getValue();

            if (!graph.containsKey(parent))
                graph.put(parent, new ArrayList<>());
            List<String> parNeighbors = graph.get(parent);
            parNeighbors.addAll(children);

            for (String child : parentChildrenPair.getValue()) {
                //создаем вершину для ребенка
                if (!graph.containsKey(child))
                    graph.put(child, new ArrayList<>());

                List<String> neighbors = graph.get(child);
                neighbors.add(parent);
                neighbors.addAll(children);
            }
        }

    }
}