ALTER PROCEDURE spc_VerificaNotasFaltantes
AS

SET NOCOUNT ON

declare @MinVenda INT, @MaxVenda INT
declare @tblFaltas TABLE (CodVenda INT)

select @MinVenda = MIN(CAST(CodVenda AS INT)), @MaxVenda = MAX(CAST(CodVenda AS INT))
from tbl_Saida

DECLARE @cont INT, @CodVenda VARCHAR(10)

SET @Cont = @MinVenda

WHILE @Cont < @MaxVenda BEGIN

	SELECT @CodVenda = CodVenda FROM tbl_Saida WHERE CodVenda = @cont --AND ChaveSefaz IS NOT NULL

	IF @@ROWCOUNT = 0 INSERT INTO @tblFaltas (CodVenda) VALUES (@cont)

	SET @cont = @cont + 1
END

SELECT *, MinVenda = @MinVenda, MaxVenda = @MaxVenda FROM @tblFaltas

--select @MinVenda, @MaxVenda