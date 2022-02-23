using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using ComputerStorageUnitConverter;

namespace ComputerStorageUnitConverterTests
{
    public class ByteConverterTest
    {
        double convertedValue;

        [Test]
        public void DefaultConversionForMegabytesToBytes_ConversionValueIsOne_ShouldReturnConversionForOne()
        {
            ByteConversion conversion = new ByteConversion();

            convertedValue = conversion.ConvertMegabytesToBytes();

            Assert.AreEqual(1048576, convertedValue);
        }

        [Test]
        public void DefaultConversionForGigabytesToMegaBytes_ConversionValueIsOne_ShouldReturnConversionForOne()
        {
            ByteConversion conversion = new ByteConversion();

            convertedValue = conversion.ConvertGigabytesToMegabyte();

            Assert.AreEqual(1024, convertedValue);
        }

        [Test]
        public void DefaultConversionForTerabytesToGigaBytes_ConversionValueIsOne_ShouldReturnConversionForOne()
        {
            ByteConversion conversion = new ByteConversion();

            convertedValue = conversion.ConvertTerabytetoGigabytes();

            Assert.AreEqual(1024, convertedValue);
        }

        [Test]
        public void HighestpossibleValueConversionForTerabytesToGigaBytes_ConversionValueIsTheHighestPossibleInteger_ShouldReturnConversionForHighestPossibleValue()
        {
            ByteConversion conversion = new ByteConversion(1024);

            convertedValue = conversion.ConvertTerabytetoGigabytes();

            Assert.AreEqual(1048576, convertedValue);
        }

        [Test]
        public void HighestpossibleValueConversionForGigaBytesToMegabytes_ConversionValueIsTheHighestPossibleInteger_ShouldReturnConversionForHighestPossibleValue()
        {
            ByteConversion conversion = new ByteConversion(1073741824);

            convertedValue = conversion.ConvertGigabytesToMegabyte();

            Assert.AreEqual(1099511627776, convertedValue);
        }
    }
}
