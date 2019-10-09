using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Paycompute.Entity;
using Paycompute.Models;
using Paycompute.Services;

namespace Paycompute.Controllers
{

    [Authorize]
    public class EmployeeController :Controller
    {

        private readonly IEmployeeService _employeeService;

        private readonly HostingEnvironment _hostingenvironment;
        private int id;

        public EmployeeController(IEmployeeService employeeService, HostingEnvironment hostingenvironment)
        {
            _employeeService = employeeService;
            _hostingenvironment = hostingenvironment;

        }

        public IActionResult Index(int? pageNumber)
        {
            var employees = _employeeService.GetAll().Select(employee => new EmployeeIndexViewModel
            {

                ID = employee.Id,
                EmployeeNo = employee.EmployeeNo,
                ImageUrl = employee.ImageUrl,
                FullName = employee.FullName,
                Gender = employee.Gender,
                Designation = employee.Designation,
                City = employee.City,
                DateJoined = employee.DateJoined


            }
            ).ToList();
            int pageSize = 4;
            return View(EmployeeListPagination<EmployeeIndexViewModel>.Create(employees, pageNumber ?? 1, pageSize) );
        }

        [HttpGet]
        public IActionResult Create()
        {

            var model = new EmployeeCreateViewModel();

           

            return View(model); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]  //Prevents cross-site Request Forgery Attacks
        public async Task<IActionResult> Create(EmployeeCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                var employee = new Employee
                {
                    Id = model.Id,
                    EmployeeNo = model.EmployeeNo,
                    FirstName = model.FirstName,
                    MiddleName = model.MiddleName,
                    LastName = model.LastName,
                    FullName = model.FullName,
                    Gender = model.Gender,
                    Email = model.Email,
                    DOB = model.DOB,
                    DateJoined = model.DateJoined,
                    NationalInsuranceNo = model.NationalInsuranceNo,
                    PaymentMetod = model.PaymentMetod,
                    StudentLoan = model.StudentLoan,
                    UnionMember = model.UnionMember,
                    Address = model.Address,
                    City = model.City,
                    Phone = model.Phone,
                    PostCode = model.PostCode,
                    Designation = model.Designation,

                    

                };
                if(model.ImageUrl != null && model.ImageUrl.Length > 0)
                {
                    var uploadDir = @"images/employees";
                    var filename = Path.GetFileNameWithoutExtension(model.ImageUrl.FileName);
                    var extension = Path.GetExtension(model.ImageUrl.FileName);
                    var webRootPath = _hostingenvironment.WebRootPath;
                    filename = DateTime.UtcNow.ToString("yyyymmssfff") + filename + extension;

                    var path = Path.Combine(webRootPath, uploadDir, filename);
                    await model.ImageUrl.CopyToAsync(new FileStream(path, FileMode.Create));
                    employee.ImageUrl = "/" + uploadDir + "/" + filename;

                }

                await _employeeService.CreateAsync(employee);
                return RedirectToAction(nameof(Index));


            }

            return View();

        }

        
        public IActionResult Edit(int id)
        {

            var employee = _employeeService.GetByID(id);

            if (employee == null)
            {

                return NotFound();
            }

            var model = new EmployeeEditViewModel()
            {
                    Id = employee.Id,
                    EmployeeNo = employee.EmployeeNo,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    
                    Gender = employee.Gender,
                    Email = employee.Email,
                    DOB = employee.DOB,
                    DateJoined = employee.DateJoined,
                    NationalInsuranceNo = employee.NationalInsuranceNo,
                    PaymentMetod = employee.PaymentMetod,
                    StudentLoan = employee.StudentLoan,
                    UnionMember = employee.UnionMember,
                    Address = employee.Address,
                    City = employee.City,
                    Phone = employee.Phone,
                    PostCode = employee.PostCode,
                    Designation = employee.Designation,

            };

            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EmployeeEditViewModel model)
        {

            if (ModelState.IsValid)
            {
                var employee = _employeeService.GetByID(model.Id);

                if (employee == null)
                {

                    return NotFound();
                }
                //{

                    employee.EmployeeNo = model.EmployeeNo;
                    employee.FirstName = model.FirstName;
                    employee.MiddleName = model.MiddleName;
                    employee.LastName = model.LastName;

                    employee.Gender = model.Gender;
                    employee.Email = model.Email;
                    employee.DOB = model.DOB;
                    employee.DateJoined = model.DateJoined;
                    employee.NationalInsuranceNo = model.NationalInsuranceNo;
                    employee.PaymentMetod = model.PaymentMetod;
                    employee.StudentLoan = model.StudentLoan;
                    employee.UnionMember = model.UnionMember;
                    employee.Address = model.Address;
                    employee.City = model.City;
                    employee.Phone = model.Phone;
                    employee.PostCode = model.PostCode;
                    employee.Designation = model.Designation;


                    if(model.ImageUrl != null && model.ImageUrl.Length > 0)
                    {
                        var uploadDir = @"images/employees";
                        var filename = Path.GetFileNameWithoutExtension(model.ImageUrl.FileName);
                        var extension = Path.GetExtension(model.ImageUrl.FileName);
                        var webRootPath = _hostingenvironment.WebRootPath;
                        filename = DateTime.UtcNow.ToString("yyyymmssfff") + filename + extension;

                        var path = Path.Combine(webRootPath, uploadDir, filename);
                        await model.ImageUrl.CopyToAsync(new FileStream(path, FileMode.Create));
                        employee.ImageUrl = "/" + uploadDir + "/" + filename;

                    }

                    await _employeeService.UpdateAsync(employee);
                    return RedirectToAction(nameof(Index));
                    
                }
                return View();

        }


        [HttpGet]
        public IActionResult Detail(int id)
        {

            var employee = _employeeService.GetByID(id);
            if(employee == null)
            {

                return NotFound();

            }

            EmployeeDetailViewModel model = new EmployeeDetailViewModel()
            {

                Id = employee.Id,
                EmployeeNo = employee.EmployeeNo,
                FullName = employee.FullName,


                Gender = employee.Gender,
                Email = employee.Email,
                DOB = employee.DOB,
                DateJoined = employee.DateJoined,
                NationalInsuranceNo = employee.NationalInsuranceNo,
                PaymentMetod = employee.PaymentMetod,
                StudentLoan = employee.StudentLoan,
                UnionMember = employee.UnionMember,
                Address = employee.Address,
                City = employee.City,
                Phone = employee.Phone,
                PostCode = employee.PostCode,
                Designation = employee.Designation,
                ImageUrl = employee.ImageUrl,

            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {


            var employee = _employeeService.GetByID(id);


            if (employee == null)
            {

                return NotFound();

            }

            var model = new EmployeeDeleteViewModel()
            {

                Id = employee.Id,
                FullName = employee.FullName
            };
            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(EmployeeDeleteViewModel model)
        {
           await  _employeeService.Delete(model.Id);
            return RedirectToAction(nameof(Index));
            

        }

    }
}
