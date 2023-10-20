using System;
using System.Diagnostics;
using System.Threading.Tasks;
/// <summary>
/// This should not exist. Making this was a mistake, one I can never take back.
/// </summary>
namespace AwaiterHell
{
    /// <summary>
    /// This is fucking stupid and I love it
    /// DNSpy has no clue what is going on when I try to decompile this
    /// And Visual Studio is giving me about 10 errors per second while I have this project open
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Starting hell await");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var hell = Hell(true);
            hell.Wait();
            sw.Stop();
            System.Console.WriteLine($"Result: {hell.Result} in {sw.ElapsedMilliseconds}ms");
            Console.ReadLine();
        }

        /// <summary>
        /// I have found that if you try to use more than 479 awaits in a single statement, the compiler will shit itself
        /// Therefore I have had to split up the awaits into multiple statements
        /// </summary>
        public static async Task<bool> Hell(bool inp)
        {
            var infinityTask = new InfinityTask<bool>(() => inp);
            Console.WriteLine("awaiter 1");
            var awaitSecor1 = await await await await await await await await await await await await await await await await await await await await await await await await
                 await await await await await await await await await await await await await await await await await await await await await await await await
                  await await await await await await await await await await await await await await await await await await await await await await await await
                   await await await await await await await await await await await await await await await await await await await await await await await await
                    await await await await await await await await await await await await await await await await await await await await await await await await
                     await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await infinityTask;

            /*
             * Something interesting about these messages, DNSpy cnnot find them.
             * Maybe the amount of awaits overwhelms the decompiler and it just gives up, or maybe it doesn't compile correctly to begin with?
             */
            Console.WriteLine("awaiter 2");

            /*
             * Execution appears to end here, without the main thread terminating, and with standard message pumps.
             * I'm not too sure why it appears to just stop here.
             * The CPU and Memory usge also drops here and doesn't change.
             * Maybe it somehow locks up the task dispatcher?
             *
             */

            var awaitSector2 = await await await await await await await await await await await await await await await await await await await await await await await await
                 await await await await await await await await await await await await await await await await await await await await await await await await
                  await await await await await await await await await await await await await await await await await await await await await await await await
                   await await await await await await await await await await await await await await await await await await await await await await await await
                    await await await await await await await await await await await await await await await await await await await await await await await await
                     await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await awaitSecor1;
            Console.WriteLine("awaiter 3");

            var awaitSector3 = await await await await await await await await await await await await await await await await await await await await await await await await
                 await await await await await await await await await await await await await await await await await await await await await await await await
                  await await await await await await await await await await await await await await await await await await await await await await await await
                   await await await await await await await await await await await await await await await await await await await await await await await await
                    await await await await await await await await await await await await await await await await await await await await await await await await
                     await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await await await await await await await await await await await await await await await
                       await await await await await await await await await await awaitSector2;
            Console.WriteLine("awaiter 4");

            var awaitSector4 = await await await await await await await await await await await await await await await await await await await await await await await await
                await await await await await await await await await await await await await await await await await await await await await await await await
                 await await await await await await await await await await await await await await await await await await await await await await await await
                  await await await await await await await await await await await await await await await await await await await await await await await await
                   await await await await await await await await await await await await await await await await await await await await await await await await
                    await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await awaitSector3;
            Console.WriteLine("awaiter 5");

            var awaitSector5 = await await await await await await await await await await await await await await await await await await await await await await await await
                await await await await await await await await await await await await await await await await await await await await await await await await
                 await await await await await await await await await await await await await await await await await await await await await await await await
                  await await await await await await await await await await await await await await await await await await await await await await await await
                   await await await await await await await await await await await await await await await await await await await await await await await await
                    await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await awaitSector4;
            Console.WriteLine("awaiter 6");

            var awaitSector6 = await await await await await await await await await await await await await await await await await await await await await await await await
                await await await await await await await await await await await await await await await await await await await await await await await await
                 await await await await await await await await await await await await await await await await await await await await await await await await
                  await await await await await await await await await await await await await await await await await await await await await await await await
                   await await await await await await await await await await await await await await await await await await await await await await await await
                    await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await await await await await await await await await await await await await await await
                      await await await await await await await await await await awaitSector5;

            return await await await await await await await await await await await await await await await await await await await await awaitSector6;
        }
    }
}
