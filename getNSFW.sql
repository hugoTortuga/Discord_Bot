﻿DROP PROCEDURE IF EXISTS getNSFW;
GO

CREATE PROCEDURE getNSFW
	@id INT
AS
SELECT link FROM bank WHERE id=(
	SELECT id_image FROM nsfw WHERE id=@id
);