using System.Windows;
using DevExpress.Mvvm;
using System.Globalization;
using System.Threading;
using System.ComponentModel;
using System;

namespace DXSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-De");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-De");

            InitializeComponent();
            DataContext = new SelectedObject() {
                BorderThickness = new Thickness()
            };
        }
    }
    public class SelectedObject : BindableBase {

        [TypeConverter(typeof(CustomThicknessConverter))]
        public Thickness BorderThickness {
            get { return GetProperty(() => BorderThickness); }
            set { SetProperty(() => BorderThickness, value); }
        }
        public CornerRadius Radius {
            get { return GetProperty(() => Radius); }
            set { SetProperty(() => Radius, value); }
        }
    }

    internal class CustomThicknessConverter : ThicknessConverter {
        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source) {
            return base.ConvertFrom(typeDescriptorContext, CultureInfo.InvariantCulture, source);
        }

        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType) {
            return base.ConvertTo(typeDescriptorContext, CultureInfo.InvariantCulture, value, destinationType);
        }
    }
}
