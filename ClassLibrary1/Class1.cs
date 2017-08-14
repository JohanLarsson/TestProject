namespace ClassLibrary1
{
    using Microsoft.CodeAnalysis;

    public class Class1
    {
        public static Solution CreateSolution()
        {
            return new AdhocWorkspace().CurrentSolution;
        }
    }
}
