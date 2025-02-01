using LMS.DAL;
using LMS.MOD;
using System;

namespace LMS.BL
{
    public static class DashboardBL
    {
        public static Dashboard GetDashboard()
        {
            try
            {
                Dashboard dashboard = DashboardDAL.GetDashboard();
                return dashboard;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
