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
    public class DeleteEmployeeByIdHandler : IRequestHandler<DeleteEmployeeByIdCommand, int>
    {
        /*private readonly IEmployeeService employeeService;
        public DeleteEmployeeByIdHandler(IEmployeeService employeeService)
        { 
            this.employeeService = employeeService;
        }*/
        private readonly IEmployeeRepository employeeRepository;
        public DeleteEmployeeByIdHandler(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public async Task<int> Handle(DeleteEmployeeByIdCommand request, CancellationToken cancellationToken)
        {
            var employee = await employeeRepository.GetByIdAsync(request.id);
            if (employee == null)
            {
                return 0;
            }
            return await employeeRepository.DeleteAsync(request.id);
        }
    }
}
