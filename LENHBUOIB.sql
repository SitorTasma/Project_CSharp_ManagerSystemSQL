CREATE PROC CHEN_PHONGBAN(@MP NVARCHAR(50), @TP NVARCHAR(50), @SDT NVARCHAR(50))
AS INSERT PHONGBAN VALUES(@MP, @TP, @SDT)
EXEC CHEN_PHONGBAN 'DL', 'ĐI LẮC', '102023123'
---
CREATE PROC CAPNHAT_PHONGBAN(@TENP NVARCHAR(50), @SODT NVARCHAR(50), @MAP NVARCHAR(50))
AS UPDATE PHONGBAN SET TENPHONG = @TENP, SODIENTHOAI = @SODT WHERE MAPHONG = @MAP
EXEC CAPNHAT_PHONGBAN 'PHÚ BÒI', '032325241', 'DL'
---
CREATE PROC XOA_PHONGBAN(@MAPHONG NVARCHAR(50))
AS DELETE FROM PHONGBAN WHERE MAPHONG = @MAPHONG
EXEC XOA_PHONGBAN 'DL'	