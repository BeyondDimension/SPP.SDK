using SR = Mobius.Resources.Strings;

namespace Mobius.SDK.UnitTest;

public class ResTest
{
    [Test]
    public void StringsTest()
    {
        // 随机测试条目资源 Resx GetString
        TestContext.WriteLine(SR.About);
        TestContext.WriteLine(SR.AboutThisPlugin);
        Assert.Pass();
    }
}
