using System;
using System.Windows;

namespace MIC.Wpf.Controls.Windows
{
    /// <summary>
    /// カスタムウィンドウクラス
    /// 
    /// ※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※
    /// ※※※※※※                                                  　※※※※※※
    /// ※※※※※※　全てのシングルトンウィンドウはこれを派生すること　※※※※※※
    /// ※※※※※※                                                    ※※※※※※
    /// ※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※
    /// 
    /// IsClosedの追加とOnClosedのオーバーライド 
    /// </summary>
    public abstract class BaseWindow : Window
    {

        static BaseWindow()
        {
            //Generic.xamlで指定したテンプレートを使う場合は下記のコメントをはずす
            //継承先でコントロールを実装する場合はコメントアウト。

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(BaseWindow), new FrameworkPropertyMetadata(typeof(BaseWindow)));
        }

        /// <summary>
        /// ウィンドウが閉じられたか判定するフラグ
        /// </summary>
        public bool IsClosed;

        /// <summary>
        /// OnClosedをオーバーライドする
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.IsClosed = true;
        }



    }
}
