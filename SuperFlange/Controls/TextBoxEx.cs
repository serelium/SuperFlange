using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SuperFlange.Controls
{
    public class TextBoxEx : TextBox
    {
        public static readonly DependencyProperty TextTypeProperty = DependencyProperty.Register(nameof(TextType), typeof(StringType), typeof(TextBoxEx), new PropertyMetadata(StringType.All));
        public StringType TextType
        {
            get { return (StringType)GetValue(TextTypeProperty); }
            set { SetValue(TextTypeProperty, value); }
        }

        public TextBoxEx()
        {
            
        }

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            if (TextType == StringType.Decimal)
            {
                if (Text == ".")
                    Text = "0";

                else if (Text.EndsWith("."))
                    Text.Replace(".", "");
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            char keyChar = ((char)KeyInterop.VirtualKeyFromKey(e.Key));

            if(TextType == StringType.Decimal)
            {

                if (e.Key != Key.LeftCtrl && e.Key != Key.RightCtrl && !char.IsDigit(keyChar) && (e.Key != Key.OemPeriod))
                    e.Handled = true;

                if ((e.Key == Key.OemPeriod) && Text.Contains('.'))
                    e.Handled = true;
            }

            else if (TextType == StringType.Numerical)
            {
                if(!char.IsDigit(keyChar))
                    e.Handled = true;
            }

            else if (TextType == StringType.Alphanumerical)
            {
                if (!char.IsLetterOrDigit(keyChar))
                    e.Handled = true;
            }
        }

    }
    public enum StringType
    {
        Numerical,
        Decimal,
        Alphabet,
        Alphanumerical,
        All
    }
}
