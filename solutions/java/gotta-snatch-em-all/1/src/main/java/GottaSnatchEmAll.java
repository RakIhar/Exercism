import java.util.*;
import java.util.stream.Collectors;

class GottaSnatchEmAll {

    static Set<String> newCollection(List<String> cards) {
        return new HashSet<>(cards);
    }

    static boolean addCard(String card, Set<String> collection) {
        return collection.add(card);
    }

    static boolean canTrade(Set<String> myCollection, Set<String> theirCollection) {
        if (myCollection.isEmpty() ||
                theirCollection.isEmpty() ||
                myCollection.containsAll(theirCollection) ||
                theirCollection.containsAll(myCollection))
            return false;
        return true;
    }

    static Set<String> commonCards(List<Set<String>> collections) {
        if (collections == null || collections.isEmpty()) {
            return Collections.emptySet();
        }
        
        Set<String> result = new HashSet<>(collections.getFirst());

        for (Set<String> set : collections) {
            result.retainAll(set);
        }

        return result;
    }

    static Set<String> allCards(List<Set<String>> collections) {
        return collections.stream().flatMap(Collection::stream).collect(Collectors.toSet());
    }
}
