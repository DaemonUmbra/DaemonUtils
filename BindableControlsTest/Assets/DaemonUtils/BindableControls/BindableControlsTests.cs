using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnityEngine;
using static BindableControls;

namespace Tests
{
    [TestClass()]
    public class BindableControlsTests
    {
        private List<KeyValuePair<KeyCode?, KeyFunction>> AddBindingTarget = new List<KeyValuePair<KeyCode?, KeyFunction>>()
        {
            new KeyValuePair<KeyCode?, KeyFunction>(null, new KeyFunction(DummyTarget))
        };

        private List<KeyValuePair<KeyCode?, KeyFunction>> AddBinding1Target = new List<KeyValuePair<KeyCode?, KeyFunction>>()
        {
            new KeyValuePair<KeyCode?, KeyFunction>(KeyCode.A, new KeyFunction(DummyTarget))
        };

        private void Setup()
        {
        }

        private void CleanUp()
        {
            while (Bindings.Count != 0)
            {
                Bindings.RemoveAt(0);
            }
        }

        private static void DummyTarget()
        {
        }

        [TestMethod()]
        public void AddBindingTest()
        {
            AddBinding(new KeyFunction(DummyTarget));
            CleanUp();
            Assert.AreEqual(AddBindingTarget[0], Bindings[0]);
        }

        [TestMethod()]
        public void AddBindingTest1()
        {
            CleanUp();
            AddBinding(KeyCode.A, new KeyFunction(DummyTarget));
            Assert.AreEqual(AddBinding1Target[0], Bindings[0]);
        }

        [TestMethod()]
        public void GetBindingIndexTest()
        {
        }

        [TestMethod()]
        public void GetBoundFunctionTest()
        {
        }

        [TestMethod()]
        public void GetBoundKeyTest()
        {
        }

        [TestMethod()]
        public void GetBoundFunctionsTest()
        {
        }
    }
}