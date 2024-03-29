IF NOT EXISTS (
    SELECT [name] 
    FROM sys.databases 
    WHERE [name] = N'AccSol'
)
BEGIN
    CREATE DATABASE [AccSol]
END
GO

USE [AccSol]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'217b866d-86bc-44e6-bc37-fa73546a8dc2', N'solomiosisante@gmail.com', N'SOLOMIOSISANTE@GMAIL.COM', N'solomiosisante@gmail.com', N'SOLOMIOSISANTE@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAELC440+IgiPmgMLnxtWeCLh4c3uogVJh6a936RrbP2JCDKoJjBBd5/WzUund2MfP2Q==', N'LO7OZUBK2XSPHZNVOO4KJDI3GJ426WOJ', N'7fce0d99-6d77-469b-8f92-315bb7dcbb36', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (1, N'ABPCOR', N'ABOITIZ POWER CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (2, N'AGTIN', N'AGRICULTURAL TRAINING INSTITUTE')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (3, N'AMPIN', N'AMMIC PHILIPPINES, INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (4, N'ANMLC', N'ANTI-MONEY LAUNDERING COUNCIL')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (5, N'APRNI', N'AP RENEWABLES INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (6, N'AFPSLAI', N'ARMED FORCES AND POLICIES SAVINGS AND LOAN ASSOCIATION INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (7, N'ASCEND', N'ASCENDER INNOVATION, OPC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (8, N'ASEANA', N'ASEANA HOLDINGS INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (9, N'ASSURED', N'ASSURED ASSET MANAGEMENT LIMITED')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (10, N'BALENCOR', N'BALAMBAN ENERZONE CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (11, N'BANCNET', N'BANCNET, INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (12, N'BDO', N'BDO UNIBANK, INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (13, N'BIR', N'BUREAU OF INTERNAL REVENUE')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (14, N'CCLO', N'CASTILLO CUI LAW OFFICE')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (15, N'CPFI', N'CENTURY PACIFIC FOOD INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (16, N'CBC', N'CHINA BANKING CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (17, N'CPC', N'CHIYODA PHILIPPINES CORP')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (18, N'CHH', N'CHONG HUA HOSPITAL')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (19, N'CONVERGE', N'CONVERGE INFORMATION TECHNOLOGY SOLUTIONS, INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (20, N'CLPC', N'COTABATO LIGHT AND POWER COMPANY')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (21, N'DLPCI', N'DAVAO LIGHT AND POWER CO, INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (22, N'DICT', N'DEPARTMENT OF INFORMATION AND COMMUNICATIONS TECHNOLOGY')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (23, N'DND', N'DEPARTMENT OF NATIONAL DEFENSE')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (24, N'DTC', N'DITO TELECOMMUNITY CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (25, N'DFPI', N'DUTY FREE PHILIPPINES INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (26, N'EFSI', N'ENTRE FULFILLMENT SOLUTIONS INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (27, N'FOPMI', N'FIRST OCEANIC PROPERTY MANAGEMENT INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (28, N'GYPGP', N'GATMAYTAN YAP PATACSIL GUTIRREZ AND PROTACIO')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (29, N'VCFVOC', N'VERNANCE COMMISSION FOR VERNMENT OWNED OR CONTROLLED CORPS')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (30, N'GLC', N'GUR LAVI CORP.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (31, N'GXI', N'G-XCHANGE, INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (32, N'HVPI', N'H VILLARICA PAWNSHOP INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (33, N'HBI', N'HEDCOR BUKIDNON, INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (34, N'SSI', N'HEDCOR SABANGAN, INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (35, N'HSI ', N'HEDCOR SIBULAN, INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (36, N'HI', N'HEDCOR, INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (37, N'HVPI', N'HL VILLARICA PAWNSHOP INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (38, N'HRVPI', N'HRV VILLARICA PAWNSHOP INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (39, N'IGL', N'INFINIT-O GLOBAL LIMITED')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (40, N'IRI', N'INSPIRO RELIA INCORPORATED')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (41, N'IHCI', N'INSULAR HEALTH CARE INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (42, N'JGSHI', N'JG SUMMIT HOLDINGS INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (43, N'KMC', N'KAREILA MANAGEMENT CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (44, N'KIPL', N'KUMUMEDIA INTERNATIONAL PTE. LTD')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (45, N'LEC', N'LIMA ENERZONE CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (46, N'LHC', N'LUZON HYDRO CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (47, N'MAEC', N'MACTAN ENERZONE CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (48, N'MALEC', N'MALVAR ENERZONE CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (49, N'MOREI', N'MANILA-OSLO RENEWABLE ENTERPRISE INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (50, N'MPTDI', N'METRO PACIFIC TOLLWAYS DIGITAL INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (51, N'MSL', N'MOONRICH SOLUTIONS LTD')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (52, N'NCMH', N'NATIONAL CENTER FOR MENTAL HEALTH')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (53, N'NICA', N'NATIONAL INTELLIGENCE COORDINATING AGENCY (NICA)')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (54, N'NPC', N'NATIONAL PRIVACY COMMISSION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (55, N'OCPC', N'ONCO CARE PHARMA CORP')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (56, N'OACI', N'ONE ALPHA COMM INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (57, N'OCVIMAD', N'ORIENT CAPITAL VENTURES INC. (MSW Madison Square)')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (58, N'OCVIOLO', N'ORIENT CAPITAL VENTURES INC. (MSW Olongapo)')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (59, N'OCVITOM', N'ORIENT CAPITAL VENTURES INC. (MSW Tomas Morato)')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (60, N'OCVIRP', N'ORIENT CAPITAL VENTURES INC. (ROYAL PLACE)')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (61, N'PGSMI', N'PEARL GRACE SHIP MANAGEMENT INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (62, N'PAL', N'PHILIPPINE AIRLINES')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (63, N'PASRC', N'PHILIPPINE ASSOCIATED SMELTING AND REFINING CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (64, N'PBACI', N'PHILIPPINE BRITISH ASSURANCE COMPANY, INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (65, N'PDAX', N'PHILIPPINE DIGITAL ASSET EXCHANGE (PDAX) INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (66, N'PNP', N'PHILIPPINE NATIONAL POLICE')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (67, N'PISC', N'PIONEER INSURANCE & SURETY CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (68, N'PICI', N'PRIME INFRASTRUCTURE CAPITAL INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (69, N'PMBC', N'PRIME METRO BMD CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (70, N'PA', N'PUNONGBAYAN & ARAULLO')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (71, N'PVSPI', N'PV SINAG POWER INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (72, N'RBC', N'ROBINSONS BANK CORP.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (73, N'SCSPI', N'SAN CARLOS SUN POWER INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (74, N'SMC', N'SAN MIGUEL CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (75, N'SEI', N'SCIENCE EDUC INST')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (76, N'SBC', N'SECURITY BANK CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (77, N'SMPC', N'SEMIRARA MINING AND POWER CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (78, N'SET', N'SENATE ELECTORAL TRIBUNAL')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (79, N'SCPI', N'SHOPBACK COMPANY PHILIPPINES INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (80, N'SCC', N'SKY CABLE CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (81, N'SHCC', N'SM HOTELS AND CONVENTIONS CORP')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (82, N'SPHINE', N'SM PRIME HOLDINGS INC-NORTH EDSA')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (83, N'SPHIPS', N'SM PRIME HOLDINGS INC-PICO SANDS')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (84, N'SPHITV', N'SM PRIME HOLDINGS INC-TAAL VISTA')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (85, N'SMITS', N'SMITS INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (86, N'SAPBI', N'SN ABOITIZ POWER - BENGUET INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (87, N'SAPMI', N'SN ABOITIZ POWER - MAGAT INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (88, N'SSS', N'SOCIAL SECURITY SYSTEM')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (90, N'SICI', N'STERLING INSURANCE COMPANY INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (91, N'SC', N'STRADCOM CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (92, N'SEC', N'SUBIC ENERZONE CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (93, N'TILACL', N'THE INSULAR LIFE ASSURANCE COMPANY LTD.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (94, N'TLI', N'THERMA LUZON, INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (95, N'TMI', N'THERMA MOBILE, INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (96, N'TRLEI', N'TIGER RESORT, LEISURE & ENTERTAINMENT, INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (97, N'TPC', N'TPSC PHILIPPINES CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (98, N'TPI', N'TRAXION PAY INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (99, N'TTI', N'TRAXION TECH INC')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (100, N'TSPI', N'TSM SHIPPING (PHILS.), INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (101, N'UBX', N'UBX PHILIPPINES CORPORATION')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (102, N'UDBI', N'UNION DIGITAL BANK INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (103, N'UOTP', N'UNIONBANK OF THE PHILIPPINES')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (104, N'UASSI', N'UNIVERSAL ACCESS & SYSTEMS SOLUTIONS INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (105, N'UOTPD', N'UNIVERSITY OF THE PHILIPPINES DILIMAN')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (106, N'VBI', N'VENN BIOSCIENCES INCORPORATED')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (107, N'VPI', N'VILLARICA PAWNSHOP INC.')
INSERT [dbo].[Client] ([ID], [Code], [Name]) VALUES (108, N'VECI', N'VISAYAN ELECTRIC CO, INC.')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Coa] ON 

INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (1, N'ASSETS', N' CASH  ', N'Cash in bank - AUB USD')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (2, N'ASSETS', N' CASH  ', N'Cash in bank - AUB Savings')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (3, N'ASSETS', N' CASH  ', N'Cash in bank - BDO')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (4, N'ASSETS', N' CASH  ', N'Cash in bank - BPI')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (5, N'ASSETS', N' CASH  ', N'Cash in bank - Eastwest bank')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (6, N'ASSETS', N' CASH  ', N'Cash in bank - PBCom')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (7, N'ASSETS', N' CASH  ', N'Cash in bank - PNB Savings')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (8, N'ASSETS', N' CASH  ', N'Petty Cash Fund- Office')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (9, N'ASSETS', N' CASH  ', N'Cash in bank - RCBC')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (10, N'ASSETS', N' CASH  ', N'Cash on hand')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (11, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Accounts receivable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (12, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Accounts Receivable-Employee')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (13, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Advances from Employee')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (14, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Other receivable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (15, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Advances to suppliers')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (16, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Cash Advance')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (17, N'ASSETS', N' INVENTORIES ', N'Inventory asset')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (18, N'ASSETS', N' INVENTORIES ', N'Training Kit')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (19, N'ASSETS', N' INVENTORIES ', N'Office supplies inventory')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (20, N'ASSETS', N'OTHER CURRENT ASSETS', N'Input VAT')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (21, N'ASSETS', N'OTHER CURRENT ASSETS', N'Deferred Input VAT')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (22, N'ASSETS', N'OTHER CURRENT ASSETS', N'Creditable income tax')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (23, N'ASSETS', N'OTHER CURRENT ASSETS', N'Creditable input VAT')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (24, N'ASSETS', N'OTHER CURRENT ASSETS', N'Prepaid Expenses')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (25, N'ASSETS', N'OTHER CURRENT ASSETS', N'Security Deposit')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (26, N'ASSETS', N'OTHER CURRENT ASSETS', N'Prepaid Rental')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (27, N'ASSETS', N'OTHER CURRENT ASSETS', N'Prepaid Taxes')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (28, N'ASSETS', N'OTHER CURRENT ASSETS', N'Prepaid Insurance')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (29, N'ASSETS', N'OTHER CURRENT ASSETS', N'Rental Deposit')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (30, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Computer Equipment')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (31, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Accumulated Depreciation - comp. equip.')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (32, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Furniture and Fixtures')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (33, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Accum. Dep. - furnitures and fixtures')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (34, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Leasehold Improvement')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (35, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Accum. Dep. - leasehold improvement')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (36, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Office equipment')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (37, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Accum. Dep. - office equipment')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (38, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Transportation equipment')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (39, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Accum. Dep. - transportation equip.')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (40, N'ASSETS', N'OTHER NON - CURRENT ASSETS', N'Deferred tax asset')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (41, N'ASSETS', N'OTHER NON - CURRENT ASSETS', N'Bonds-Refundable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (42, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Accounts payable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (43, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Salaries Payable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (44, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Accounts payable - USD')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (45, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Advances - Others')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (46, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Security deposit - Converge')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (47, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Advances from Customers')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (48, N' LIABILITIES ', N'OTHER PAYABLES', N'Income tax payable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (49, N' LIABILITIES ', N'OTHER PAYABLES', N'HDMF Payable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (50, N' LIABILITIES ', N'OTHER PAYABLES', N'HDMF Loan Payable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (51, N' LIABILITIES ', N'OTHER PAYABLES', N'SSS Payable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (52, N' LIABILITIES ', N'OTHER PAYABLES', N'SSS Loan Payable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (53, N' LIABILITIES ', N'OTHER PAYABLES', N'Philhealth Payable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (54, N' LIABILITIES ', N'OTHER PAYABLES', N'Expanded withholding tax payable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (55, N' LIABILITIES ', N'OTHER PAYABLES', N'Withholding tax payable - compensation')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (56, N' LIABILITIES ', N'OTHER PAYABLES', N'Deferred output VAT')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (57, N' LIABILITIES ', N'OTHER PAYABLES', N'Output VAT')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (58, N' LIABILITIES ', N'OTHER PAYABLES', N'Output VAT payable')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (59, N' LIABILITIES ', N'ADVANCES FROM STOCKHOLDERS', N'Advances from Stockholders')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (60, N'STOCKHOLDERS EQUITY', N'Equity', N'Capital stock')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (61, N'STOCKHOLDERS EQUITY', N'Equity', N'Retained earnings')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (62, N'STOCKHOLDERS EQUITY', N'Equity', N'Net Income')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (63, N'STOCKHOLDERS EQUITY', N'Equity', N'Prior period adjustment')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (64, N'REVENUES', N'', N'Sales - Hardware')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (65, N'REVENUES', N' ', N'Sales - Software')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (66, N'REVENUES', N' ', N'Internet Service Provider')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (67, N'REVENUES', N' ', N'Vulnerability Assessment and Penetration Testing')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (68, N'REVENUES', N' ', N'Technical support')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (69, N'REVENUES', N' ', N'Consultancy')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (70, N'REVENUES', N' ', N'Web Hosting and Management')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (71, N'REVENUES', N' ', N'Installation')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (72, N'REVENUES', N' ', N'Training services')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (73, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Training kit')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (74, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Hardware')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (75, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Software')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (76, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - ISP')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (77, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Web Support')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (78, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Technical Support')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (79, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Training ')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (80, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Consultancy')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (81, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Installation services')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (82, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - VAPT')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (83, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'Advertising expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (84, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'Association dues')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (85, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'Freight Costs')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (86, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - Salaries and wages')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (87, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - SSS Premium')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (88, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - HDMF expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (89, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - Philhealth expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (90, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - De-minimis benefits')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (91, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - Employee benefits')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (92, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - 13th month pay')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (93, N'OPERATING EXPENSES', N'Salaries and wages', N'Salaries and wages')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (94, N'OPERATING EXPENSES', N'Salaries and wages', N'SSS premium expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (95, N'OPERATING EXPENSES', N'Salaries and wages', N'HDMF expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (96, N'OPERATING EXPENSES', N'Salaries and wages', N'Philhealth expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (97, N'OPERATING EXPENSES', N'Salaries and wages', N'De-minimis benefits')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (98, N'OPERATING EXPENSES', N'Salaries and wages', N'Employee benefits')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (99, N'OPERATING EXPENSES', N'Salaries and wages', N'Employee benefits - HMO')
GO
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (100, N'OPERATING EXPENSES', N'Salaries and wages', N'13th month pay')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (101, N'OPERATING EXPENSES', N'Depreciation expense', N'Dep. Exp - leasehold improvement')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (102, N'OPERATING EXPENSES', N'Depreciation expense', N'Dep. Exp - furnitures and fixtures')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (103, N'OPERATING EXPENSES', N'Depreciation expense', N'Dep. Exp. - Office equipment')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (104, N'OPERATING EXPENSES', N'Depreciation expense', N'Dep. Exp. - Computer equipment')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (105, N'OPERATING EXPENSES', N'Depreciation expense', N'Dep. Exp. - Transportation equipment')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (106, N'OPERATING EXPENSES', N'', N'Insurance expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (107, N'OPERATING EXPENSES', N'', N'Miscellaneous expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (108, N'OPERATING EXPENSES', N'', N'Office supplies expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (109, N'OPERATING EXPENSES', N'', N'Professional fee')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (110, N'OPERATING EXPENSES', N'', N'Consultancy fee')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (111, N'OPERATING EXPENSES', N'', N'Directors fee')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (112, N'OPERATING EXPENSES', N'', N'Janitorial expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (113, N'OPERATING EXPENSES', N'', N'Rent expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (114, N'OPERATING EXPENSES', N'', N'Repairs and maintenance ')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (115, N'OPERATING EXPENSES', N'', N'Representation expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (116, N'OPERATING EXPENSES', N'', N'Commission expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (117, N'OPERATING EXPENSES', N'', N'Travel and accomodation expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (118, N'OPERATING EXPENSES', N'', N'Taxes and licenses')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (119, N'OPERATING EXPENSES', N'', N'Trainings and seminar')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (120, N'OPERATING EXPENSES', N'', N'Parking and toll fees')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (121, N'OPERATING EXPENSES', N'', N'Gas and Oil')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (122, N'OPERATING EXPENSES', N'', N'Food and meals')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (123, N'OPERATING EXPENSES', N'', N'Transportation expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (124, N'OPERATING EXPENSES', N'', N'Communication expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (125, N'OPERATING EXPENSES', N'', N'Light and water')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (126, N'OTHER INCOME (EXPENSE)', N'', N'Interest income')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (127, N'OTHER INCOME (EXPENSE)', N'', N'Rental Income')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (128, N'OTHER INCOME (EXPENSE)', N'', N'Other income')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (129, N'OTHER INCOME (EXPENSE)', N'', N'Unrealized foreign exchange gain (loss)')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (130, N'OTHER INCOME (EXPENSE)', N'', N'Realized foreign exchange gain (loss)')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (131, N'OTHER INCOME (EXPENSE)', N'', N'Bank service charge')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (132, N'OTHER INCOME (EXPENSE)', N'', N'Income tax expense')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (133, N'ASSET', N'Expenses', N'sol''s beers')
INSERT [dbo].[Coa] ([ID], [Category], [SubCategory], [AccountName]) VALUES (134, N'ASSET', N'Expenses', N'sol''s 2x2')
SET IDENTITY_INSERT [dbo].[Coa] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (1, N'Ma. Divine Grace Valencia', N'C.', N'ABESAMIS', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (2, N'Mark Anthony', N'S.', N'ALAURIN', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (3, N'Jonhvic', N'O.', N'ALVAREZ', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (4, N'Ma. Rose Anne', N'F.', N'ANCHETA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (5, N'Joselino', N'B.', N'ANG', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (6, N'Karl Patrick', N'C.', N'AÑO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (7, N'Joeffrey Edriel', N'F.', N'BALANGATAN', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (8, N'Carl Marvin', N'B.', N'BANCIFRA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (9, N'Angelica', N'F.', N'BAYONA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (10, N'Jimy Henry', N'B.', N'CANLAS', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (11, N'Carla Kristel', N'N.', N'CARDENAS', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (12, N'Christian', N'M.', N'CIUDADANO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (13, N'Mhark Lawrence', N'L.', N'DICHOS', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (14, N'Threcia Mharie', N'S.', N'ESTROPIGAN', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (15, N'Norman', N'R.', N'FLORDELIZ', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (16, N'Ryan Merck', N'F.', N'FONTANILLA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (17, N'John Aaron', N'U.', N'GAPAYAO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (18, N'Karl Angelo', N'L.', N'GARAIS', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (19, N'James Louis', N'D.', N'GARAY', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (20, N'John Ardy', N'T.', N'NZAGA', NULL )
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (21, N'Philip Ceasar', N'J.', N'HALLARCES', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (22, N'Newera Lyn', N'F.', N'HIPOLITO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (23, N'Blair Benjamin', N'DC.', N'IGNACIO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (24, N'Honey Grace', N'C.', N'LARA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (25, N'Eric Gerard', N'C.', N'LAREZA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (26, N'Art Benedict', N'C.', N'LIBRE', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (27, N'Timothy Spencer', N'P.', N'LOPEZ', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (28, N'Adreian', N'E."', N'LUCIANO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (29, N'Stephen', N'D.', N'MAGUDDAYAO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (30, N'Rafael Antonio', N'B.', N'MANZANO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (31, N'Jolly', N'B.', N'MANZANO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (32, N'Sante', N'B.', N'MARISCOTES', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (33, N'Justin Ernesto', N'T.', N'MENDOZA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (34, N'O Nam Naomi', N'W.', N'NG', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (35, N'Sze Yu Famous', N'W.', N'NG', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (36, N'Mark Cidric', N'L.', N'PABLO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (37, N'Kenny Rey', N'B.', N'PALADAN', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (38, N'Leah Rose', N'C.', N'PALOGAN', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (39, N'Earlson Christian Leo', N'C.', N'PAVO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (40, N'Patricia', N'Cake', N'RAMIREZ', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (41, N'Reymond', N'A.', N'RELLON', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (42, N'Emmanuel Jr.', N'B.', N'REYES', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (43, N'Neil Patrick', N'Q.', N'REYES', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (44, N'John Vincent', N'', N'ROSALI', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (45, N'Krizza Mae', N'T.', N'SABULARSE', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (46, N'Lester', N'A.', N'SAHAGUN', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (47, N'Jenny Lyn', N'P.', N'SALIMO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (48, N'Peter', N'', N'SANTIA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (49, N'John Moises', N'R.', N'SANTOS', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (50, N'Paulo Luiz', N'D.', N'SANTOS', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (51, N'John Glenn', N'R.', N'SAPA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (52, N'Carl Jamesy', N'O.', N'SENIA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (53, N'Herminia', N'R.', N'SISANTE', 1)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (54, N'Allyn', N'M.', N'TACUD', NULL )
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (55, N'Ron Daniel', N'F.', N'TAGUDIN', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (56, N'Bryan-Charles', N'B.', N'TENERIFE', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (57, N'Nathankissam Roy', N'A.', N'TUBIS', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (58, N'Chrysler', N'Boyd', N'VELASCO', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (59, N'Ma. Bernadette', N'G.', N'VERGARA', NULL)
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (60, N'Federico III', N'Z.', N'VILLAREAL', NULL)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectCategory] ON 

INSERT [dbo].[ProjectCategory] ([ID], [Code], [Name]) VALUES (1, N'ITCM', N'IT Commodities')
INSERT [dbo].[ProjectCategory] ([ID], [Code], [Name]) VALUES (2, N'PSEC', N'Physical Security Products')
INSERT [dbo].[ProjectCategory] ([ID], [Code], [Name]) VALUES (3, N'LISP', N'LightSpeed ISP Solution')
INSERT [dbo].[ProjectCategory] ([ID], [Code], [Name]) VALUES (4, N'ICTS', N'Infrastracture Services')
INSERT [dbo].[ProjectCategory] ([ID], [Code], [Name]) VALUES (5, N'ISEC', N'Infrastracture Security Products')
INSERT [dbo].[ProjectCategory] ([ID], [Code], [Name]) VALUES (6, N'RTSG', N'Security Services')
SET IDENTITY_INSERT [dbo].[ProjectCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectCode] ON 
GO
INSERT [dbo].[ProjectCode] ([ID], [ProjectCategoryID], [ProjectYear], [ClientID], [ProjectNumber], [Code], [Description]) VALUES (1, 5, 2023, 23, N'01', N'ISEC--DND-01', NULL)
GO
INSERT [dbo].[ProjectCode] ([ID], [ProjectCategoryID], [ProjectYear], [ClientID], [ProjectNumber], [Code], [Description]) VALUES (2, 5, 2023, 23, N'02', N'ISEC--DND-02', NULL)
GO
INSERT [dbo].[ProjectCode] ([ID], [ProjectCategoryID], [ProjectYear], [ClientID], [ProjectNumber], [Code], [Description]) VALUES (3, 5, 2023, 23, N'03', N'ISEC--DND-03', NULL)
GO
INSERT [dbo].[ProjectCode] ([ID], [ProjectCategoryID], [ProjectYear], [ClientID], [ProjectNumber], [Code], [Description]) VALUES (4, 5, 2023, 23, N'04', N'ISEC--DND-04', NULL)
GO
SET IDENTITY_INSERT [dbo].[ProjectCode] OFF
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([ID], [Code], [Name]) VALUES (1, N'ACCT001', N'ACCOUNTING')
INSERT [dbo].[Department] ([ID], [Code], [Name]) VALUES (2, N'ADMI002', N'ADMIN')
INSERT [dbo].[Department] ([ID], [Code], [Name]) VALUES (3, N'BLUE003', N'BLUE TEAM')
INSERT [dbo].[Department] ([ID], [Code], [Name]) VALUES (4, N'HRES004', N'HUMAN RESOURCES')
INSERT [dbo].[Department] ([ID], [Code], [Name]) VALUES (5, N'INFR005', N'INFRA TEAM')
INSERT [dbo].[Department] ([ID], [Code], [Name]) VALUES (6, N'PURC006', N'PURCHASING')
INSERT [dbo].[Department] ([ID], [Code], [Name]) VALUES (7, N'REDT007', N'RED TEAM')
INSERT [dbo].[Department] ([ID], [Code], [Name]) VALUES (8, N'MNGT008', N'MANAGEMENT')
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[PayeeCategory] ON 
GO
INSERT [dbo].[PayeeCategory] ([ID], [Code], [Name]) VALUES (1, N'ACTMGR', N'Account Manager')
GO
INSERT [dbo].[PayeeCategory] ([ID], [Code], [Name]) VALUES (2, N'TECNCL', N'Technical')
GO
INSERT [dbo].[PayeeCategory] ([ID], [Code], [Name]) VALUES (3, N'BACEND', N'Back End')
GO
INSERT [dbo].[PayeeCategory] ([ID], [Code], [Name]) VALUES (4, N'OTHERS', N'Others')
GO
SET IDENTITY_INSERT [dbo].[PayeeCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[Payee] ON 
GO
INSERT [dbo].[Payee] ([ID], [PayeeCategoryID], [EmployeeID], [FirstName], [MiddleName], [LastName]) VALUES (1, 1, 1, N'Ma. Divine Grace Valencia', N'C.', N'ABESAMIS')
GO
INSERT [dbo].[Payee] ([ID], [PayeeCategoryID], [EmployeeID], [FirstName], [MiddleName], [LastName]) VALUES (2, 2, 2, N'Mark Anthony', N'S.', N'ALAURIN')
GO
INSERT [dbo].[Payee] ([ID], [PayeeCategoryID], [EmployeeID], [FirstName], [MiddleName], [LastName]) VALUES (3, 3, 3, N'Jonhvic', N'O.', N'ALVAREZ')
GO
INSERT [dbo].[Payee] ([ID], [PayeeCategoryID], [EmployeeID], [FirstName], [MiddleName], [LastName]) VALUES (4, 4, 4, N'Ma. Rose Anne', N'F.', N'ANCHETA')
GO
SET IDENTITY_INSERT [dbo].[Payee] OFF
GO
SET IDENTITY_INSERT [dbo].[PettyCash] ON 
GO
INSERT [dbo].[PettyCash] ([ID], [PCFNo], [Date], [PayeeID], [Particulars], [ProjectCodeID], [DepartmentID], [ClientID], [Amount]) VALUES (1, N'01-00001', CAST(N'2023-10-19T00:00:00.0000000' AS DateTime2), 1, N'Sample Particulars data only 1', 1, 1, 23, CAST(1000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[PettyCash] ([ID], [PCFNo], [Date], [PayeeID], [Particulars], [ProjectCodeID], [DepartmentID], [ClientID], [Amount]) VALUES (2, N'01-00002', CAST(N'2023-10-27T00:00:00.0000000' AS DateTime2), 2, N'Sample Particulars data only 2', 2, 2, 7, CAST(2000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[PettyCash] ([ID], [PCFNo], [Date], [PayeeID], [Particulars], [ProjectCodeID], [DepartmentID], [ClientID], [Amount]) VALUES (3, N'01-00003', CAST(N'2023-10-28T00:00:00.0000000' AS DateTime2), 3, N'Sample Particulars data only 3', 3, 3, 7, CAST(3000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[PettyCash] ([ID], [PCFNo], [Date], [PayeeID], [Particulars], [ProjectCodeID], [DepartmentID], [ClientID], [Amount]) VALUES (4, N'01-00004', CAST(N'2023-10-29T00:00:00.0000000' AS DateTime2), 4, N'Sample Particulars data only 4', 4, 4, 7, CAST(4000.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[PettyCash] OFF
GO
SET IDENTITY_INSERT [dbo].[JournalEntry] ON 
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (1, 1, 1, CAST(100.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (2, 1, 1, NULL, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (3, 1, 11, CAST(100.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (4, 1, 11, NULL, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (8, 1, 3, CAST(100.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (9, 1, 3, NULL, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (10, 1, 5, CAST(100.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (11, 1, 5, NULL, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (12, 1, 6, CAST(100.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (13, 1, 6, NULL, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (14, 1, 7, CAST(100.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (15, 1, 7, NULL, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (16, 1, 8, CAST(100.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (17, 1, 8, NULL, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (18, 1, 9, CAST(100.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (19, 1, 9, NULL, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (20, 1, 10, CAST(100.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (21, 1, 10, NULL, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (22, 1, 4, CAST(100.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (23, 1, 4, NULL, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (24, 2, 5, CAST(2000.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (25, 2, 11, NULL, CAST(2000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (26, 3, 5, CAST(3000.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (27, 3, 11, NULL, CAST(3000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (28, 4, 5, CAST(4000.00 AS Decimal(18, 2)), NULL)
GO
INSERT [dbo].[JournalEntry] ([ID], [PettyCashID], [CoaID], [Debit], [Credit]) VALUES (29, 4, 11, NULL, CAST(4000.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[JournalEntry] OFF
GO