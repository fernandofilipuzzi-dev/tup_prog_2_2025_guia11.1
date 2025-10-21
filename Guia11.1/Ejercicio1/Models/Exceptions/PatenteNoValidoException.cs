﻿using System;

namespace Ejercicio1.Models.Excepciones;

internal class PatenteNoValidoException : ApplicationException
{
    public PatenteNoValidoException() : base("Patente No Valida") { }
    public PatenteNoValidoException(string message) : base(message) { }
    public PatenteNoValidoException(string message, Exception innerException) : base(message, innerException) { }
}
