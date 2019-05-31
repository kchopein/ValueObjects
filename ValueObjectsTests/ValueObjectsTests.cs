using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ValueObjectsTests
{
    [TestClass]
    public class ValueObjectsTests
    {
        [TestMethod]
        public void WhenConstructed_TheStringRepresentationIsPopulated()
        {
            // Arrange:
            var stringPropertyValue = "StringValue";
            var listPropertyValue = new List<ChildObject> { new ChildObject("Key1", "Value1"), new ChildObject("Key2", "Value2") };
            var internalRepresentationProperty = typeof(TestValueObject).GetProperty("ValueString", BindingFlags.NonPublic | BindingFlags.Instance);

            // Act:
            var testVO = new TestValueObject(stringPropertyValue, listPropertyValue);
            string internalRepresentation = ((string)internalRepresentationProperty.GetValue(testVO));
            var rehidratedVO = Activator.CreateInstance(typeof(TestValueObject),true);
            internalRepresentationProperty.SetValue(rehidratedVO, internalRepresentation);

            // Assert:
            internalRepresentation.Should().BeEquivalentTo(JsonConvert.SerializeObject(testVO));
            internalRepresentation.Should().BeEquivalentTo(JsonConvert.SerializeObject(rehidratedVO));
        }
    }
}
