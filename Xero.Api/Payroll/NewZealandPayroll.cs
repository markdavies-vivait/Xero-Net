using System.Collections.Generic;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Payroll.NewZealand.Endpoints;
using Xero.Api.Payroll.NewZealand.Model;
using Xero.Api.Payroll.Common;
using PayRun = Xero.Api.Payroll.NewZealand.Model.PayRun;
using System;

namespace Xero.Api.Payroll
{
    public class NewZealandPayroll : PayrollApi
    {
        public NewZealandPayroll(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user,
            IJsonObjectMapper readMapper, IXmlObjectMapper writeMapper)
            : this(baseUri, auth, consumer, user, readMapper, writeMapper, null)
        {
        }

        public NewZealandPayroll(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user, IJsonObjectMapper readMapper, IXmlObjectMapper writeMapper, IRateLimiter rateLimiter)
            : base(baseUri, auth, consumer, user, readMapper, writeMapper, rateLimiter)
        {
            Connect();
        }

        //public SuperFundsEndpoint SuperFunds { get; set; }
        //public SuperFundProductsEndpoint SuperFundProducts { get; set; }
        public EmployeeLeaveEndpoint LeaveApplications { get; set; }
        //public PayslipsEndpoint Payslips { get; private set; }

        public EmployeesEndpoint Employees { get; private set; }
        //public PayRunsEndpoint PayRuns { get; private set; }
        public TimesheetsEndpoint Timesheets { get; private set; }

        public EarningsRatesEndpoint EarningsRates { get; private set; }
        //public PayrollCalendarsEndpoint PayrollCalendars { get; private set; }
        public SettingsEndpoint Settings { get; private set; }
        public LeaveTypesEndpoint LeaveTypes { get; private set; }

        private void Connect()
        {
            //SuperFundProducts = new SuperFundProductsEndpoint(Client);
            //SuperFunds = new SuperFundsEndpoint(Client);
            //Payslips = new PayslipsEndpoint(Client);

            Employees = new EmployeesEndpoint(Client);
            //PayRuns = new PayRunsEndpoint(Client);
            Timesheets = new TimesheetsEndpoint(Client);
            //PayItems = new PayItemsEndpoint(Client);
            //PayrollCalendars = new PayrollCalendarsEndpoint(Client);
            Settings = new SettingsEndpoint(Client);
            EarningsRates = new EarningsRatesEndpoint(Client);
            LeaveTypes = new LeaveTypesEndpoint(Client);
        }

        //public IEnumerable<Payslip> Create(IEnumerable<Payslip> items)
        //{
        //    return Payslips.Create(items);
        //}

        //public IEnumerable<SuperFund> Create(IEnumerable<SuperFund> items)
        //{
        //    return SuperFunds.Create(items);
        //}

        public IEnumerable<Employee> Create(IEnumerable<Employee> items)
        {
            return Employees.Create(items);
        }

        //public IEnumerable<PayRun> Create(IEnumerable<PayRun> items)
        //{
        //    return PayRuns.Create(items);
        //}

        public Timesheet Create(Timesheet item)
        {
            return Timesheets.Create(item);
        }
        public TimesheetLine CreateTimesheetLine(Guid timesheetID, TimesheetLine items)
        {
            return new TimesheetLinesEndpoint(Client, timesheetID).CreateOne(items);
        }
        public EmployeeLeave CreateLeaveApplication(Guid employeeID, EmployeeLeave item)
        {
            return new EmployeeLeaveEndpoint(Client, employeeID).CreateOne(item);
        }


        //public IEnumerable<PayrollCalendar> Create(IEnumerable<PayrollCalendar> items)
        //{
        //    return PayrollCalendars.Create(items);
        //}

        //public Payslip Create(Payslip item)
        //{
        //    return Payslips.Create(item);
        //}

        //public SuperFund Create(SuperFund item)
        //{
        //    return SuperFunds.Create(item);
        //}

        public Employee Create(Employee item)
        {
            return Employees.Create(item);
        }

        //public PayRun Create(PayRun item)
        //{
        //    return PayRuns.Create(item);
        //}

        public EarningsRate Create(EarningsRate item)
        {
            return EarningsRates.Create(item);
        }
        public LeaveType Create(LeaveType item)
        {
            return LeaveTypes.Create(item);
        }

        //public PayItems Create(PayItems item)
        //{
        //    return PayItems.Create(item);
        //}

        //public PayrollCalendar Create(PayrollCalendar item)
        //{
        //    return PayrollCalendars.Create(item);
        //}

        //public IEnumerable<LeaveApplication> Update(IEnumerable<LeaveApplication> items)
        //{
        //    return LeaveApplications.Update(items);
        //}

        //public IEnumerable<Payslip> Update(IEnumerable<Payslip> items)
        //{
        //    return Payslips.Update(items);
        //}

        //public IEnumerable<SuperFund> Update(IEnumerable<SuperFund> items)
        //{
        //    return SuperFunds.Update(items);
        //}

        public IEnumerable<Employee> Update(IEnumerable<Employee> items)
        {
            return Employees.Update(items);
        }
        public IEnumerable<LeaveType> Update(IEnumerable<LeaveType> items)
        {
            return LeaveTypes.Update(items);
        }

        //public IEnumerable<PayRun> Update(IEnumerable<PayRun> items)
        //{
        //    return PayRuns.Update(items);
        //}

        public IEnumerable<Timesheet> Update(IEnumerable<Timesheet> items)
        {
            return Timesheets.Update(items);
        }

        //public IEnumerable<PayrollCalendar> Update(IEnumerable<PayrollCalendar> items)
        //{
        //    return PayrollCalendars.Update(items);
        //}

        //public LeaveApplication Update(LeaveApplication item)
        //{
        //    return LeaveApplications.Update(item);
        //}

        //public Payslip Update(Payslip item)
        //{
        //    return Payslips.Update(item);
        //}

        //public SuperFund Update(SuperFund item)
        //{
        //    return SuperFunds.Update(item);
        //}

        public Employee Update(Employee item)
        {
            return Employees.Update(item);
        }

        //public PayRun Update(PayRun item)
        //{
        //    return PayRuns.Update(item);
        //}

        public Timesheet Update(Timesheet item)
        {
            return Timesheets.Update(item);
        }

        public EarningsRate Update(EarningsRate item)
        {
            return EarningsRates.Update(item);
        }

        //public PayrollCalendar Update(PayrollCalendar item)
        //{
        //    return PayrollCalendars.Update(item);
        //}
    }
}