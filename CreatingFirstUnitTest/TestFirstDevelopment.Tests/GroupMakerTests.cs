using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32.SafeHandles;

namespace TestFirstDevelopment.Tests
{
    [TestClass]
    public class GroupMakerTests
    {
        private List<Measurement> GenerateList(int itemCount)
        {
            var list = new List<Measurement>();
            for (int i = 0; i < itemCount; i++)
            {
                var measurement = new Measurement { Min = i - 10, Max = i };
                list.Add(measurement);
            }
            return list;
        }

        [TestMethod]
        public void Bir_elemanli_liste_birerli_gruplanmak_istendiginde_grup_sayisi_bir_olmalidir()
        {
            var measurements = GenerateList(1);
            var groupMaker = new GroupMaker(1);
            var groups = groupMaker.MakeGroup(measurements);

            Assert.AreEqual(1, groups.Count);

        }

        [TestMethod]
        public void Alti_elemanli_liste_ikiserli_gruplanmak_istendiginde_grup_sayisi_uc_olmalidir()
        {
            var measurements = GenerateList(6);

            var groupMaker = new GroupMaker(2);
            var groups = groupMaker.MakeGroup(measurements);

            Assert.AreEqual(3, groups.Count);

        }
        [TestMethod]
        public void Elli_elemanli_liste_onarli_gruplanmak_istendiginde_grup_sayisi_bes_olmalidir()
        {
            var measurements = GenerateList(50);

            var groupMaker = new GroupMaker(10);
            var groups = groupMaker.MakeGroup(measurements);

            Assert.AreEqual(5, groups.Count);

        }
    }
}
