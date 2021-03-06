using System.Data;
// <copyright file="EntityContainerTest.cs">Copyright ©  2018</copyright>
using System;
using InitiativeEntryLibrary;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitiativeEntryLibrary.Tests
{
    /// <summary>This class contains parameterized unit tests for EntityContainer</summary>
    [PexClass(typeof(EntityContainer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class EntityContainerTest
    {
        /// <summary>Test stub for Add(Entity)</summary>
        [PexMethod]
        public bool AddTest([PexAssumeUnderTest]EntityContainer target, Entity e)
        {
            bool result = target.Add(e);
            return result;
            // TODO: add assertions to method EntityContainerTest.AddTest(EntityContainer, Entity)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public EntityContainer ConstructorTest()
        {
            EntityContainer target = new EntityContainer();
            return target;
            // TODO: add assertions to method EntityContainerTest.ConstructorTest()
        }

        /// <summary>Test stub for Sort()</summary>
        [PexMethod]
        public DataTable SortTest([PexAssumeUnderTest]EntityContainer target)
        {
            DataTable result = target.Sort();
            return result;
            // TODO: add assertions to method EntityContainerTest.SortTest(EntityContainer)
        }
    }
}
