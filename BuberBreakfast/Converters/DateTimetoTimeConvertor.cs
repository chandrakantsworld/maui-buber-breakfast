using CommunityToolkit.Maui.Converters;
using System.Globalization;

namespace BuberBreakfast.Converters
{
    public class DateTimetoTimeConvertor : BaseConverter<object, string>
    {
        public override string DefaultConvertReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override object DefaultConvertBackReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override object ConvertBackTo(string value, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override string ConvertFrom(object value, CultureInfo culture)
        {
            DateTime datetime = (DateTime)value;
            return TimeOnly.FromDateTime(datetime).ToShortTimeString();
        }
    }
}
