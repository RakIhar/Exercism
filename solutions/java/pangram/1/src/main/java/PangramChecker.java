public class PangramChecker {

    public boolean isPangram(String input) {
        boolean[] letters = new boolean[26];
        String lowerCased = input.toLowerCase();
        for(int i = 0; i < lowerCased.length(); i++) {
            char c = lowerCased.charAt(i);
            if (c >= 'a' && c <= 'z') {
                letters[c - 'a'] = true;
            }
        }
        for (boolean letter: letters)
            if (!letter)
                return false;

        return true;
    }

}
