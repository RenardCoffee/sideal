CREATE PROC [dbo].[UsuarioDeleteID]
@ID_usuario int
	AS
		DELETE FROM T_usuarios
		WHERE ID_usuario = @ID_usuario