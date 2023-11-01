using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciasProfesionalesTec.Core.Abstractions;

public interface IAwsMessage : IRequest
{

}

//Sns
public interface ISnsMessage : IAwsMessage
{

}

//Sqs
public interface ISqsMessage : IAwsMessage
{

}
