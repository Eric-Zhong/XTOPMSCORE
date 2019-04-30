//
//  DataSyncServiceProcess.cs
//
//  Author:
//       Eric-Zhong Xu <xu.zhong@hotmail.com>
//
//  Copyright (c) 2019 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using Hangfire.Annotations;
using Hangfire.Server;

namespace XTOPMS.DataSyncServices
{
    public class DataSyncServiceProcess: IBackgroundProcess
    {
        private readonly IDataSyncServiceManager dataSyncServiceManager;
        public DataSyncServiceProcess(
            IDataSyncServiceManager _d1
            )
        {
            dataSyncServiceManager = _d1;
        }

        public void Execute([NotNull] BackgroundProcessContext context)
        {
            Console.WriteLine("Begin to start data sync service background job. " + DateTime.Now.ToString());
            dataSyncServiceManager.Execution();
            // context.Wait(TimeSpan.FromSeconds(5));
            Console.WriteLine("Finish data sync service background job. " + DateTime.Now.ToString());

        }
    }
}
