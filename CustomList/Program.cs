namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            CustomList<string> customlist1 = new CustomList<string>();



            //Act
            customlist1.Add("E");
            customlist1.Add("Apple");
        }
    }

}