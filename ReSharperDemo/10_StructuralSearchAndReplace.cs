using System;

namespace ReSharperDemo
{
    public class StructuralSearchAndReplace
    {
        public void GetUtcTime()
        {
            //Invoke Structural Search, type DateTime.Today and click on Find. See usages of DateTime.Today
            var today = DateTime.Today;
        }

        public void FormatDateSouthAfrica()
        {
            var today = DateTime.Today.ToString("d");

        }

        //Invoke Structural Search, select replace. All the below int types will be replaced. The long will not be touched
        public void Replace()
        {
            int h = int.Parse("2");
            long l = int.Parse("77");

            while (true)
            {
                if (true)
                {
                    int a = int.Parse("442");
                    int c = int.Parse("32");
                }
            }
        }

        public Mango Replace2()
        {
            int h = int.Parse("2");

            return null;
        }

        public Mango ReplaceMethodReturnType()
        {
            return null;
        }
    }
}