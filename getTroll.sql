DROP PROCEDURE IF EXISTS getTroll;
GO

CREATE PROCEDURE getTroll
	@id INT
AS
SELECT link FROM bank WHERE id=(
	SELECT id_image FROM trolls WHERE id=@id
);