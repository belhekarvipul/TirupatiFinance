CREATE DATABASE TirupatiFinance
GO

USE [TirupatiFinance]
GO

CREATE TABLE [dbo].[Customers](
	[CustomerNumber] [BIGINT] IDENTITY(1,1) NOT NULL,
	[CustomerName] [NVARCHAR](1000) NULL,
	[Address] [NVARCHAR](MAX) NULL,
	[Contact1] [NVARCHAR](50) NULL,
	[Contact2] [NVARCHAR](50) NULL,
	[LoanTakenDate] [DATETIME] NULL,
	[LoanCompletionDate] [DATETIME] NULL,
	[TotalDuration] [INT] NULL,
	[TotalLoanAmount] [BIGINT] NULL,
	[InstallmentAmount] [INT] NULL,
	[ReturnType] [NVARCHAR](500) NULL,
	[RemainingAmount] [BIGINT] NULL,
	[GuarantorName1] [NVARCHAR](500) NULL,
	[GuarantorAddress1] [NVARCHAR](MAX) NULL,
	[GuarantorContact1] [NVARCHAR](50) NULL,
	[GuarantorName2] [NVARCHAR](500) NULL,
	[GuarantorAddress2] [NVARCHAR](MAX) NULL,
	[GuarantorContact2] [NVARCHAR](50) NULL,
	[LoanStatus] [BIT] NULL,
	[CreatedBy] [BIGINT] NULL,
	[UpdatedBy] [BIGINT] NULL,
	[CreatedDate] [DATETIME] NULL,
	[UpdatedDate] [DATETIME] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Users](
	[Id] [BIGINT] IDENTITY(1,1) NOT NULL,
	[UserId] [NVARCHAR](500) NULL,
	[UserName] [NVARCHAR](1000) NULL,
	[Address] [NVARCHAR](MAX) NULL,
	[Contact] [NVARCHAR](50) NULL,
	[Language] [NVARCHAR](50) NULL,
	[Role] [NVARCHAR](50) NULL,
	[Password] [NVARCHAR](1000) NULL,
	[Status] [BIT] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Users] ON 
GO
	INSERT INTO [dbo].[Users] ([Id], [UserId], [UserName], [Address], [Contact], [Language], [Role], [Password], [Status])
	VALUES(1,'Admin','Admin','','','English','MasterAdmin','EDCC5C8639A82360F1BB692EFB855B208457FC496ECCA20F36AA68136F509332',1)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO


