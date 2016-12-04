using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MIC.Try.Common
{
    public class ActionTest
    {
        // 任意のタイミングで呼べるアクション=Event
        public event Action SomeEventHandler;

        public void Test()
        {

            Task.Run(() =>
            {
                Debug.WriteLine("Task1");

            });

            //t.Wait();
            Debug.WriteLine("Task2");


            var t2 = Task.Run(() =>
            {
                Debug.WriteLine("Task3");

            });

            Debug.WriteLine("Task4");
            t2.Wait();


            var t3 = Task.Run(() =>
            {
                Debug.WriteLine("TaskA");
                Task.Run(() =>
                {
                    Debug.WriteLine("TaskB");

                });
                Debug.WriteLine("TaskC");

            });

            t3.Wait();
            Debug.WriteLine("TaskD");


            var t4 = Task.Run(async () =>
            {
                Debug.WriteLine("TaskA");
                await Task.Run(() =>
                {
                    Debug.WriteLine("TaskB");

                });
                Debug.WriteLine("TaskC");

            });

            t4.Wait();

            Debug.WriteLine("TaskD");

        }


        public ActionTest()
        {
            //Test();

            SomeEventHandler = () => { };


            Action<int, string> act = ActionMethod;
            Func<int, string, bool> func = FuncMethod;

            ActionArgsMethod(1, true, (s1, s2) =>
            {

            });


            var list = new[]
            {
                new { id = 1, name = "" },
                new { id = 1, name = "" },
                new { id = 1, name = "" },
                new { id = 1, name = "" }
            }.ToList();


            list.Where((x) =>
            {
                if (x.id == 1)
                    return true;
                else
                    return false;
            }).Select(x => x);


            var list2 = new List<string>() { "aaa", "bbb" };
            list2.Where(FilterFunc).Select(x => x).ToList();

            // Action a = async () => //ともできてしまう。
            Func<Task> a = async () =>
          {
              try
              {
                  await Task.Run(() =>
                  {
                        // 重い処理

                        // こっちの例外もmainスレッドの中でやってくれる
                        //throw new Exception("await処理の中");

                    });

                    //await Task.Run(() => { });


                    // mainスレッドでやってくれる
                    //throw new Exception("await処理の外");
                }
              catch (Exception ex)
              {
                  Debug.WriteLine(ex.Message);
                  throw;

              }
          };


            //mainスレッドで処理してくれる
            Task tttt = a();


            //var t = Task.Run(a);



            var context = SynchronizationContext.Current;
            System.Diagnostics.Debug.WriteLine("ActionTest:" + context.GetHashCode().ToString());
            CancellationTokenSource source = new CancellationTokenSource();
            //var t = TaskRun(new Progress<int>(), source.Token, context);  // 非同期処理 await








            //Func<Task> r =
            //        async () =>
            //        {
            //            try
            //            {
            //                await Task.Run(() =>
            //                {
            //                    throw new Exception();
            //                });
            //            }
            //            catch (Exception ex)
            //            {
            //                throw ex;
            //                //context.Post
            //                //(
            //                //    (exception) =>
            //                //    {
            //                //        throw (Exception)exception;
            //                //    }, ex
            //                //    );
            //            }
            //        };


            // TaskScheduler.FromCurrentSynchronizationContext()はSynchronizedContext.Currentとは違うコンテキストを取得してくる
            Task.Run
                (
                    () =>
                    {
                        try
                        {
                            throw new Exception();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                ).ContinueWith(result =>
                {
                    if (result.Exception != null)
                        throw result.Exception;

                }, TaskScheduler.FromCurrentSynchronizationContext());


            Task.Run
                (
                    () =>
                    {
                        try
                        {
                            throw new Exception();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                ).ContinueWith(result =>
                {

                    if (result.Exception != null)
                        context.Post((_) =>
                        {
                            throw result.Exception;
                        }, null);
                });




            //r().ContinueWith(result =>
            //{
            //    if (result.Exception != null)
            //        throw result.Exception;

            //}, TaskScheduler.FromCurrentSynchronizationContext());


            //var t2 = TaskRun(new Progress<int>(), source.Token);  // 非同期処理 await


            //var con = t.ConfigureAwait(true); // 戻ってきたとき,元のスレッドで
            //t.ContinueWith(ta =>    // 続けて処理
            //    {
            //        if (ta.IsFaulted)
            //            throw new Exception("エラー発生");
            //    }
            //    ).ConfigureAwait(true);



            // メインスレッドの任意のタイミングキャンセルも出せる
            // キャンセル要求出す

            //try
            //{
            //    //source.Cancel();

            //    // タスクがキャンセルされるまで待機
            //    // ここでエラーに
            //    t.Wait();
            //}
            //catch (AggregateException ex)
            //{
            //    throw;
            //}
        }


        private async Task TaskRun(IProgress<int> progress, CancellationToken token, SynchronizationContext context)
        {
            Action<int> a = (i) => { };

            Func<int> act = () =>
            {
                progress.Report(1);


                //// これでもいいが
                //if (token.IsCancellationRequested)
                //    throw new OperationCanceledException(token);

                // キャンセル要求がきていたらOperationCanceledException例外をスロー
                //token.ThrowIfCancellationRequested();
                //try
                //{
                SomeEventHandler();
                //throw new Exception("aa");
                return 1;
                //}
                //　ここでキャッチしてしまうと処理された例外扱いになってしまう。
                //catch (Exception ex)
                //{

                //}
                //finally
                //{
                //}

            };


            Task<int> t = new Task<int>(act, token);

            try
            {

                int i = SynchronizationContext.Current.GetHashCode();
                System.Diagnostics.Debug.WriteLine(i.ToString());

                // ConfigureAwait(false)だと戻ってきたとき、コンテキストが異なる
                await Task.Run(() => { });


                //throw new Exception("ああああああ");


                int i_1 = SynchronizationContext.Current.GetHashCode();
                System.Diagnostics.Debug.WriteLine(i_1.ToString());

                await Task.Run(() => { }).ConfigureAwait(true);

                int i_2 = SynchronizationContext.Current.GetHashCode();
                System.Diagnostics.Debug.WriteLine(i_2.ToString());

                // UI変更が必要なときは、trueにしないとエラー
                await Task.Run(() => { }).ConfigureAwait(false);

                int i2 = SynchronizationContext.Current.GetHashCode();
                System.Diagnostics.Debug.WriteLine(i2.ToString());

                // await内でエラーが帰ってきたら、戻ってきたときコンテキストが異なる
                // →context.Postしないとだめ
                await Task<int>.Run(act, token).ConfigureAwait(true);

                int i3 = SynchronizationContext.Current.GetHashCode();
                System.Diagnostics.Debug.WriteLine(i3.ToString());

            }
            catch (Exception ex)
            {
                //int i = SynchronizationContext.Current.GetHashCode();
                //System.Diagnostics.Debug.WriteLine(i.ToString());
                int i2 = context.GetHashCode();
                System.Diagnostics.Debug.WriteLine(i2.ToString());
                context.Post((state) =>
                {
                    throw new Exception(ex.Message, ex);
                }, ex);
                //throw;
            }





        }




        private void ActionMethod(int i, string str)
        {
        }

        private bool FuncMethod(int i, string str)
        {
            return true;
        }


        private void ActionArgsMethod(int i, bool b, Action<string, string> hogeAction)
        {
        }

        private bool FilterFunc(string str)
        {
            return true;
        }
    }
}
