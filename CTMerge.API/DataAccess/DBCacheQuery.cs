namespace CTMerge.API.DataAccess
{
    public class DBCacheQuery
    {
        public static string GetPatientByHN()
        {
            const string db = @"

                select top 10 PAPMI_No HN, PAPMI_Name3 TitleName, PAPMI_Name FirstName, PAPMI_Name2 LastName, 
		        PAPMI_DOB DOB, PAPMI_Sex_DR->CTSEX_Code SexCode, PAPMI_Sex_DR->CTSEX_Desc SexDesc, 
		        PAPMI_ID IDCARD
                from pa_patmas
                where PAPMI_No like ?

            ";

            return db;
        }

        public static string GetPatientByName(string firstName, string lastName)
        {
            string db = @"

                select top 10 PAPMI_No HN, PAPMI_Name3 TitleName, PAPMI_Name FirstName, PAPMI_Name2 LastName, 
		        PAPMI_DOB DOB, PAPMI_Sex_DR->CTSEX_Code SexCode, PAPMI_Sex_DR->CTSEX_Desc SexDesc, 
		        PAPMI_ID IDCARD
                from pa_patmas

            ";

            if(!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                db = $" {db} where PAPMI_Name like ? and PAPMI_Name2 like ? ";
            }
            else if(!string.IsNullOrEmpty(firstName))
            {
                db = $" {db} where PAPMI_Name like ?  ";
            }
            else if (!string.IsNullOrEmpty(lastName))
            {
                db = $" {db} where PAPMI_Name2 like ? ";
            }

            return db;
        }

        public static string Logon()
        {
            return @"
                SELECT SSUSR_Initials, SSUSR_Name, SSUSR_Password 
                FROM SS_USER WHERE SSUSR_Initials = ?
            ";
        }

        public static string GetUserResult()
        {
            return @"
                SELECT SSUSR_Initials, SSUSR_Name,SSUSR_Password, SSUSR_GROUP->SSGRP_Desc,SSUSR_DEFAULTDEPT_DR->CTLOC_Desc 
                FROM SS_USER WHERE SSUSR_Initials = ?
            ";
        }
    }
}