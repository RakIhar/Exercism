import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

class ParallelLetterFrequency {
    String[] texts;

    ParallelLetterFrequency(String[] texts) {
        this.texts = texts;
    }

    Map<Character, Integer> countLetters() {
        if (texts == null || texts.length == 0)
            return new HashMap<>();

        int processors = Math.min(Runtime.getRuntime().availableProcessors(), texts.length);

        int countOfTextsPerThread = texts.length / processors; //>= 1
        int remainder = texts.length % processors;

        Thread[] threads = new Thread[processors];

        ConcurrentHashMap<Character, Integer> letters = new ConcurrentHashMap<>();

        int base = 0;
        for (int i = 0; i < processors; i++) {
            int chunk = countOfTextsPerThread + (i < remainder ? 1 : 0);

            final int baseCopy = base;
            threads[i] = new Thread(()->{
                HashMap<Character, Integer> localLetters = new HashMap<>();

                for (int j = baseCopy; j < baseCopy + chunk; j++) {
                    String text = texts[j];
                    for (int k = 0; k < text.length(); k++) {
                        char c = Character.toLowerCase(text.charAt(k));
                        if (Character.isLetter(c)) {
                            localLetters.computeIfAbsent(c, (Character) -> 0);
                            localLetters.merge(c, 1, Integer::sum);
                        }
                    }
                }

                for (var kv : localLetters.entrySet()) {
                    char c = kv.getKey();
                    int count = kv.getValue();
                    letters.computeIfAbsent(c, (Character) -> 0);
                    letters.merge(c, count, Integer::sum);
                }
            });
            base += chunk;
            threads[i].start();
        }
        for (int i = 0; i < processors; i++)
            try { threads[i].join(); } catch (InterruptedException e) {}

        return letters;
    }
}
