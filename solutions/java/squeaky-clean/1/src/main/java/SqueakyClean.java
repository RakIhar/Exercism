class SqueakyClean {
    static String clean(String identifier) {
        StringBuilder res = new StringBuilder();
        boolean isNextUpperCase = false;
        for (char c: identifier.toCharArray())
        {
            if (c == ' ')
                res.append('_');
            else if (c == '-')
                isNextUpperCase = true;
            else if (Character.isLetter(c)){
                if (isNextUpperCase) {
                    res.append(Character.toUpperCase(c));
                    isNextUpperCase = false;
                } else
                    res.append(c);
            }
            else if (Character.isDigit(c)) {
                char cNew = switch (c) {
                    case '0' -> 'o';
                    case '1' -> 'l';
                    case '3' -> 'e';
                    case '4' -> 'a';
                    case '7' -> 't';
                    default -> ' ';
                };
                if (cNew != ' ')
                {
                    if (isNextUpperCase) {
                        res.append(Character.toUpperCase(cNew));
                        isNextUpperCase = false;
                    } else
                        res.append(cNew);
                }
            }
        }
        return res.toString();
    }
}
