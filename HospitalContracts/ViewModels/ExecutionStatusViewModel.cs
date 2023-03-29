﻿using HospitalDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalContracts.ViewModels
{
    public class ExecutionStatusSearchModel : IExecutionStatus
    {
        public int Id { get; set; }

        [DisplayName("Статус исполнения")]
        public string ExecutionstatusName { get; set; } = string.Empty;
    }
}
