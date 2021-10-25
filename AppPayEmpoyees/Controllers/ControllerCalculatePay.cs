using AppPayEmpoyees.Models;
using AppPayEmpoyees.Utility;
using System;
using System.Collections.Generic;

namespace AppPayEmpoyees.Controllers
{
    class ControllerCalculatePay
    {
        private UtilityTextFile objUtilityTextFile = new UtilityTextFile();

        private ManageDataContext objManageDataContext = new ManageDataContext();

        //OBTAIN SUM ALL EMPLOYEES TO PAY AND PRINT VALUES IN THE CONSOLE 
        public void CalculatePayEmployee()
        {
            string strData = objUtilityTextFile.ReadTextFileData();
            string nameEmplyee = "";
            string[] arrayData = strData.Split(';');

            foreach (var item in arrayData)
            {
                double valuePay = 0;
                string result = "";

                if (item.ToString() != null)
                {
                    string[] arrayName = item.Split('=');
                    nameEmplyee = arrayName[0];

                    if (arrayName.Length > 1)
                    {
                        if (arrayName[1] != null)
                        {
                            valuePay = ManageHoursEmployee(arrayName[1]);
                        }
                    }
                }

                result = "The amount to pay " + nameEmplyee + " is: " + valuePay + " USD";

                Console.WriteLine(result);
            }
        }


        //METHOD FOR CALCULATE VALUE TO PAY 
        public double CalcValueToPay(string rangeDays, string valueRange, string itemArrayHours, List<HoursPay> getHoursPayDayWeek)
        {
            double valuePay = 0;

            if (rangeDays.Contains(valueRange))
            {
                string compareString = itemArrayHours.Substring(2);

                string[] arrHour = compareString.Split('-');

                if (arrHour[0] != null && arrHour[1] != null)
                {
                    foreach (var itemHoursPayDayWeek in getHoursPayDayWeek)
                    {
                        if (DateTime.Compare(DateTime.Parse(arrHour[0]), DateTime.Parse(itemHoursPayDayWeek.startTime)) >= 0 && (DateTime.Compare(DateTime.Parse(arrHour[0]), DateTime.Parse(itemHoursPayDayWeek.endTime)) <= 0 || itemHoursPayDayWeek.endTime == "00:00"))
                        {
                            if (DateTime.Compare(DateTime.Parse(arrHour[1]), DateTime.Parse(itemHoursPayDayWeek.startTime)) >= 0 && (DateTime.Compare(DateTime.Parse(arrHour[1]), DateTime.Parse(itemHoursPayDayWeek.endTime)) <= 0 || itemHoursPayDayWeek.endTime == "00:00"))
                            {
                                valuePay += itemHoursPayDayWeek.payValue * HoursSum(arrHour[0], arrHour[1]);
                            }
                        }
                    }
                }
            }

            return valuePay;
        }

        //CALC SUM HOURS WORK FOR EMPLOYEE FOR DAY
        public int HoursSum(string hourStart, string hourEnd)
        {
            int result = int.Parse(hourEnd.Split(':')[0]) - int.Parse(hourStart.Split(':')[0]);

            return result;
        }

        //CREATE FILE WITH DATA IN DESKTOP
        public void CreateFileData()
        {
            objUtilityTextFile.WriteTextFileData();
        }

        //MANAGE HOURS VALUE TO PAY
        public double ManageHoursEmployee(string dataEmployee)
        {
            double valuePay = 0;
            string[] arrayHours = dataEmployee.Split(',');

            foreach (var itemArrayHours in arrayHours)
            {
                if (itemArrayHours != null)
                {
                    List<DaysWeek> daysWeeks = objManageDataContext.GetDaysWeeks();

                    foreach (var itemDaysWeeks in daysWeeks)
                    {
                        if (itemArrayHours.Contains(itemDaysWeeks.acronymDay))
                        {
                            valuePay += CalcValueToPay("MO,TU,WE,TH,FR", itemDaysWeeks.acronymDay, itemArrayHours, objManageDataContext.GetHoursPayDayWeek());

                            valuePay += CalcValueToPay("SA,SU", itemDaysWeeks.acronymDay, itemArrayHours, objManageDataContext.GetHoursPayDaysEndWeek());
                        }
                    }

                }
            }

            return valuePay;
        }
    }
}
