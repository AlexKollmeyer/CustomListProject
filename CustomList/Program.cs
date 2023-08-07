namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Arrange
            CustomList<string>  customList1 = new CustomList<string>();
            customList1.Add("e");
            customList1.Add("greg");

            //Act
            customList1.Remove("Apple");
        }
    }

}