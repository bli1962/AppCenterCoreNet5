﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("TREASURY_BNK_DIV_PROF", Schema = "EUC")]
    public partial class TreasuryBnkDivProf
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("INTER_APP_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? InterAppAcmBal { get; set; }
        [Column("INTER_APP_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? InterAppIntIncome { get; set; }
        [Column("EXTER_APP_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? ExterAppAcmBal { get; set; }
        [Column("EXTER_APP_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? ExterAppIntIncome { get; set; }
        [Column("INTER_ACQ_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? InterAcqAcmBal { get; set; }
        [Column("INTER_ACQ_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? InterAcqIntIncome { get; set; }
        [Column("EXTER_ACQ_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? ExterAcqAcmBal { get; set; }
        [Column("EXTER_ACQ_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? ExterAcqIntIncome { get; set; }
        [Column("FOREX_PL", TypeName = "decimal(18, 3)")]
        public decimal? ForexPl { get; set; }
        [Column("BROKERAGE_FEE", TypeName = "decimal(18, 3)")]
        public decimal? BrokerageFee { get; set; }
        [Column("OTHER_FEE", TypeName = "decimal(18, 3)")]
        public decimal? OtherFee { get; set; }
        [Column("INTER_INCOME_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? InterIncomeAcmBal { get; set; }
        [Column("INTER_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? InterIntIncome { get; set; }
        [Column("EXTER_INCOME_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? ExterIncomeAcmBal { get; set; }
        [Column("EXTER_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? ExterIntIncome { get; set; }
        [Column("IO_COMISSION", TypeName = "decimal(18, 3)")]
        public decimal? IoComission { get; set; }
        [Column("TOT_PROFIT_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? TotProfitPrevT { get; set; }
        [Column("TOT_PROFIT_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? TotProfitCurrM { get; set; }
        [Column("TOT_PROFIT_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? TotProfitCurrT { get; set; }
        [Column("PROMOTE_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? PromoteExpPrevT { get; set; }
        [Column("PROMOTE_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? PromoteExpCurrM { get; set; }
        [Column("PROMOTE_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? PromoteExpCurrT { get; set; }
        [Column("OPERATE_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OperateExpPrevT { get; set; }
        [Column("OPERATE_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? OperateExpCurrM { get; set; }
        [Column("OPERATE_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OperateExpCurrT { get; set; }
        [Column("RSV_BAD_DEBT_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? RsvBadDebtPrevT { get; set; }
        [Column("RSV_BAD_DEBT_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? RsvBadDebtCurrM { get; set; }
        [Column("RSV_BAD_DEBT_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? RsvBadDebtCurrT { get; set; }
        [Column("BR_COM_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? BrComExpPrevT { get; set; }
        [Column("BR_COM_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? BrComExpCurrM { get; set; }
        [Column("BR_COM_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? BrComExpCurrT { get; set; }
        [Column("DIV_COM_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? DivComExpPrevT { get; set; }
        [Column("DIV_COM_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? DivComExpCurrM { get; set; }
        [Column("DIV_COM_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? DivComExpCurrT { get; set; }
        [Column("HO_COST_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? HoCostPrevT { get; set; }
        [Column("HO_COST_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? HoCostCurrM { get; set; }
        [Column("HO_COST_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? HoCostCurrT { get; set; }
        [Column("OT_DIR_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OtDirExpPrevT { get; set; }
        [Column("OT_DIR_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? OtDirExpCurrM { get; set; }
        [Column("OT_DIR_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OtDirExpCurrT { get; set; }
        [Column("OT_INDIR_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OtIndirExpPrevT { get; set; }
        [Column("OT_INDIR_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? OtIndirExpCurrM { get; set; }
        [Column("OT_INDIR_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OtIndirExpCurrT { get; set; }
        [Column("NON_SETTLE_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? NonSettleExpPrevT { get; set; }
        [Column("NON_SETTLE_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? NonSettleExpCurrM { get; set; }
        [Column("NON_SETTLE_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? NonSettleExpCurrT { get; set; }
        [Column("CURR_M_DAYS")]
        [StringLength(2)]
        public string CurrMDays { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
