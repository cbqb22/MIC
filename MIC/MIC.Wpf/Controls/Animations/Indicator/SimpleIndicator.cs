using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MIC.Wpf.Controls.Animations.Indicator
{
    /// <summary>
    /// SimpleIndicatorEx用の依存プロパティ、IAnimationを実装したクラス
    /// </summary>
    public class SimpleIndicator : IndicatorBase
    {
        #region IAnimationの実装

        /// <summary>
        /// アニメーション開始
        /// </summary>
        public override void Begin()
        {
            var storyBoard = this.TryFindResource("Storyboard1") as Storyboard;
            if (storyBoard != null)
            {
                storyBoard.Begin();
                DisplayText = PlayingText;
            }
        }

        /// <summary>
        /// アニメーション一時停止
        /// </summary>
        public override void Pause()
        {
            var storyBoard = this.TryFindResource("Storyboard1") as Storyboard;
            if (storyBoard != null)
            {
                storyBoard.Pause();
                DisplayText = PausingText;
            }
        }

        /// <summary>
        /// アニメーション停止
        /// </summary>
        public override void Stop()
        {
            var storyBoard = this.TryFindResource("Storyboard1") as Storyboard;
            if (storyBoard != null)
            {
                storyBoard.Stop();
                DisplayText = StoppedText;
            }
        }

        #endregion
        #region 依存プロパティ


        /// <summary>
        /// インジケーターのテーマカラー
        /// </summary>
        public static readonly DependencyProperty IndicationThemeColorProperty = DependencyProperty.Register(
                                                                           "IndicationThemeColor",
                                                                           typeof(Color),
                                                                           typeof(SimpleIndicator),
                                                                           new PropertyMetadata(Colors.Orange));
        /// <summary>
        /// IndicationThemeColorプロパティ
        /// </summary>
        public Color IndicationThemeColor
        {
            get { return (Color)GetValue(IndicationThemeColorProperty); }
            set { SetValue(IndicationThemeColorProperty, value); }
        }

        /// <summary>
        /// 一時停止中のテキスト
        /// </summary>
        public static readonly DependencyProperty PausingTextProperty = DependencyProperty.Register(
                                                                           "PausingText",
                                                                           typeof(string),
                                                                           typeof(SimpleIndicator),
                                                                           new PropertyMetadata(""));
        /// <summary>
        /// PausingTextのプロパティ
        /// </summary>
        public string PausingText
        {
            get { return (string)GetValue(PausingTextProperty); }
            set { SetValue(PausingTextProperty, value); }
        }


        /// <summary>
        /// 再生中のテキスト
        /// </summary>
        public static readonly DependencyProperty PlayingTextProperty = DependencyProperty.Register(
                                                                   "PlayingText",
                                                                   typeof(string),
                                                                   typeof(SimpleIndicator),
                                                                   new PropertyMetadata(""));
        /// <summary>
        /// PlayingTextのプロパティ
        /// </summary>
        public string PlayingText
        {
            get { return (string)GetValue(PlayingTextProperty); }
            set { SetValue(PlayingTextProperty, value); }
        }

        /// <summary>
        /// 停止中のテキスト
        /// </summary>
        public static readonly DependencyProperty StoppedTextProperty = DependencyProperty.Register(
                                                                           "StoppedText",
                                                                           typeof(string),
                                                                           typeof(SimpleIndicator),
                                                                           new PropertyMetadata(""));

        /// <summary>
        /// StoppedTextのプロパティ
        /// </summary>
        public string StoppedText
        {
            get { return (string)GetValue(StoppedTextProperty); }
            set { SetValue(StoppedTextProperty, value); }
        }


        /// <summary>
        /// 表示のテキスト
        /// </summary>
        public static readonly DependencyProperty DisplayTextProperty = DependencyProperty.Register(
                                                                           "DisplayText",
                                                                           typeof(string),
                                                                           typeof(SimpleIndicator),
                                                                           new PropertyMetadata(""));

        /// <summary>
        /// DisplayTextのプロパティ
        /// </summary>
        public string DisplayText
        {
            get { return (string)GetValue(DisplayTextProperty); }
            set { SetValue(DisplayTextProperty, value); }
        }

        #endregion 
    }
}
