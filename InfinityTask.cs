using System;

namespace AwaiterHell
{
    public class InfinityTask<T> : InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>>>>>>>>>>

    {
        public InfinityTask(Func<T> func) : base(
            new Func<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>>>>>>>>>>(
                () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>>>>>>>>>(
                    () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>>>>>>>>(
                        () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>>>>>>>(
                            () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>>>>>>(
                                () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>>>>>(
                                    () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>>>>(
                                        () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>>>(
                                            () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>>(
                                                () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>>(
                                                    () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>>(
                                                        () => new InfinityStubTask<InfinityStubTask<InfinityStubTask<T>>>(
                                                            () => new InfinityStubTask<InfinityStubTask<T>>(
                                                                () => new InfinityStubTask<T>(
                                                                    () => func()))))))))))))))
            )
        {
        }
    }
}