using DataStructure_And_Algorithms.DataStructures.List;

namespace DataStructure_And_Algorithms.test
{
    public class MyLinkedListTest
    {
        private MyLinkedList<int> _sut;
        
        public MyLinkedListTest() 
        {
            _sut = new MyLinkedList<int>();
            _sut.push(0);
            _sut.push(1);
            _sut.push(2);
            _sut.push(3);

        }

        [Theory]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void Should_Push_New_Element_In_List(int value)
        {
            //Arrange
            int listSize = _sut.size();

            //Act
            _sut.push(value);

            //Assert
            Assert.True(_sut.size() == listSize+1);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Should_getElementAt_If_Index_Is_Valid(int index)
        {
            //Arrange

            //Act
            var element = _sut.getElementAt(index);

            //Assert
            Assert.True(element.Value == index);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(100)]
        public void Should_getElementAt_Return_Null_If_Index_Is_Invalid(int index)
        {
            //Arrange

            //Act
            var element = _sut.getElementAt(index);

            //Assert
            Assert.Null(element);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void Should_RemoveAt_If_index_Is_valid(int index)
        {
            //Arrange
            var next = _sut.getElementAt(index + 1);
            var count = _sut.size();

            //Act
            var elem = _sut.RemoveAt(index);

            //
            Assert.Equal(count-1, _sut.size());
            Assert.Equal(next, _sut.getElementAt(index));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(100)]
        public void Should_RemoveAt_Returns_Null_If_index_Is_Invalid(int index)
        {
            //Arrange
            var count = _sut.size();
            //Act
            var elem = _sut.RemoveAt(index);

            //
            Assert.Null(elem);
            Assert.Equal(_sut.size(), count);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(3)]
        public void Should_RemoveItem_If_Item_Is_Inside_List(int item)
        {
            //Arrange
            var index = _sut.indexOf(item);
            var next = _sut.getElementAt(index + 1);
            var count = _sut.size();

            //Act
            var removedItem = _sut.RemoveItem(item);

            //
            Assert.Equal(next, _sut.getElementAt(index));
            Assert.Equal(_sut.size(), count-1);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(100)]
        public void Should_RemoveItem_Returns_Null_If_Item_NotFound(int item)
        {
            //Arrange
            var count = _sut.size();
            //Act
            var elem = _sut.RemoveItem(item);

            //
            Assert.Null(elem);
            Assert.Equal(_sut.size(), count);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(3)]
        public void Should_InsertAt_If_index_Is_Valid(int index)
        {
            //Arrange
            var next = _sut.getElementAt(index);
            var count = _sut.size();

            //Act
            var isInserted = _sut.InsertAt(index, 10);

            //
            Assert.True(isInserted);
            Assert.Equal(next, _sut.getElementAt(index).next);
            Assert.Equal(_sut.size(), count + 1);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(4)]
        public void Should_InsertAt_Returns_False_If_index_Is_Invalid(int index)
        {
            //Arrange
            var count = _sut.size();

            //Act
            var isInserted = _sut.InsertAt(index, 10);

            //
            Assert.False(isInserted);
            Assert.Equal(_sut.size(), count);
        }
    }
}