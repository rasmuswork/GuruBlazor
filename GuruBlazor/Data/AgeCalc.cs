using System;


namespace GuruBlazor.Data
{
    




    public class AgeCalc
	{
        private int BirthYear = 1997;

        public int Age;

        public void CalculateAge()
        {
            int currentYear = DateTime.Now.Year;
            Age = currentYear - BirthYear;
        }
    }
}

