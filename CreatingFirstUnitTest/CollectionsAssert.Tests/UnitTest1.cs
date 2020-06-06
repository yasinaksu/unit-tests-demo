﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionsAssert.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private List<string> _users;
        [TestInitialize]
        public void TestInitialize()
        {
            _users = new List<string>();
            _users.Add("Salih");
            _users.Add("Engin");
            _users.Add("Ahmet");
        }
        [TestMethod]
        public void Items_and_their_order_must_be_same()
        {
            var newUsers = new List<string>();
            newUsers.Add("Salih");
            newUsers.Add("Engin");
            newUsers.Add("Ahmet");

            CollectionAssert.AreEqual(_users, newUsers);
        }

        [TestMethod]
        public void Items_must_be_same_but_their_order_can_be_different()
        {
            var newUsers = new List<string>();
            newUsers.Add("Salih");
            newUsers.Add("Ahmet");
            newUsers.Add("Engin");

            CollectionAssert.AreEquivalent(_users, newUsers);
        }
        [TestMethod]
        public void Items_and_their_order_must_not_be_same()
        {
            var newUsers = new List<string>();
            newUsers.Add("Salih");
            newUsers.Add("Engin2");
            newUsers.Add("Ahmet");

            CollectionAssert.AreNotEqual(_users, newUsers);
        }

        [TestMethod]
        public void Items_must_be_different()
        {
            var newUsers = new List<string>();
            newUsers.Add("Salih");
            newUsers.Add("Engin");
            newUsers.Add("Ahmet");
            newUsers.Add("Yasin");

            CollectionAssert.AreNotEquivalent(_users, newUsers);
        }
    }
}
