using System.Reflection;
// <copyright file="Form1Test.cs">Copyright ©  2018</copyright>
using System;
using InitiativeTracker;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitiativeTracker.Tests
{
    /// <summary>This class contains parameterized unit tests for Form1</summary>
    [PexClass(typeof(InitiativeTracker))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Form1Test
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public InitiativeTracker ConstructorTest()
        {
            InitiativeTracker target = new InitiativeTracker();
            return target;
            // TODO: add assertions to method Form1Test.ConstructorTest()
        }

        [PexMethod(MaxBranches = 20000)]
        [PexMethodUnderTest("btnSort_Click(Object, EventArgs)")]
        internal void btnSort_Click(
            [PexAssumeUnderTest]InitiativeTracker target,
            object sender,
            EventArgs e
        )
        {
            object[] args = new object[2];
            args[0] = sender;
            args[1] = (object)e;
            Type[] parameterTypes = new Type[2];
            parameterTypes[0] = typeof(object);
            parameterTypes[1] = typeof(EventArgs);
            object result = ((MethodBase)(typeof(InitiativeTracker).GetMethod("btnSort_Click",
                                                                  BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                  CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method Form1Test.btnSort_Click(Form1, Object, EventArgs)
        }
    }
}
