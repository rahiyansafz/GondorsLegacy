namespace GondorsLegacy.CrossCuttingCorners.Lock;

public interface IDistributedLock
{
    IDistributedLockScope Acquire(string lockName);

    IDistributedLockScope TryAcquire(string lockName);
}