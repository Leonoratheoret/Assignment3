using System;
using Xunit;

namespace Assignment3.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Flatten_when_given_2_collections_make_them_into_1()
        {

            var array1 = new[] { 2, 4, 5, 6 };
            var array2 = new[] { 3, 8, 8 };

            var arrayOf1And2 = new[] { array1, array2 };

            var output = Iterators.Flatten(arrayOf1And2);

            Assert.Equal(new[] { 2,4,5,6,3,8,8}, output);

        }


        [Fact]
        public void filter_numbers_divisible_by_7_and_greater_than_42()
        {

            
            var array1 = new[] { 3,7,14,42,49,70,73,400};
            var output = Iterators.Filter(array1);

            Assert.Equal(new[] {49,70}, output);

        }

        [Fact]
        public void filter_leap_years()
        {
            
            var array1 = new[] {1820, 1822, 2000,2001, 2012, 2016, 2017, 2020};
            var output = Iterators.Filter(array1);

            Assert.Equal(new[] {1820, 2000,2012, 2016, 2020}, output);

        }

    
    }
}
