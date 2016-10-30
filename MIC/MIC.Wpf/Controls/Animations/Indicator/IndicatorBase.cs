using System.Windows.Controls;

namespace MIC.Wpf.Controls.Animations.Indicator
{

    /// <summary>
    /// Indicator用のベースクラス
    /// </summary>
    public abstract class IndicatorBase : UserControl, IAnimation
    {
        #region IAnimationの定義

        /// <summary>
        /// アニメーション開始
        /// </summary>
        public abstract void Begin();

        /// <summary>
        /// アニメーションの一時停止
        /// </summary>
        public abstract void Pause();


        /// <summary>
        /// アニメーションの停止
        /// </summary>
        public abstract void Stop();

        #endregion

    }

}
