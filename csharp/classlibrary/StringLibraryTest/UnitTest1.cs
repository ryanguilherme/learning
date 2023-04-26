using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;


namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestStartsWithUpper()
    {
        string[] words = {"Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };

        foreach (var word in words)
        {
            //bool result = word.StartsWithUpper();
            //Assert.IsFalse(result, string.Format("Expected for '{0}': false; Actual: {1}", word, result));
        }
    }

    [TestMethod]
    public void TestDoesNotStartWithUpper()
    {
        // Tests that we expect to return false.
        string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство", "1234", ".", ";", " " };
        foreach (var word in words)
        {
            //bool result = word.StartsWithUpper();
           // Assert.IsFalse(result,
           //        string.Format("Expected for '{0}': false; Actual: {1}", word, result));
        }
    }

    [TestMethod]
    public void DirectCallWithNullOrEmpty()
    {
        string?[] words = { string.Empty, null };
        foreach (var word in words)
        {
            bool result = StringLibrary.StartsWithUppper(word);
            Assert.IsFalse(result, string.Format("Expected for '{0}': false; Actual: {1}", word == null ? "<null>" : word, result));
        }
    }
}