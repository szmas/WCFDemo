--建议数据库名称：wcfDemo

CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](200) NULL,
	[Password] [varchar](200) NULL,
	[Discribe] [varchar](800) NULL,
	[SubmitTime] [datetime] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


INSERT INTO [dbo].[User]
           ([UserName]
           ,[Password]
           ,[Discribe]
           ,[SubmitTime])
     VALUES
           ('李林峰'
           ,'123456'
           ,'WCF技术交流群，群号：89718412，欢迎加入。作者博客地址：http://www.cnblogs.com/iamlilinfeng/'
           ,GETDATE())
GO


