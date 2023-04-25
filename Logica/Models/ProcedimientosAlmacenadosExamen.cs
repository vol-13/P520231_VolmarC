using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    internal class ProcedimientosAlmacenadosExamen
    {
        /*
         USE [P5_2023_1]
GO
/****** Object:  StoredProcedure [dbo].[SPProveedorAgregar]    Script Date: 25/04/2023 0:49:52 ******/
        /*  SET ANSI_NULLS ON
          GO
  SET QUOTED_IDENTIFIER ON
  GO
  -- =============================================
  -- Author:		Josué Carvajal
  -- Create date: 
  -- Description:	
  -- =============================================
  ALTER PROCEDURE[dbo].[SPProveedorAgregar]
          @Correo varchar(255),
      @Nombre varchar(255),
      @Cedula varchar(255),
      @Direccion varchar(255),
      @Notas varchar(255),
      @IdTipo int

  AS
  BEGIN

      SET NOCOUNT OFF;

          INSERT INTO Proveedor
          (ProveedorNombre, ProveedorCedula, ProveedorEmail, ProveedorDireccion, ProveedorNotas, ProveedorTipoID)


      VALUES
      (@Nombre, @Cedula, @Correo, @Direccion, @Notas, @IdTipo);

          SELECT 1;

  END

  */


        /*        USE[P5_2023_1]
                GO
        /****** Object:  StoredProcedure [dbo].[SPProveedorConsultarPorCedula]    Script Date: 25/04/2023 0:49:13 ******/
        /*
        SET ANSI_NULLS ON
        GO
        SET QUOTED_IDENTIFIER ON
        GO
        -- =============================================
        -- Author:		Josué Carvajal
        -- Create date: 
        -- Description:	
        -- =============================================
        ALTER PROCEDURE[dbo].[SPProveedorConsultarPorCedula]

                @Cedula varchar(255)


        AS
        BEGIN


            SET NOCOUNT ON;

            SELECT ProveedorID FROM Proveedor

            WHERE ProveedorCedula = @Cedula;

                END
        */

        /*
         * 
         * 
         *USE [P5_2023_1]
        GO
        /****** Object:  StoredProcedure [dbo].[SPProveedorConsultarPorID]    Script Date: 24/04/2023 23:59:55 ******/
        /*
        SET ANSI_NULLS ON
        GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Josue Carvajal
-- Create date: 
-- Description:	
-- =============================================
ALTER PROCEDURE[dbo].[SPProveedorConsultarPorID]
        @ID int
    AS
BEGIN

    SET NOCOUNT ON;

        SELECT Proveedor.ProveedorID, Proveedor.ProveedorNombre, Proveedor.ProveedorEmail, Proveedor.ProveedorCedula,
        ProveedorNotas, TipoProveedor.ProveedorTipoDescripcion, Proveedor.ProveedorDireccion, TipoProveedor.ProveedorTipoID,
        Proveedor.Activo
        FROM  Proveedor INNER JOIN
        TipoProveedor ON Proveedor.ProveedorTipoID = TipoProveedor.ProveedorTipoID
    
        WHERE Proveedor.ProveedorID = @ID;

        END
         */


        /*      USE[P5_2023_1]
      GO
      /****** Object:  StoredProcedure [dbo].[SPProveedorConsultarPorEmail]    Script Date: 24/04/2023 23:57:06 ******/
        /*
        SET ANSI_NULLS ON
        GO
        SET QUOTED_IDENTIFIER ON
        GO
        -- =============================================
        -- Author:		Josué Carvajal
        -- Create date: 
        -- Description:	
        -- =============================================
        ALTER PROCEDURE[dbo].[SPProveedorConsultarPorEmail]

                @Correo varchar(255)


        AS
        BEGIN


            SET NOCOUNT ON;

            SELECT ProveedorID FROM Proveedor

            WHERE ProveedorEmail = @Correo;

                END

        */

        /*
         * USE [P5_2023_1]
GO
/****** Object:  StoredProcedure [dbo].[SPProveedorListar]    Script Date: 24/04/2023 23:42:15 ******/
        /*       SET ANSI_NULLS ON
               GO
       SET QUOTED_IDENTIFIER ON
       GO
       -- =============================================
       -- Author:		Josue Carvajal
       -- Create date: 
       -- Description:	
       -- =============================================
       ALTER PROCEDURE[dbo].[SPProveedorListar]

               AS
       BEGIN


           SET NOCOUNT ON;

           BEGIN

               SELECT  Proveedor.ProveedorID, Proveedor.ProveedorNombre, Proveedor.ProveedorCedula,
               Proveedor.ProveedorEmail,TipoProveedor.ProveedorTipoDescripcion
               FROM    Proveedor INNER JOIN TipoProveedor ON Proveedor.ProveedorTipoID = TipoProveedor.ProveedorTipoID
               WHERE Activo = 1;

               END

           END

       */


/*        USE[P5_2023_1]
GO
/****** Object:  StoredProcedure [dbo].[SPTipoProveedorListar]    Script Date: 25/04/2023 0:56:49 ******/
/*SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Vólmar Carvajal
-- Create date: 
-- Description:	
-- =============================================
ALTER PROCEDURE[dbo].[SPTipoProveedorListar]

        AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here

    SELECT ProveedorTipoID AS ID, ProveedorTipoDescripcion AS Descrip

    FROM TipoProveedor

END
            */
    }
}
