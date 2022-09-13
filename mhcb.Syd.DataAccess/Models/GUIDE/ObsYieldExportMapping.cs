﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("OBS_Yield_Export_Mapping")]
    public partial class ObsYieldExportMapping
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("OBS_CCY")]
        [StringLength(3)]
        public string ObsCcy { get; set; }
        [Column("OBS_YIELD_CURVE_TYPE")]
        [StringLength(25)]
        public string ObsYieldCurveType { get; set; }
        [Column("OBS_YIELD_MATURITY")]
        [StringLength(10)]
        public string ObsYieldMaturity { get; set; }
        [Column("MUREX_CCY")]
        [StringLength(3)]
        public string MurexCcy { get; set; }
        [StringLength(25)]
        public string Type { get; set; }
        [StringLength(30)]
        public string Generator { get; set; }
        [StringLength(30)]
        public string Market { get; set; }
        [StringLength(15)]
        public string Maturity { get; set; }
    }
}
