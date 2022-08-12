namespace TirupatiFinance.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Language { get; set; }
        public int Role { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }

/*
    INSERT INTO [dbo].[Users]
        ([UserId]
        ,[UserName]
        ,[Address]
        ,[Contact]
        ,[Language]
        ,[Role]
        ,[Password]
        ,[Status])
    VALUES
        (<UserId, nvarchar(500),>
        ,<UserName, nvarchar(1000),>
        ,<Address, nvarchar(max),>
        ,<Contact, nvarchar(50),>
        ,<Language, nvarchar(50),>
        ,<Role, int,>
        ,<Password, nvarchar(1000),>
        ,<Status, bit,>)
*/
    }
}
