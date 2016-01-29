using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class NestedExpression
    {
    public   LambdaExpression CreateExpression(Type type, string propertyName)
      {
          var param = Expression.Parameter(type, "x");
          Expression body = param;
          foreach (var member in propertyName.Split('.'))
          {
              body = Expression.PropertyOrField(body, member);
          }
          return Expression.Lambda(body, param);
      }
    }
}
