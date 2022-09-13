﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("INCOMING_REMITTANCE", Schema = "EUC")]
    public partial class IncomingRemittance
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("OUTPUT_SERIAL_NO")]
        [StringLength(5)]
        public string OutputSerialNo { get; set; }
        [Column("SUB_NO")]
        [StringLength(2)]
        public string SubNo { get; set; }
        [Column("OUTPUT_DATE")]
        [StringLength(2)]
        public string OutputDate { get; set; }
        [Column("OUTPUT_TIME")]
        [StringLength(4)]
        public string OutputTime { get; set; }
        [Column("OUTPUT_ID")]
        [StringLength(12)]
        public string OutputId { get; set; }
        [Column("INPUT_DATE")]
        [StringLength(2)]
        public string InputDate { get; set; }
        [Column("INPUT_TIME")]
        [StringLength(4)]
        public string InputTime { get; set; }
        [Column("INPUT_ID")]
        [StringLength(12)]
        public string InputId { get; set; }
        [Column("INPUT_SERIAL_NO")]
        [StringLength(5)]
        public string InputSerialNo { get; set; }
        [Column("INPUT_MSG_TYPE")]
        [StringLength(3)]
        public string InputMsgType { get; set; }
        [Column("PRIORITY")]
        [StringLength(2)]
        public string Priority { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("FILE_MAKE_DATE", TypeName = "datetime")]
        public DateTime? FileMakeDate { get; set; }
        [Column("FILE_MAKE_TIME")]
        [StringLength(6)]
        public string FileMakeTime { get; set; }
        [Column("TRANS_NO")]
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column("DELETE_FLG")]
        [StringLength(1)]
        public string DeleteFlg { get; set; }
        [Column("OUT_IN_FLG")]
        [StringLength(1)]
        public string OutInFlg { get; set; }
        [Column("OUTGOING_MSG_TYPE")]
        [StringLength(3)]
        public string OutgoingMsgType { get; set; }
        [Column("SEND_BANK_ID")]
        [StringLength(12)]
        public string SendBankId { get; set; }
        [Column("SEND_BANK_NAME_1")]
        [StringLength(35)]
        public string SendBankName1 { get; set; }
        [Column("SEND_BANK_NAME_2")]
        [StringLength(35)]
        public string SendBankName2 { get; set; }
        [Column("SEND_BANK_NAME_3")]
        [StringLength(35)]
        public string SendBankName3 { get; set; }
        [Column("SEND_BANK_NAME_4")]
        [StringLength(35)]
        public string SendBankName4 { get; set; }
        [Column("THEIR_REF_NO")]
        [StringLength(16)]
        public string TheirRefNo { get; set; }
        [Column("RELATED_MSG_AND_REFNO")]
        [StringLength(16)]
        public string RelatedMsgAndRefno { get; set; }
        [Column("SWIFT_CCY_CD")]
        [StringLength(3)]
        public string SwiftCcyCd { get; set; }
        [Column("AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? Amount { get; set; }
        [Column("ORDER_CUST_NAME_1")]
        [StringLength(35)]
        public string OrderCustName1 { get; set; }
        [Column("ORDER_CUST_NAME_2")]
        [StringLength(35)]
        public string OrderCustName2 { get; set; }
        [Column("ORDER_CUST_NAME_3")]
        [StringLength(35)]
        public string OrderCustName3 { get; set; }
        [Column("ORDER_CUST_NAME_4")]
        [StringLength(35)]
        public string OrderCustName4 { get; set; }
        [Column("ORD_BANK_ID")]
        [StringLength(12)]
        public string OrdBankId { get; set; }
        [Column("ORDER_BANK_NAME_1")]
        [StringLength(35)]
        public string OrderBankName1 { get; set; }
        [Column("ORDER_BANK_NAME_2")]
        [StringLength(35)]
        public string OrderBankName2 { get; set; }
        [Column("ORDER_BANK_NAME_3")]
        [StringLength(35)]
        public string OrderBankName3 { get; set; }
        [Column("ORDER_BANK_NAME_4")]
        [StringLength(35)]
        public string OrderBankName4 { get; set; }
        [Column("S_COR_BANK_ID")]
        [StringLength(12)]
        public string SCorBankId { get; set; }
        [Column("S_COR_BANK_ACTNO")]
        [StringLength(35)]
        public string SCorBankActno { get; set; }
        [Column("S_COR_BANK_NAME1")]
        [StringLength(35)]
        public string SCorBankName1 { get; set; }
        [Column("S_COR_BANK_NAME2")]
        [StringLength(35)]
        public string SCorBankName2 { get; set; }
        [Column("S_COR_BANK_NAME3")]
        [StringLength(35)]
        public string SCorBankName3 { get; set; }
        [Column("S_COR_BANK_NAME4")]
        [StringLength(35)]
        public string SCorBankName4 { get; set; }
        [Column("REC_COR_BANK_ID")]
        [StringLength(12)]
        public string RecCorBankId { get; set; }
        [Column("REC_COR_BANK_NAME1")]
        [StringLength(35)]
        public string RecCorBankName1 { get; set; }
        [Column("REC_COR_BANK_NAME2")]
        [StringLength(35)]
        public string RecCorBankName2 { get; set; }
        [Column("REC_COR_BANK_NAME3")]
        [StringLength(35)]
        public string RecCorBankName3 { get; set; }
        [Column("REC_COR_BANK_NAME4")]
        [StringLength(35)]
        public string RecCorBankName4 { get; set; }
        [Column("INT_BANK_ID")]
        [StringLength(12)]
        public string IntBankId { get; set; }
        [Column("INT_BANK_NAME1")]
        [StringLength(35)]
        public string IntBankName1 { get; set; }
        [Column("INT_BANK_NAME2")]
        [StringLength(35)]
        public string IntBankName2 { get; set; }
        [Column("INT_BANK_NAME3")]
        [StringLength(35)]
        public string IntBankName3 { get; set; }
        [Column("INT_BANK_NAME4")]
        [StringLength(35)]
        public string IntBankName4 { get; set; }
        [Column("ACC_BANK_ID")]
        [StringLength(12)]
        public string AccBankId { get; set; }
        [Column("ACC_BANK_NAME_1")]
        [StringLength(35)]
        public string AccBankName1 { get; set; }
        [Column("ACC_BANK_NAME_2")]
        [StringLength(35)]
        public string AccBankName2 { get; set; }
        [Column("ACC_BANK_NAME_3")]
        [StringLength(35)]
        public string AccBankName3 { get; set; }
        [Column("ACC_BANK_NAME_4")]
        [StringLength(35)]
        public string AccBankName4 { get; set; }
        [Column("BENE_BANK_ID")]
        [StringLength(12)]
        public string BeneBankId { get; set; }
        [Column("BENE_BANK_ACTNO")]
        [StringLength(35)]
        public string BeneBankActno { get; set; }
        [Column("BENE_BANK_NAME_1")]
        [StringLength(35)]
        public string BeneBankName1 { get; set; }
        [Column("BENE_BANK_NAME_2")]
        [StringLength(35)]
        public string BeneBankName2 { get; set; }
        [Column("BENE_BANK_NAME_3")]
        [StringLength(35)]
        public string BeneBankName3 { get; set; }
        [Column("BENE_BANK_NAME_4")]
        [StringLength(35)]
        public string BeneBankName4 { get; set; }
        [Column("PAYMENT_DETAIL_1")]
        [StringLength(35)]
        public string PaymentDetail1 { get; set; }
        [Column("PAYMENT_DETAIL_2")]
        [StringLength(35)]
        public string PaymentDetail2 { get; set; }
        [Column("PAYMENT_DETAIL_3")]
        [StringLength(35)]
        public string PaymentDetail3 { get; set; }
        [Column("PAYMENT_DETAIL_4")]
        [StringLength(35)]
        public string PaymentDetail4 { get; set; }
        [Column("CHARGE_DETAIL")]
        [StringLength(3)]
        public string ChargeDetail { get; set; }
        [Column("BANK_INF_1")]
        [StringLength(35)]
        public string BankInf1 { get; set; }
        [Column("BANK_INF_2")]
        [StringLength(35)]
        public string BankInf2 { get; set; }
        [Column("BANK_INF_3")]
        [StringLength(35)]
        public string BankInf3 { get; set; }
        [Column("BANK_INF_4")]
        [StringLength(35)]
        public string BankInf4 { get; set; }
        [Column("BANK_INF_5")]
        [StringLength(35)]
        public string BankInf5 { get; set; }
        [Column("BANK_INF_6")]
        [StringLength(35)]
        public string BankInf6 { get; set; }
        [Column("TAG23B_BK_OPCD")]
        [StringLength(4)]
        public string Tag23bBkOpcd { get; set; }
        [Column("TAG23E_INST_CODE1")]
        [StringLength(4)]
        public string Tag23eInstCode1 { get; set; }
        [Column("TAG23E_INST_INF1")]
        [StringLength(30)]
        public string Tag23eInstInf1 { get; set; }
        [Column("TAG23E_INST_CODE2")]
        [StringLength(4)]
        public string Tag23eInstCode2 { get; set; }
        [Column("TAG23E_INST_INF2")]
        [StringLength(30)]
        public string Tag23eInstInf2 { get; set; }
        [Column("TAG23E_INST_CODE3")]
        [StringLength(4)]
        public string Tag23eInstCode3 { get; set; }
        [Column("TAG23E_INST_INF3")]
        [StringLength(30)]
        public string Tag23eInstInf3 { get; set; }
        [Column("TAG23E_INST_CODE4")]
        [StringLength(4)]
        public string Tag23eInstCode4 { get; set; }
        [Column("TAG23E_INST_INF4")]
        [StringLength(30)]
        public string Tag23eInstInf4 { get; set; }
        [Column("TAG23E_INST_CODE5")]
        [StringLength(4)]
        public string Tag23eInstCode5 { get; set; }
        [Column("TAG23E_INST_INF5")]
        [StringLength(30)]
        public string Tag23eInstInf5 { get; set; }
        [Column("TAG23E_INST_CODE6")]
        [StringLength(4)]
        public string Tag23eInstCode6 { get; set; }
        [Column("TAG23E_INST_INF6")]
        [StringLength(30)]
        public string Tag23eInstInf6 { get; set; }
        [Column("TAG23E_INST_CODE7")]
        [StringLength(4)]
        public string Tag23eInstCode7 { get; set; }
        [Column("TAG23E_INST_INF7")]
        [StringLength(30)]
        public string Tag23eInstInf7 { get; set; }
        [Column("TAG23E_INST_CODE8")]
        [StringLength(4)]
        public string Tag23eInstCode8 { get; set; }
        [Column("TAG23E_INST_INF8")]
        [StringLength(30)]
        public string Tag23eInstInf8 { get; set; }
        [Column("TAG23E_INST_CODE9")]
        [StringLength(4)]
        public string Tag23eInstCode9 { get; set; }
        [Column("TAG23E_INST_INF9")]
        [StringLength(30)]
        public string Tag23eInstInf9 { get; set; }
        [Column("TAG26T_TRANS_TYPE")]
        [StringLength(3)]
        public string Tag26tTransType { get; set; }
        [Column("TAG33B_SW_CCY")]
        [StringLength(3)]
        public string Tag33bSwCcy { get; set; }
        [Column("TAG33B_CCY")]
        [StringLength(2)]
        public string Tag33bCcy { get; set; }
        [Column("TAG33B_AMT", TypeName = "decimal(16, 3)")]
        public decimal? Tag33bAmt { get; set; }
        [Column("TAG36_RATE")]
        [StringLength(12)]
        public string Tag36Rate { get; set; }
        [Column("TAG50A_ORD_CST_ACT_NO")]
        [StringLength(35)]
        public string Tag50aOrdCstActNo { get; set; }
        [Column("TAG71F_SE_CHG_SW_CCY1")]
        [StringLength(3)]
        public string Tag71fSeChgSwCcy1 { get; set; }
        [Column("TAG71F_SE_CHG_CCY1")]
        [StringLength(2)]
        public string Tag71fSeChgCcy1 { get; set; }
        [Column("TAG71F_SE_CHG_AMT1", TypeName = "decimal(16, 3)")]
        public decimal? Tag71fSeChgAmt1 { get; set; }
        [Column("TAG71F_SE_CHG_SW_CCY2")]
        [StringLength(3)]
        public string Tag71fSeChgSwCcy2 { get; set; }
        [Column("TAG71F_SE_CHG_CCY2")]
        [StringLength(2)]
        public string Tag71fSeChgCcy2 { get; set; }
        [Column("TAG71F_SE_CHG_AMT2", TypeName = "decimal(16, 3)")]
        public decimal? Tag71fSeChgAmt2 { get; set; }
        [Column("TAG71F_SE_CHG_SW_CCY3")]
        [StringLength(3)]
        public string Tag71fSeChgSwCcy3 { get; set; }
        [Column("TAG71F_SE_CHG_CCY3")]
        [StringLength(2)]
        public string Tag71fSeChgCcy3 { get; set; }
        [Column("TAG71F_SE_CHG_AMT3", TypeName = "decimal(16, 3)")]
        public decimal? Tag71fSeChgAmt3 { get; set; }
        [Column("TAG71F_SE_CHG_SW_CCY4")]
        [StringLength(3)]
        public string Tag71fSeChgSwCcy4 { get; set; }
        [Column("TAG71F_SE_CHG_CCY4")]
        [StringLength(2)]
        public string Tag71fSeChgCcy4 { get; set; }
        [Column("TAG71F_SE_CHG_AMT4", TypeName = "decimal(16, 3)")]
        public decimal? Tag71fSeChgAmt4 { get; set; }
        [Column("TAG71G_REC_CHG_SW_CCY")]
        [StringLength(3)]
        public string Tag71gRecChgSwCcy { get; set; }
        [Column("TAG71G_REC_CHG_CCY")]
        [StringLength(2)]
        public string Tag71gRecChgCcy { get; set; }
        [Column("TAG71G_REC_CHG_AMT", TypeName = "decimal(16, 3)")]
        public decimal? Tag71gRecChgAmt { get; set; }
        [Column("TAG77B_REGULATORY1")]
        [StringLength(35)]
        public string Tag77bRegulatory1 { get; set; }
        [Column("TAG77B_REGULATORY2")]
        [StringLength(35)]
        public string Tag77bRegulatory2 { get; set; }
        [Column("TAG77B_REGULATORY3")]
        [StringLength(35)]
        public string Tag77bRegulatory3 { get; set; }
        [Column("REMARKS_EUC")]
        [StringLength(20)]
        public string RemarksEuc { get; set; }
        [Column("COVFLAG")]
        [StringLength(1)]
        public string Covflag { get; set; }
        [Column("SEQBINF1_TAG52_ID")]
        [StringLength(12)]
        public string Seqbinf1Tag52Id { get; set; }
        [Column("SEQBINF1_TAG56_ID")]
        [StringLength(12)]
        public string Seqbinf1Tag56Id { get; set; }
        [Column("SEQBINF1_TAG57_ID")]
        [StringLength(12)]
        public string Seqbinf1Tag57Id { get; set; }
        [Column("SEQBINF1_TAG58_ID")]
        [StringLength(12)]
        public string Seqbinf1Tag58Id { get; set; }
        [Column("SEQBINF1_TAG58_ACTO")]
        [StringLength(35)]
        public string Seqbinf1Tag58Acto { get; set; }
        [Column("SEQBINF1_TAG58_CUSTNAME1")]
        [StringLength(35)]
        public string Seqbinf1Tag58Custname1 { get; set; }
        [Column("SEQBINF1_TAG58_CUSTNAME2")]
        [StringLength(35)]
        public string Seqbinf1Tag58Custname2 { get; set; }
        [Column("SEQBINF1_TAG58_CUSTNAME3")]
        [StringLength(35)]
        public string Seqbinf1Tag58Custname3 { get; set; }
        [Column("SEQBINF1_TAG58_CUSTNAME4")]
        [StringLength(35)]
        public string Seqbinf1Tag58Custname4 { get; set; }
        [Column("SEQBINF2_TAG52_CUSTNAME1")]
        [StringLength(35)]
        public string Seqbinf2Tag52Custname1 { get; set; }
        [Column("SEQBINF2_TAG52_CUSTNAME2")]
        [StringLength(35)]
        public string Seqbinf2Tag52Custname2 { get; set; }
        [Column("SEQBINF2_TAG52_CUSTNAME3")]
        [StringLength(35)]
        public string Seqbinf2Tag52Custname3 { get; set; }
        [Column("SEQBINF2_TAG52_CUSTNAME4")]
        [StringLength(35)]
        public string Seqbinf2Tag52Custname4 { get; set; }
        [Column("SEQBINF2_TAG56_CUSTNAME1")]
        [StringLength(35)]
        public string Seqbinf2Tag56Custname1 { get; set; }
        [Column("SEQBINF2_TAG56_CUSTNAME2")]
        [StringLength(35)]
        public string Seqbinf2Tag56Custname2 { get; set; }
        [Column("SEQBINF2_TAG56_CUSTNAME3")]
        [StringLength(35)]
        public string Seqbinf2Tag56Custname3 { get; set; }
        [Column("SEQBINF2_TAG56_CUSTNAME4")]
        [StringLength(35)]
        public string Seqbinf2Tag56Custname4 { get; set; }
        [Column("SEQBINF2_TAG57_CUSTNAME1")]
        [StringLength(35)]
        public string Seqbinf2Tag57Custname1 { get; set; }
        [Column("SEQBINF2_TAG57_CUSTNAME2")]
        [StringLength(35)]
        public string Seqbinf2Tag57Custname2 { get; set; }
        [Column("SEQBINF2_TAG57_CUSTNAME3")]
        [StringLength(35)]
        public string Seqbinf2Tag57Custname3 { get; set; }
        [Column("SEQBINF2_TAG57_CUSTNAME4")]
        [StringLength(35)]
        public string Seqbinf2Tag57Custname4 { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}