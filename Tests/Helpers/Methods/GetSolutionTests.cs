﻿using Nc.Helpers.Methods;
using System.Reflection;

namespace Nc.Tests.Helpers.Methods; 
[TestClass] public class GetSolutionTests : BaseTests {
    protected override Type? type => typeof(GetSolution);

    [TestMethod, DynamicData(nameof(TestData), DynamicDataSourceType.Method)]
    public void AssemblyTest(string name) {
        var actual = GetSolution.Assembly(name);
        var expected = Assembly.Load(name);
        Assert.IsNotNull(expected);
        Assert.AreSame(expected, actual);
    }

    [TestMethod, DynamicData(nameof(TestData), DynamicDataSourceType.Method)]
    public void TypesTest(string name) {
        var actual = GetSolution.Types(name);
        var expected = GetSolution.Types(GetSolution.Assembly(name));
        Assert.AreEqual(actual.Count, expected.Count);
        foreach (var a in actual) {
            Assert.IsTrue(expected.Contains(a));
        }
    }

    [TestMethod, DynamicData(nameof(TestData), DynamicDataSourceType.Method)]
    public void TypesByAssemblyTest(string name) {
        var assembly = Assembly.Load(name);
        var actual = GetSolution.Types(name);
        var expected = assembly.GetTypes().Where(x => !x.Name.StartsWith('<')).ToList();
        Assert.AreEqual(actual.Count, expected.Count);
        foreach (var a in actual) {
            Assert.IsTrue(expected.Contains(a));
        }
    }

    private static IEnumerable<object[]> TestData() {
        yield return ["Nc.Helpers"];
        yield return ["Nc.Data"];
        yield return ["Nc.Domain"];
        yield return ["Nc.Tests.Helpers"];
    }
}
