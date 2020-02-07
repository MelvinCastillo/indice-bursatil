using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Gobix.BusinessLayer
{
   
    public class BussinessDays
    {
        private DataLayer.BussinessDays bussinessdays = new DataLayer.BussinessDays();

        public void generate(int year)
        {
            if (validate(year))
            {
                DateTime now = DateTime.Now;
                for (int month = 1; month <= 12; month++)
                {
                    int DaysInMonth = DateTime.DaysInMonth(year, month);

                    for (int day = 1; day <= DaysInMonth; day++)
                    {
                        DateTime CurrentDate = new DateTime(year, month, day);

                        int status = 0;

                        if (CurrentDate.DayOfWeek != DayOfWeek.Saturday && CurrentDate.DayOfWeek != DayOfWeek.Sunday)
                            status = 1;

                        bussinessdays.exe_sp_tbl_BussinesDays_set(year, CurrentDate, status);                        
                    }
                }

                bussinessdays.exe_sp_holidays_flaq(year);
            }
        }

        private bool validate(int year)
        {
            try
            {
                if (year == 0)
                    return false;

                return true;
            }
            catch 
            { 
                return false; 
            }
        }

    }
}
