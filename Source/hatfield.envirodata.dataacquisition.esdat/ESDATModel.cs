﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatfield.EnviroData.DataAcquisition.ESDAT
{
    public class ESDATModel
    {
        //Header file properties
        public DateTime DateReported { get ; set; }
        public int ProjectId { get; set; }
        public string LabName { get; set; }
        public string LabSignatory { get; set; }
        public List<string> AssociatedFiles { get; set; }
        public List<string> CopiesSentTo { get; set; }
        public int SDGID { get; set; }
        public int COCNumber { get; set; }
        public int LabRequestId { get; set; }
        public int LabRequestNumber { get; set; }
        public decimal LabRequestVersion { get; set; }

        //Other Data
        public List<AnalyzedData> AnalyzedData { get; set; }

        public ESDATModel(DateTime dateReported, int projectID, string labName, string labSignatory, List<string> associatedFiles, List<string> copiesSentTo, int sdgid, int cocNumber, int labRequestID, int labRequestNumber, decimal labRequestVersion)
        {
            this.DateReported = dateReported;
            this.ProjectId = projectID;
            this.LabName = labName;
            this.LabSignatory = labSignatory;
            this.AssociatedFiles = associatedFiles;
            this.CopiesSentTo = copiesSentTo;
            this.SDGID = sdgid;
            this.COCNumber = cocNumber;
            this.LabRequestId = labRequestID;
            this.LabRequestNumber = labRequestNumber;
            this.LabRequestVersion = labRequestVersion;
        }
      
    }
}