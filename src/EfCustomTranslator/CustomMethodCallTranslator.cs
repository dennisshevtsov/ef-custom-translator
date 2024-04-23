// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

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
