import java.util.Random;

class CaptainsLog {

    private static final char[] PLANET_CLASSES = new char[]{'D', 'H', 'J', 'K', 'L', 'M', 'N', 'R', 'T', 'Y'};

    private Random random;

    CaptainsLog(Random random) {
        this.random = random;
    }

    char randomPlanetClass() {
        int randomRes = random.nextInt(10);
        return switch (randomRes) {
            case 0 -> 'D';
            case 1 -> 'H';
            case 2 -> 'J';
            case 3 -> 'K';
            case 4 -> 'L';
            case 5 -> 'M';
            case 6 -> 'N';
            case 7 -> 'R';
            case 8 -> 'T';
            default -> 'Y';
        };
    }

    String randomShipRegistryNumber() {
        int num = 1000 + random.nextInt(9000);
        return "NCC-" + num;
    }

    double randomStardate() {
        return 41000.0 + 1000.0 * random.nextDouble();
    }
}
