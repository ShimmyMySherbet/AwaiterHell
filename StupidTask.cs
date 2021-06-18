using System;
using System.Threading.Tasks;

namespace AwaiterHell
{
    public class StupidTask<T> : Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<T>>>>>>>>>>>>>>

    {
        public StupidTask(Func<T> func) : base(
            new Func<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<T>>>>>>>>>>>>>>(
                () => new Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<T>>>>>>>>>>>>>(
                    () => new Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<T>>>>>>>>>>>>(
                        () => new Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<T>>>>>>>>>>>(
                            () => new Task<Task<Task<Task<Task<Task<Task<Task<Task<Task<T>>>>>>>>>>(
                                () => new Task<Task<Task<Task<Task<Task<Task<Task<Task<T>>>>>>>>>(
                                    () => new Task<Task<Task<Task<Task<Task<Task<Task<T>>>>>>>>(
                                        () => new Task<Task<Task<Task<Task<Task<Task<T>>>>>>>(
                                            () => new Task<Task<Task<Task<Task<Task<T>>>>>>(
                                                () => new Task<Task<Task<Task<Task<T>>>>>(
                                                    () => new Task<Task<Task<Task<T>>>>(
                                                        () => new Task<Task<Task<T>>>(
                                                            () => new Task<Task<T>>(
                                                                () => new Task<T>(
                                                                    () => func()))))))))))))))
            )
        {
        }
    }
}