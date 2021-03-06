USE [master]
GO
/****** Object:  Database [gamilonbase]    Script Date: 07/04/2015 12:52:59 ******/
CREATE DATABASE [gamilonbase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gamilonbase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\gamilonbase.mdf' , SIZE = 9280KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'gamilonbase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\gamilonbase_log.ldf' , SIZE = 16832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [gamilonbase] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gamilonbase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gamilonbase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gamilonbase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gamilonbase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gamilonbase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gamilonbase] SET ARITHABORT OFF 
GO
ALTER DATABASE [gamilonbase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gamilonbase] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [gamilonbase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gamilonbase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gamilonbase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gamilonbase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gamilonbase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gamilonbase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gamilonbase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gamilonbase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gamilonbase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [gamilonbase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gamilonbase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gamilonbase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gamilonbase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gamilonbase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gamilonbase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gamilonbase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gamilonbase] SET RECOVERY FULL 
GO
ALTER DATABASE [gamilonbase] SET  MULTI_USER 
GO
ALTER DATABASE [gamilonbase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gamilonbase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gamilonbase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gamilonbase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'gamilonbase', N'ON'
GO
USE [gamilonbase]
GO
/****** Object:  Table [dbo].[client]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[client](
	[id_client] [int] IDENTITY(1,1) NOT NULL,
	[nom_client] [varchar](20) NOT NULL,
	[prenom_client] [varchar](20) NOT NULL,
	[adr_client_l1] [varchar](50) NOT NULL,
	[adr_client_l2] [varchar](50) NULL,
	[tel_client] [varchar](10) NULL,
	[mail_client] [varchar](50) NULL,
	[id_ville] [int] NULL,
 CONSTRAINT [PK__client__6EC2B6C0DCB6E776] PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cp_ville]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cp_ville](
	[id_ville] [int] IDENTITY(1,1) NOT NULL,
	[code_postal] [nvarchar](max) NULL,
	[nom_ville] [varchar](50) NULL,
 CONSTRAINT [PK_cp_ville] PRIMARY KEY CLUSTERED 
(
	[id_ville] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[equipement]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[equipement](
	[id_equipement] [int] IDENTITY(1,1) NOT NULL,
	[nom_equipement] [varchar](50) NOT NULL,
	[prix_equipement] [varchar](5) NOT NULL,
	[reference_equipement] [varchar](10) NOT NULL,
	[marque_equipement] [varchar](20) NOT NULL,
	[type_equipement] [varchar](20) NOT NULL,
 CONSTRAINT [PK__equipeme__32ACD92288E35427] PRIMARY KEY CLUSTERED 
(
	[id_equipement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[facture]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facture](
	[id_facture] [int] IDENTITY(1,1) NOT NULL,
	[date_facture] [date] NOT NULL,
	[id_modePaiement] [int] NULL,
 CONSTRAINT [PK__facture__6C08ED577C0E3604] PRIMARY KEY CLUSTERED 
(
	[id_facture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fournit]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fournit](
	[id_four] [int] IDENTITY(1,1) NOT NULL,
	[id_equipement] [int] NOT NULL,
	[num_reservation] [int] NOT NULL,
 CONSTRAINT [PK__fournit__620EABC18E53CF7B] PRIMARY KEY CLUSTERED 
(
	[id_four] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[genere]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genere](
	[id_genere] [int] IDENTITY(1,1) NOT NULL,
	[id_facture] [int] NOT NULL,
	[num_reservation] [int] NOT NULL,
 CONSTRAINT [PK__genere__99A8E4EF0B421F85] PRIMARY KEY CLUSTERED 
(
	[id_genere] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[magasin]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[magasin](
	[id_magasin] [int] IDENTITY(1,1) NOT NULL,
	[adr_magasin] [varchar](50) NULL,
	[tel_magasin] [varchar](10) NULL,
	[mail_magasin] [varchar](50) NULL,
	[id_ville] [int] NULL,
 CONSTRAINT [PK__magasin__46EA0C6D7C7334F4] PRIMARY KEY CLUSTERED 
(
	[id_magasin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modedepaiement]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modedepaiement](
	[id_modePaiement] [int] IDENTITY(1,1) NOT NULL,
	[libelle_modePaiement] [varchar](50) NOT NULL,
 CONSTRAINT [PK__modedepa__1A56506683945CBE] PRIMARY KEY CLUSTERED 
(
	[id_modePaiement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[personnel]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personnel](
	[id_personnel] [int] IDENTITY(1,1) NOT NULL,
	[nom_personnel] [varchar](50) NOT NULL,
	[prenom_personnel] [varchar](50) NOT NULL,
	[tel_personnel] [int] NOT NULL,
	[mail_personnel] [varchar](50) NOT NULL,
	[adr_personnel_l1] [varchar](50) NOT NULL,
	[adr_personnel_l2] [varchar](50) NOT NULL,
	[login_personnel] [varchar](50) NOT NULL,
	[mdp_personnel] [varchar](50) NOT NULL,
	[date_entree] [date] NOT NULL,
	[id_ville] [int] NOT NULL,
	[id_magasin] [int] NOT NULL,
	[id_poste] [int] NOT NULL,
	[id_statut] [int] NOT NULL,
 CONSTRAINT [PK_personnel] PRIMARY KEY CLUSTERED 
(
	[id_personnel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[posseder]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posseder](
	[id_poss] [int] IDENTITY(1,1) NOT NULL,
	[id_equipement] [int] NOT NULL,
	[id_salle] [int] NOT NULL,
 CONSTRAINT [PK__posseder__3840C79EFE7ED5E0] PRIMARY KEY CLUSTERED 
(
	[id_poss] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[poste]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[poste](
	[id_poste] [int] IDENTITY(1,1) NOT NULL,
	[nom_poste] [varchar](50) NOT NULL,
 CONSTRAINT [PK_poste] PRIMARY KEY CLUSTERED 
(
	[id_poste] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reservation]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservation](
	[num_reservation] [int] IDENTITY(1,1) NOT NULL,
	[jour_res] [date] NOT NULL,
	[heure_debut_res] [time](7) NOT NULL,
	[heure_fin_res] [time](7) NOT NULL,
	[disponibilite] [bit] NOT NULL,
	[id_client] [int] NOT NULL,
	[id_salle] [int] NOT NULL,
	[id_magasin] [int] NOT NULL,
 CONSTRAINT [PK__reservat__731CEC852B8FB716] PRIMARY KEY CLUSTERED 
(
	[num_reservation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[salleconcert]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salleconcert](
	[nb_place] [int] NULL,
	[id_salle] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sallerepetition]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sallerepetition](
	[taille_salle] [float] NOT NULL,
	[prix_salle_heure] [int] NOT NULL,
	[id_salle] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[salles]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[salles](
	[id_salle] [int] NOT NULL,
	[libelle_salle] [varchar](50) NOT NULL,
	[id_magasin] [int] NULL,
 CONSTRAINT [PK__salles__6C4673898B66F9EF] PRIMARY KEY CLUSTERED 
(
	[id_salle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[statut]    Script Date: 07/04/2015 12:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[statut](
	[id_statut] [int] IDENTITY(1,1) NOT NULL,
	[nom_statut] [varchar](50) NOT NULL,
 CONSTRAINT [PK_statut] PRIMARY KEY CLUSTERED 
(
	[id_statut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[client]  WITH CHECK ADD  CONSTRAINT [FK_CP_CLI] FOREIGN KEY([id_ville])
REFERENCES [dbo].[cp_ville] ([id_ville])
GO
ALTER TABLE [dbo].[client] CHECK CONSTRAINT [FK_CP_CLI]
GO
ALTER TABLE [dbo].[facture]  WITH CHECK ADD  CONSTRAINT [FK_FAC_MOD] FOREIGN KEY([id_modePaiement])
REFERENCES [dbo].[modedepaiement] ([id_modePaiement])
GO
ALTER TABLE [dbo].[facture] CHECK CONSTRAINT [FK_FAC_MOD]
GO
ALTER TABLE [dbo].[fournit]  WITH CHECK ADD  CONSTRAINT [FK_FOU_EQU] FOREIGN KEY([id_equipement])
REFERENCES [dbo].[equipement] ([id_equipement])
GO
ALTER TABLE [dbo].[fournit] CHECK CONSTRAINT [FK_FOU_EQU]
GO
ALTER TABLE [dbo].[fournit]  WITH CHECK ADD  CONSTRAINT [FK_FOU_RES] FOREIGN KEY([num_reservation])
REFERENCES [dbo].[reservation] ([num_reservation])
GO
ALTER TABLE [dbo].[fournit] CHECK CONSTRAINT [FK_FOU_RES]
GO
ALTER TABLE [dbo].[genere]  WITH CHECK ADD  CONSTRAINT [FK_GEN_FAC] FOREIGN KEY([id_facture])
REFERENCES [dbo].[facture] ([id_facture])
GO
ALTER TABLE [dbo].[genere] CHECK CONSTRAINT [FK_GEN_FAC]
GO
ALTER TABLE [dbo].[genere]  WITH CHECK ADD  CONSTRAINT [FK_GEN_RES] FOREIGN KEY([num_reservation])
REFERENCES [dbo].[reservation] ([num_reservation])
GO
ALTER TABLE [dbo].[genere] CHECK CONSTRAINT [FK_GEN_RES]
GO
ALTER TABLE [dbo].[magasin]  WITH CHECK ADD  CONSTRAINT [FK_CP_MAG] FOREIGN KEY([id_ville])
REFERENCES [dbo].[cp_ville] ([id_ville])
GO
ALTER TABLE [dbo].[magasin] CHECK CONSTRAINT [FK_CP_MAG]
GO
ALTER TABLE [dbo].[personnel]  WITH CHECK ADD  CONSTRAINT [FK_PER_CP] FOREIGN KEY([id_ville])
REFERENCES [dbo].[cp_ville] ([id_ville])
GO
ALTER TABLE [dbo].[personnel] CHECK CONSTRAINT [FK_PER_CP]
GO
ALTER TABLE [dbo].[personnel]  WITH CHECK ADD  CONSTRAINT [FK_PER_MAG] FOREIGN KEY([id_magasin])
REFERENCES [dbo].[magasin] ([id_magasin])
GO
ALTER TABLE [dbo].[personnel] CHECK CONSTRAINT [FK_PER_MAG]
GO
ALTER TABLE [dbo].[personnel]  WITH CHECK ADD  CONSTRAINT [FK_PER_POS] FOREIGN KEY([id_poste])
REFERENCES [dbo].[poste] ([id_poste])
GO
ALTER TABLE [dbo].[personnel] CHECK CONSTRAINT [FK_PER_POS]
GO
ALTER TABLE [dbo].[personnel]  WITH CHECK ADD  CONSTRAINT [FK_PER_STA] FOREIGN KEY([id_statut])
REFERENCES [dbo].[statut] ([id_statut])
GO
ALTER TABLE [dbo].[personnel] CHECK CONSTRAINT [FK_PER_STA]
GO
ALTER TABLE [dbo].[posseder]  WITH CHECK ADD  CONSTRAINT [FK_POS_EQU] FOREIGN KEY([id_equipement])
REFERENCES [dbo].[equipement] ([id_equipement])
GO
ALTER TABLE [dbo].[posseder] CHECK CONSTRAINT [FK_POS_EQU]
GO
ALTER TABLE [dbo].[posseder]  WITH CHECK ADD  CONSTRAINT [FK_POS_SAL] FOREIGN KEY([id_salle])
REFERENCES [dbo].[salles] ([id_salle])
GO
ALTER TABLE [dbo].[posseder] CHECK CONSTRAINT [FK_POS_SAL]
GO
ALTER TABLE [dbo].[reservation]  WITH CHECK ADD  CONSTRAINT [FK_RES_CLI] FOREIGN KEY([id_client])
REFERENCES [dbo].[client] ([id_client])
GO
ALTER TABLE [dbo].[reservation] CHECK CONSTRAINT [FK_RES_CLI]
GO
ALTER TABLE [dbo].[reservation]  WITH CHECK ADD  CONSTRAINT [FK_RES_SAL] FOREIGN KEY([id_salle])
REFERENCES [dbo].[salles] ([id_salle])
GO
ALTER TABLE [dbo].[reservation] CHECK CONSTRAINT [FK_RES_SAL]
GO
ALTER TABLE [dbo].[salleconcert]  WITH CHECK ADD  CONSTRAINT [FK_CON_SAL] FOREIGN KEY([id_salle])
REFERENCES [dbo].[salles] ([id_salle])
GO
ALTER TABLE [dbo].[salleconcert] CHECK CONSTRAINT [FK_CON_SAL]
GO
ALTER TABLE [dbo].[sallerepetition]  WITH CHECK ADD  CONSTRAINT [FK_REP_SAL] FOREIGN KEY([id_salle])
REFERENCES [dbo].[salles] ([id_salle])
GO
ALTER TABLE [dbo].[sallerepetition] CHECK CONSTRAINT [FK_REP_SAL]
GO
ALTER TABLE [dbo].[salles]  WITH CHECK ADD  CONSTRAINT [FK_MAG_SAL] FOREIGN KEY([id_magasin])
REFERENCES [dbo].[magasin] ([id_magasin])
GO
ALTER TABLE [dbo].[salles] CHECK CONSTRAINT [FK_MAG_SAL]
GO
USE [master]
GO
ALTER DATABASE [gamilonbase] SET  READ_WRITE 
GO
