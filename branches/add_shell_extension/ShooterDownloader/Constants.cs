﻿/*
 *   Shooter Subtitle Downloader: Automatic Subtitle Downloader for the http://shooter.cn.
 *   Copyright (C) 2009  John Fung
 *
 *   This program is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU Affero General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU Affero General Public License for more details.
 *
 *   You should have received a copy of the GNU Affero General Public License
 *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */


namespace ShooterDownloader
{
    class ShooterConst
    {
        public const int Error = -1;
        public const int NoSubFound = -2;
        public const int MaxConcurrentJobs = 3;
        public const string ShellExtFileName = "ShooterExt.dll";
        public const string ShellExtFileNameX64 = "ShooterExt_x64.dll";
        public const string ShellExtClsid = "{5258ACEF-6A10-4CDC-B5A5-B4B0D7EF23B2}";
    }
}