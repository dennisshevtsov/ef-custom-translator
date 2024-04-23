using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Reflection;

namespace EfCustomTranslator;

public sealed class CustomMethodCallTranslator(ISqlExpressionFactory sqlExpressionFactory) : IMethodCallTranslator
{
  private readonly ISqlExpressionFactory _sqlExpressionFactory = sqlExpressionFactory;

  public SqlExpression? Translate(SqlExpression? instance, MethodInfo method, IReadOnlyList<SqlExpression> arguments, IDiagnosticsLogger<DbLoggerCategory.Query> logger)
  {
    return null;
  }
}
