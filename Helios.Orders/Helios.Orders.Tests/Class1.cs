using System;
using Xunit;

namespace Helios.Orders.Tests
{
    /**
     * 
     * 创建订单
     * 订单拆分
     * 订单合并
     * 汇总数据计算正确
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
    public class XTestDemo
    {
        [Fact(DisplayName = "单元测试示例")]
        public void Test1()
        {
            Assert.Equal(2, 1+1);
        }

        [Theory(DisplayName = "多参数单元测试示例")]
        [InlineData(1, 2, 3)]
        [InlineData(78, 34, 2652)]
        [InlineData(78, 34, 100)]
        public void Test2(int a, int b, int result)
        {
            Assert.Equal(result, a * b);
        }
    }
}
