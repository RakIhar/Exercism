public class GameMaster {
    public String describe(Character c){
        return String.format("You're a level %d %s with %s hit points.", c.getLevel(), c.getCharacterClass(), c.getHitPoints());
    }

    public String describe(Destination d){
        return String.format("You've arrived at %s, which has %s inhabitants.", d.getName(), d.getInhabitants());
    }

    public String describe(TravelMethod t){
        return switch (t){
            case WALKING -> "You're traveling to your destination by walking.";
            case HORSEBACK -> "You're traveling to your destination on horseback.";
        };
    }

    public String describe(Character c, Destination d){
        return  describe(c, d, TravelMethod.WALKING);
    }

    public String describe(Character c, Destination d, TravelMethod t){
        return describe(c) + " " + describe(t) + " " + describe(d);
    }

}
