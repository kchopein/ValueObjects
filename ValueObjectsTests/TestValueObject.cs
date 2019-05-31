using System.Collections.Generic;
using ValueObjects;

namespace ValueObjectsTests
{
    internal class TestValueObject : ValueObject
    {
        public string StringPropertyValue { get; set; }
        public IEnumerable<ChildObject> ListPropertyValue { get; protected set; }

        protected TestValueObject()
        {

        }

        public TestValueObject(string stringPropertyValue, IEnumerable<ChildObject> listPropertyValue)
        {
            this.StringPropertyValue = stringPropertyValue;
            this.ListPropertyValue = listPropertyValue;
        }
    }
}