﻿/*
 * Copyright (C) 2007-2012 University of Cambridge
 *
 * This file is part of Fosstrak (www.fosstrak.org).
 *
 * Fosstrak is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License version 2.1, as published by the Free Software Foundation.
 *
 * Fosstrak is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with Fosstrak; if not, write to the Free
 * Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
 * Boston, MA  02110-1301  USA
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FOSSTRAK.TDT
{

    /// <summary>
    /// A TDTException is thrown at runtime when the user supplies invalid or incomplete input.
    /// </summary>
    /// <remarks>Author Mike Lohmeier myname@gmail.com</remarks>
    public class TDTTranslationException : Exception
    {
        public TDTTranslationException(String message)
            : base(message)
        {
        }
    }
}
