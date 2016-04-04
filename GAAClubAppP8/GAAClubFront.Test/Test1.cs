﻿using NUnit.Framework;


namespace GAAClubFront.Test
{
    //these tests use TrialDataAccess instead of DataAccess
    [TestFixture]
    public class Test1
    {




        Stats statTest;
        //set up is run before each test
        [SetUp]
        public void initialize()
        {
            // a new instance of Stats is initiated with the default constructor
            // this does not take a connection paramater and results in 
            // and instance of TrialDataAccess being created

            statTest = new Stats();
        }


        [Test]
        public void getMeanAgeTest()
        {
            // given the data hardcoded in trial data access, expected is 24
            double expected = 24;
            // Call the getMeanAge method of the Stats instance 
            double actual = statTest.getMeanAge();
            // if the two values are equal this test will pass.
            Assert.AreEqual(expected, actual);
        }

        // similar tests are set up for all the other methods.
        // all data used to calculate actual values is found in TrialDataAccess
        [Test]
        public void getMaxAgeTest()
        {
            int expected = 26;
            int actual = statTest.getMaxAge();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getMinAgeTest()
        {
            int expected = 21;
            int actual = statTest.getMinAge();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void getMeanHeightTest()
        {
            int expected = 170;
            double actual = statTest.getMeanHeight();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getMinHeightTest()
        {
            int expected = 165;
            int actual = statTest.getMinHeight();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getMaxHeightTest()
        {
            int expected = 175;
            int actual = statTest.getMaxHeight();
            Assert.AreEqual(expected, actual);
        }


        // include data validation tests
        [Test]
        public void getMinSpeedTest()
        {
            double expected = 3.1;
            double actual = statTest.getMinSpeed();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getMaxSpeedTest()
        {
            Stats statTest = new Stats();
            double expected = 3.8;
            double actual = statTest.getMaxSpeed();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getMeanSpeedTest()
        {
            Stats statTest = new Stats();
            double expected = 3.4;
            double actual = statTest.getMeanSpeed();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getMeanDistTest()
        {
            Stats statTest = new Stats();
            double expected = 1900;
            double actual = statTest.getMeanDist();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getMinDistTest()
        {
            Stats statTest = new Stats();
            int expected = 1700;
            int actual = statTest.getMinDist();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void getMaxDistTest()
        {
            Stats statTest = new Stats();
            int expected = 2000;
            int actual = statTest.getMaxDist();
            Assert.AreEqual(expected, actual);
        }
        // the following tests check for invalid input
        [Test]
        public void validateHTest()
        {
            InputValidator v = new InputValidator();

            // value of -10 should result in false
            // number is outside accepted range
            string enterValue = "-10";
            bool expected = false;
            bool actual = v.validateHeight(enterValue);
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void validateATest()
        {
            InputValidator v = new InputValidator();

            // value of 18.5 should result in false
            // should be a whole number
            string enterValue = "18.5";
            bool expected = false;
            bool actual = v.validateAge(enterValue);
            Assert.AreEqual(expected, actual);
        }
        // boundary tests
        [Test]
        public void validateDTest()
        {
            InputValidator v = new InputValidator();

            // value of 1 should result in true
            // is a whole number just within range
            string enterValue = "1";
            bool expected = true;
            bool actual = v.validateDist(enterValue);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void validateSTest()
        {
            InputValidator v = new InputValidator();

            // value of 8 should result in false
            // the number is just outside range
            string enterValue = "8";
            bool expected = false;
            bool actual = v.validateSpeed(enterValue);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void validateSTest2()
        {
            InputValidator v = new InputValidator();

            // value of 3.788 should result in true
            // double format within range
            string enterValue2 = "3.788";
            bool expected = true;
            bool actual = v.validateSpeed(enterValue2);
            Assert.AreEqual(expected, actual);
        }

        // check that player has added
        [Test]
        public void validateAdd()
        {
            ModifyDatabase modify = new ModifyDatabase();
            int orig = modify.countRows();
            int expected = orig + 1;
            modify.addPlayer("TestAdd",20,155,1200,2.1);
            int actual = modify.countRows();
            Assert.AreEqual(expected, actual);
           
        }
        // check that update has worked by checking string in name
        [Test]
        public void validateUpdate()
        {
            ModifyDatabase modify = new ModifyDatabase();
            // we know from above test that original name is TestAdd
            modify.updatePlayer(modify.lastID, "TestChange", 20, 155, 1200, 2.1);
            string expected = "TestChange";
            modify.lastPlayerAdded();
            string actual = modify.showName(modify.lastID);
            Assert.AreEqual(expected, actual);

        }
        // check that player is deleted
        [Test]
        public void validateDelete()
        {
            ModifyDatabase modify = new ModifyDatabase();
            int orig = modify.countRows();
            int expected = orig - 1;
            modify.lastPlayerAdded();
            modify.removePlayer(modify.lastID);
            int actual = modify.countRows();
            Assert.AreEqual(expected, actual);

        }

    }
}

