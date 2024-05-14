using DataStructure_And_Algorithms.DataStructures.List;

namespace DataStructure_And_Algorithms.test
{
    public class MyLinkedListTest
    {
        private MyLinkedList<int> _sut;
        
        public MyLinkedListTest() 
        {
            _sut = new MyLinkedList<int>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Should_Push_New_Element_In_List(int value)
        {
            //Arrange
            int listSize = _sut.size();

            //Act
            _sut.push(value);

            //Assert
            Assert.True(_sut.size() == listSize+1);
        }
    }
}