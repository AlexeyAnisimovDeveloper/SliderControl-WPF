using System.Windows;
using System.Windows.Controls;

namespace MySliderControl;

public class MySlider : Slider
{
    static MySlider()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MySlider), new FrameworkPropertyMetadata(typeof(MySlider)));
    }
}