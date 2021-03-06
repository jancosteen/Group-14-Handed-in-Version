﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Contacts
{
    public interface IReportingRepositoryBase<T>
    {
        IQueryable<T> GenerateReport(FormattableString expression);
    }
}
