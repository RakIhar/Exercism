class AnnalynsInfiltration {
    public static boolean canFastAttack(boolean knightIsAwake) {
        return !knightIsAwake;
    }

    public static boolean canSpy(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake) {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static boolean canSignalPrisoner(boolean archerIsAwake, boolean prisonerIsAwake) {
        return prisonerIsAwake && !archerIsAwake;
    }
/*
Free prisoner: Annalyn can attempt to sneak into the camp to free the prisoner.
This is risky and can only succeed in one of two ways:
If Annalyn has her pet dog, she can rescue the prisoner if the archer is asleep.
The knight is scared of the dog and the archer will not have time to get ready before Annalyn and the prisoner can escape.


If Annalyn does not have her pet dog, then she and the prisoner must be very sneaky!
Annalyn can free the prisoner if the prisoner is awake and both the knight and archer are sleeping.
However, if the prisoner is sleeping, they can't be rescued,
as the prisoner would be startled by Annalyn's sudden appearance and wake up the knight and archer.*/
    public static boolean canFreePrisoner(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake, boolean petDogIsPresent) {
        boolean cond1 = !archerIsAwake && petDogIsPresent;
        boolean cond2 = !petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake;
        return cond1 || cond2;
    }
}
