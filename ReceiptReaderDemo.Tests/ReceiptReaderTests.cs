namespace ReceiptReaderDemo.Tests
{
    public class ReceiptReaderTests
    {
        [Theory]
        [InlineData("Images/Receipt1.jpg", "Rp197.200")]
        [InlineData("Images/Receipt2.jpg", "$56.73")]
        public async void Should_ReadReceipt(string image, string expected)
        {
            ReceiptReader reader = new();
            string result = await reader.Read(image);

            Assert.Contains(expected, result);
        }
    }
}