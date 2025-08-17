static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
        // throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
        // throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake && prisonerIsAwake;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
    // Вариант 1: Собака есть, и лучник спит
    if (petDogIsPresent && !archerIsAwake)
    {
        return true;
    }

    // Вариант 2: Собаки нет, но заключённый бодрствует, и все стражи спят
    if (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake)
    {
        return true;
    }

    // Все остальные случаи — нельзя освободить
    return false;
        
        return prisonerIsAwake && !(knightIsAwake || archerIsAwake || petDogIsPresent);
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
