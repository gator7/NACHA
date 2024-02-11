
namespace NACHAParser
{
    public enum RecordType
    {
        fh = 1,
        bh = 5,
        ed = 6,
        ad = 7,
        bc = 8,
        fc = 9
    }
    public enum OriginatorStatusCode
    {
        ADV = 0,
        DepositoryFinancialInstitution = 1,
        GovtOrAgency = 2,
    }
    public enum StandardEntryClassCode : int
    {
        CCD,
        PPD,
        WEB,
        TEL,
        COR,
    }
    public enum ServiceClassCode
    {
        MixDebitAndCredit = 200,
        DebitOnly = 220,
        CreditOnly = 225
    }
    public enum AddendTypeCode
    {
        POSAddenda = 02,
        StandardAddenda = 05,
        IAT1Addenda = 10,
        IAT2Addenda = 11,
        IAT3Addenda = 12,
        IAT4Addenda = 13,
        IAT5Addenda = 14,
        IAT6Addenda = 15,
        IAT7Addenda = 16,
        IAT8Addenda = 17,
        IAT9Addenda = 18,
        ReturnAddenda = 99,
        NOCAddenda = 98
    }
    public enum ReturnCode : int
    {
        R01, R02, R03, R04, R05, R06, R07, R08, R09, R10, R11, R12, R13, R14, R15, R16, R17, R18, R19, R20, R21, R22, R23, R24, R25, R26, R27, R28, R29, R30, R31, R32, R33, R34, R35, R36, R37, R38, R39, R40, R41, R42, R43, R44, R45, R46, R47, R50, R51, R52, R53, R61, R62, R67, R68, R69, R70, R71, R72, R73, R74, R75, R76, R77, R80, R81, R82, R83, R84, R85

    }
    public enum AddendaRecordIndicator
    {
        NoAddenda = 0,
        Addenda = 1
    }
    public enum TransactionCode
    {
        CheckingReturnNOCCredit = 21,
        CheckingCredit = 22,
        CHekcingPrenoteCredit = 23,
        CheckingZeroDollarRemitCredit = 24,
        CheckingReturnNOCDebit = 26,
        CheckingDebit = 27,
        CheckingPrenoteDebit = 28,
        CheckingZeroDollarRemitDebit = 29,
        SavingReturnNOCCredit = 31,
        SavingsCredit = 32,
        SavingsPrenoteCredit = 33,
        SavingsZeroDollarRemitCredit = 34,
        SavingsReturnNOCDebit = 36,
        SavingsDebit = 37,
        SavingsPrenoteDebit = 38,
        SavingsZeroDollarRemitDebit = 39,
        GLReturnNoCCredit = 41,
        GLCredit = 42,
        GLPrenoteCredit = 43,
        GLZeroDollarRemitCredit = 44,
        GLReturnNOCDebit = 46,
        GLDebit = 47,
        GLPrenoteDebit = 48,
        GLZeroDollarRemitDebit = 49,
        LoanReturnNOCredit = 51,
        LoanCredit = 52,
        LoanPrenoteCredit = 53,
        LoanZeroDollarRemitCredit = 54,
        LoanDebit = 55,
        LoanReturnNOCDebit = 56,
        AcctCreditForACHDebitsOriginated = 81,
        AcctDebitForACHCreditsOriginated = 82,
        AcctCreditForACHCreditsReceived = 83,
        AcctDebitForACHDebitsReceived = 84,
        CreditForACHCreditsInRejBatch = 85,
        DebitForACHDebitsInRejBatch = 86,
        SummaryCreditforRespondentACH = 87,
        SummaryDebitforRespondentACH = 88,
    }
}