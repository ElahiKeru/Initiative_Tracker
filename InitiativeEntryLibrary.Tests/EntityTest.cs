using System;
using InitiativeEntryLibrary;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitiativeEntryLibrary.Tests
{
    /// <summary>This class contains parameterized unit tests for Entity</summary>
    [TestClass]
    [PexClass(typeof(Entity))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EntityTest
    {

        /// <summary>Test stub for .ctor(String, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)</summary>
        [PexMethod]
        public Entity ConstructorTest(
            string name,
            int initHold,
            int hpHold,
            int acHold,
            int strHold,
            int dexHold,
            int conHold,
            int intHold,
            int wisHold,
            int chaHold
        )
        {
            Entity target =
                           new Entity(name, initHold, hpHold, acHold, strHold, dexHold, conHold, intHold, wisHold, chaHold);
            return target;
            // TODO: add assertions to method EntityTest.ConstructorTest(String, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
        }
    }
}
