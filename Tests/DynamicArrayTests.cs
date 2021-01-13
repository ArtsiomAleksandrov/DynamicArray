using Xunit;

namespace DynamicArray.Tests
{
    //Class created for testing purposes
    class Book
    {
        public string title {get; set;}
    }

    public class DynamicArrayTests
    {
        private DynamicArray<Book> books = new DynamicArray<Book>
        {
            new Book {title = "The Last Wish"},
            new Book {title = "The Song Of Ice and Fire"},
        };

        [Fact]
        public void Test_Can_Add_Element_To_Array()
        {
            bool result = false;

            Book testBook = new Book {title = "Lord Of The Rings"};

            books.Add(testBook);

            for(int i = 0; i < books.Size; i++)
            {
                if(books[i] == testBook) result = true;
            }

            Assert.True(result);
        }

        [Fact]
        public void Test_Can_Remove_Element_From_Array()
        {
            bool result = true;

            int index = 1;

            Book testBook = books[index];
            
            books.RemoveAt(index);

            for(int i = 0; i < books.Size; i++)
            {
                if(books[i] == testBook) result = false;
            }

            Assert.True(result);
        }

        [Fact]
        public void Test_Can_Clear_Array()
        {
            bool result = true;

            books.Clear();

            for(int i = 0; i<books.Size; i++){
                if(books[i] != null) result = false;
            }
            
            Assert.True(result);
        }
    }
}