USE [OrderMateDBFinal]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[SP_SALES_BY_MENUITEM]
		@menuItemId = 333,
		@DateFrom = '2000-01-01',
		@DateTo = '2020-01-01'

SELECT	@return_value as 'Return Value'

GO
