using AspirePOC.Employee.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspirePOC.Employee.Commands
{
    public record CreateEmployeeCommand(Employees employee): IRequest<Employees>;
}
