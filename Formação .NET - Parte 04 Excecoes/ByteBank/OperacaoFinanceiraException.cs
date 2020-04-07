﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }
        public OperacaoFinanceiraException(string message)
            : base(message)
        {

        }
        public OperacaoFinanceiraException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
