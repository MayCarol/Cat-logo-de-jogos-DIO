﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoGames.Exception
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base("Este já jogo está cadastrado")
        { }
    }
}
