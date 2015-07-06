﻿/*
 * Copyright (C) 2015 Jacob Long
 * 
 * This file is part of Solipstry Character Creator
 * 
 * Solipstry Character Creator is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * any later version.
 * 
 * Solipstry Character Creator is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Affero General Public License for more details.
 * 
 * You should have received a copy of the GNU Affero General Public License
 * along with Solipstry Character Creator. If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solipstry_Character_Creator
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Window());
		}
	}
}
