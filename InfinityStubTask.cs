using System;

namespace AwaiterHell
{
    public class InfinityStubTask<T> : StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>>>>>>>>>>

    {
        public InfinityStubTask(Func<T> func) : base(
            new Func<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>>>>>>>>>>(
                () => new StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>>>>>>>>>(
                    () => new StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>>>>>>>>(
                        () => new StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>>>>>>>(
                            () => new StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>>>>>>(
                                () => new StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>>>>>(
                                    () => new StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>>>>(
                                        () => new StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>>>(
                                            () => new StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>>(
                                                () => new StupidTask<StupidTask<StupidTask<StupidTask<StupidTask<T>>>>>(
                                                    () => new StupidTask<StupidTask<StupidTask<StupidTask<T>>>>(
                                                        () => new StupidTask<StupidTask<StupidTask<T>>>(
                                                            () => new StupidTask<StupidTask<T>>(
                                                                () => new StupidTask<T>(
                                                                    () => func()))))))))))))))
            )
        {
        }
    }
}