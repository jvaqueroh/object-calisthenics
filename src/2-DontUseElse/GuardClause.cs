using System;

public class GuardClause
{
    private Dependency dependency;

    public GuardClause(Dependency dependency)
    {
        this.dependency = dependency;
    }

    public void DoSomethingWhenPossible(bool possible)
    {
        if (!possible)
        {
            throw new NotPossibleToDoThatNowException();
        }
        dependency.DoWork();
    }
}

public class Dependency
{
    internal void DoWork()
    {
        throw new NotImplementedException();
    }
}

public class NotPossibleToDoThatNowException : Exception { }