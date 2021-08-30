using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace JellyParfait.MVVM.View
{
    public class CustomSlider : Slider
    {
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            //つまみ以外でもドラッグを始められるようにする
            var trackElement = Template.FindName("PART_Track", this) as Track;
            trackElement.Thumb.MouseEnter += new MouseEventHandler((sender, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed && e.MouseDevice.Captured == null)
                {
                    var args = new MouseButtonEventArgs(e.MouseDevice, e.Timestamp, MouseButton.Left);
                    args.RoutedEvent = MouseLeftButtonDownEvent;
                    (sender as Thumb).RaiseEvent(args);
                }
            });
        }
    }
}
