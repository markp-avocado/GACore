﻿using GACore.Architecture;
using System;
using System.Globalization;
using System.Windows.Data;

namespace GACore.Controls
{
    public class NullableEnumStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? "null" : value.ToString();            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class NullableBoolButtonStateStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((bool?)value)
            {
                case true: return "Status: Pressed";

                case false: return "Status: De-pressed";

                default:
                case null: return "Status: Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class NullableBoolStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {           
            switch((bool?)value)
            {
                case true: return "True";

                case false: return "False";

                default:
                case null: return "null";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class DynamicLimiterStatusToOverlayTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DynamicLimiterStatus status = (DynamicLimiterStatus)value;
            BrushCollection brushCollection = BrushDictionaries.DynamicLimiterStatusBrushCollectionDictionary.GetBrushCollection(status);

            BrushCollectionProperty property = (BrushCollectionProperty)parameter;
            return brushCollection.GetProperty(property);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public sealed class NavigationStatusToOverlayTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            NavigationStatus status = (NavigationStatus)value;
            BrushCollection brushCollection = BrushDictionaries.NavigationStatusBackgroundBrushCollectionDictionary.GetBrushCollection(status);

            BrushCollectionProperty property = (BrushCollectionProperty)parameter;
            return brushCollection.GetProperty(property);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class PositionControlStatusToOverlayTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            PositionControlStatus status = (PositionControlStatus)value;
            BrushCollection brushCollection = BrushDictionaries.PositionControlStatusBackgroundBrushCollectionDictionary.GetBrushCollection(status);

            BrushCollectionProperty property = (BrushCollectionProperty)parameter;
            return brushCollection.GetProperty(property);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}