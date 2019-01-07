DROP PROCEDURE IF EXISTS updateLink;
GO

CREATE PROCEDURE updateLink
	@id INT,
	@link TEXT
AS
	UPDATE bank SET link=@link WHERE id=@id;