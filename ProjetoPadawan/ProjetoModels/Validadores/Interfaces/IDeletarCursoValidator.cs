﻿using FluentValidation;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDomain.Validadores.Interfaces
{
    public interface IDeletarCursoValidator : IValidator<Guid>
    {
    }
}
