using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SvitkovIA.Sprint6.TaskReview.V21.Lib;


namespace Tyuiu.SvitkovIA.Sprint6.TaskReview.V21.Test


{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            int n1 = 1;
            int n2 = 10;
            int c = 2;
            int k = 0;
            int l = 2;
            Matrix matrix = new Matrix();

            int result = matrix.GetMatrix(array, n1, n2, c, k, l);

            Assert.AreEqual(9, result);
        }
    }
}



