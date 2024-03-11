using AspirePOC.Employee.Interfaces;
using AspirePOC.Employee.Models;
using AspirePOC.Employee.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AspirePOC.Employee.Handlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Employees>
    {
        /*private readonly IEmployeeService employeeService;
        public CreateEmployeeHandler(IEmployeeService employeeService)
        { 
            this.employeeService = employeeService;
        }*/
        private readonly IEmployeeRepository employeeRepository;
        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        { 
            this.employeeRepository = employeeRepository;
        }
        public async Task<Employees> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.Create(request.employee);
        }
    }
}
