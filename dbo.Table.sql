CREATE TABLE [dbo].[TaxRegions]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Municipalities] NCHAR(100) NULL, 
    [TaxBand1] DECIMAL NULL, 
    [TaxBand2] DECIMAL NULL, 
    [TaxBand3] DECIMAL NULL, 
    [TaxBand4] DECIMAL NULL, 
    [Rate1] DECIMAL NULL, 
    [Rate2] DECIMAL NULL, 
    [Rate3] DECIMAL NULL, 
    [Rate4] DECIMAL NULL
)
