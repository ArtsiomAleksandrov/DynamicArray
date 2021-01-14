using Xunit;

namespace DynamicArray.Tests
{
    public class DynamicArrayTests
    {
        [Fact]
        public void Test_Can_Add_Elements()
        {
            DynamicArray<int> dArr = new DynamicArray<int>();

            int[] arr = {1,2,3,4,5,6,7};

            for(int i = 0; i < arr.Length; i++)
            {
                dArr.Add(arr[i]);
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Assert.Equal(arr[i], dArr[i]);
            }
        }

        [Fact]
        public void Test_Can_Remove_Elements_At_Index()
        {
            DynamicArray<int> dArr = new DynamicArray<int>{1,2,3,4,5,6,7};

            for(int i = 0; i < dArr.Size; i++)
            {
                //Returns removed element
                int elem = dArr.RemoveAt(i);

                Assert.DoesNotContain(elem, dArr);
            }
        }

        [Fact]
        public void Test_Can_Get_Index_Of_Element()
        {
            bool result = false;

            DynamicArray<int> dArr = new DynamicArray<int>{1,2,3,4,5,6,7};

            int elem =  5;
            int index = dArr.IndexOf(elem);

            for(int i = 0; i < dArr.Size; i++)
            {
                if(dArr[i] == elem && i == index) result = true;
            }

            Assert.True(result);
        }

        [Fact]
        public void Test_Can_Remove_Elements()
        {
            DynamicArray<int> dArr = new DynamicArray<int>{120,60,90,95,100};
            
            Assert.True(dArr.Remove(120));
            Assert.True(dArr.Remove(60));
            Assert.True(dArr.Remove(90));
            Assert.True(dArr.Remove(95));
            Assert.True(dArr.Remove(100));

        }

        [Fact]
        public void Test_Can_Clear_Array()
        {
            DynamicArray<int> dArr = new DynamicArray<int>{1,2,3,4,5,6,7};

            dArr.Clear();

            Assert.Empty(dArr);
        }
    }
}