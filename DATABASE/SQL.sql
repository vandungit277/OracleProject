--VIEW HANG HOA--
CREATE OR REPLACE FORCE VIEW "VANDUNG277"."VIEWHANGHOA" ("MAHANGHOA", "TENHANGHOA", "MOTA", "SOLUONGTON", "GIANHAP", "TENLOAIHANG", "TENNSX") AS 
SELECT H.MAHANGHOA, H.TENHANGHOA, H.MOTA, H.SOLUONGTON, H.GIANHAP, L.TENLOAIHANG, N.TENNSX
FROM HANGHOA H INNER JOIN LOAIHANGHOA L ON H.MALOAIHANG = L.MALOAIHANG INNER JOIN NHASANXUAT N ON H.MANSX = N.MANSX;

--VIEW LOAI HANG HOA--
CREATE OR REPLACE FORCE VIEW "VANDUNG277"."VIEWLOAIHANG" ("MALOAIHANG", "TENLOAIHANG") AS 
SELECT MALOAIHANG, TENLOAIHANG
FROM LOAIHANGHOA;

--VIEW NHA SAN XUAT--
CREATE OR REPLACE FORCE VIEW "VANDUNG277"."VIEWNHASANXUAT" ("MANSX", "TENNSX") AS 
SELECT MANSX, TENNSX
FROM NHASANXUAT;
  
--
--SEQUENCE TU TAM MA HANG HOA--
CREATE SEQUENCE MA_HANG_HOA_TU_TANG
MINVALUE 1
MAXVALUE 99999999999999999999
START WITH 1
INCREMENT BY 1
NOCYCLE;
  
--TRIGGER TU TAM MA HANG HOA--
CREATE OR REPLACE TRIGGER MA_HANG_HOA_TU_TANG
BEFORE INSERT ON VANDUNG277.HANGHOA
  FOR EACH ROW
BEGIN
  SELECT MA_HANG_HOA_TU_TANG.nextval INTO :new.MAHANGHOA FROM DUAL;
END;

/*CREATE OR REPLACE TRIGGER MAHANGHOATUTANG
BEFORE INSERT ON VANDUNG277.HANGHOA
  FOR EACH ROW
BEGIN
  SELECT MAHANGHOA INTO :new.MAHANGHOA FROM VANDUNG277.HANGHOA WHERE ROWNUM = 1 ORDER BY MAHANGHOA DESC;
  :new.MAHANGHOA := :new.MAHANGHOA + 1;
END;*/
  
--PROCEDURE THEM HANG HOA--
CREATE OR REPLACE PROCEDURE THEMHANGHOA(p_TenHangHoa IN HANGHOA.TENHANGHOA%TYPE, p_MoTa IN HANGHOA.MOTA%type, p_SoLuongTon IN HANGHOA.SOLUONGTON%type, 
            p_GiaNhap IN HANGHOA.GIANHAP%type, p_MaNSX IN HANGHOA.MANSX%type, p_MaLoaiHang IN HANGHOA.MALOAIHANG%type)
IS
BEGIN
    INSERT INTO VANDUNG277.HANGHOA(TENHANGHOA, MOTA, SOLUONGTON, GIANHAP, MANSX, MALOAIHANG)
    VALUES(p_TenHangHoa, p_MoTa, p_SoLuongTon, p_GiaNhap, p_MaNSX, p_MaLoaiHang);
    COMMIT;
END;

--PROCEDURE SUA HANG HOA--
CREATE OR REPLACE PROCEDURE SUAHANGHOA(p_MaHangHoa IN HANGHOA.MAHANGHOA%type, p_TenHangHoa IN HANGHOA.TENHANGHOA%TYPE, p_MoTa IN HANGHOA.MOTA%type, 
            p_SoLuongTon IN HANGHOA.SOLUONGTON%type, p_GiaNhap IN HANGHOA.GIANHAP%type, p_MaNSX IN HANGHOA.MANSX%type, p_MaLoaiHang IN HANGHOA.MALOAIHANG%type)
IS
BEGIN
    UPDATE VANDUNG277.HANGHOA 
        SET TENHANGHOA = p_TenHangHoa, MOTA = p_MoTa, SOLUONGTON = p_SoLuongTon, GIANHAP = p_GiaNhap, MANSX = p_MaNSX, MALOAIHANG = p_MaLoaiHang
        WHERE MAHANGHOA = p_MaHangHoa;
    COMMIT;
END;

--PROCEDURE XOA HANG HOA--
CREATE OR REPLACE PROCEDURE XOAHANGHOA(p_MaHangHoa IN HANGHOA.MAHANGHOA%type)
IS
BEGIN
    DELETE FROM VANDUNG277.HANGHOA WHERE MAHANGHOA = p_MaHangHoa;
    COMMIT;
END;

--------------------------------------------------------------------
--08/6/2017---------------------------------------------------------
--------------------------------------------------------------------

--SEQUENCE TU TANG MA KHACH HANG--
CREATE SEQUENCE MA_KHACH_HANG_TU_TANG
MINVALUE 1
MAXVALUE 99999999999999999999
START WITH 1
INCREMENT BY 1
NOCYCLE;

--TRIGGER TU TANG MA KHACH HANG--
CREATE OR REPLACE TRIGGER MA_KHACH_HANG_TU_TANG
BEFORE INSERT ON VANDUNG277.KHACHHANG
  FOR EACH ROW
BEGIN
  SELECT MA_KHACH_HANG_TU_TANG.nextval INTO :new.MAKHACHHANG FROM DUAL;
END;

--PROCEDURE THEM KHACH HANG--
CREATE OR REPLACE PROCEDURE THEM_KHACH_HANG(p_Ten KHACHHANG.TENKHACHHANG%TYPE, p_SDT KHACHHANG.SODIENTHOAI%TYPE, 
                    p_DC KHACHHANG.DIACHI%TYPE, p_Email KHACHHANG.EMAIL%TYPE)
IS
BEGIN
    INSERT INTO VANDUNG277.KHACHHANG(TENKHACHHANG, SODIENTHOAI, DIACHI, EMAIL)
    VALUES(p_Ten, p_SDT, p_DC, p_Email);
    COMMIT;
END;   

--SEQUENCE TU TANG MA PHIEU XUAT--
CREATE SEQUENCE MA_PHIEU_XUAT_TU_TANG
MINVALUE 1
MAXVALUE 99999999999999999999
START WITH 1
INCREMENT BY 1
NOCYCLE;

--TRIGGER TU TANG MA PHIEU XUAT--
CREATE OR REPLACE TRIGGER MA_PHIEU_XUAT_TU_TANG
BEFORE INSERT ON VANDUNG277.PHIEUXUAT
  FOR EACH ROW
BEGIN
  SELECT MA_PHIEU_XUAT_TU_TANG.nextval INTO :new.MAPX FROM DUAL;
END;      

--FUNCTION LAY MA KHACH HANG THEO SDT--
CREATE OR REPLACE FUNCTION FN_LAY_MA_KHACH_HANG(p_SDT IN NUMBER) 
          RETURN NUMBER
          AS
              p_MaKH NUMBER;
          BEGIN
            BEGIN
                SELECT MAKHACHHANG INTO p_MaKH FROM KHACHHANG WHERE SODIENTHOAI = p_SDT; 
                EXCEPTION WHEN NO_DATA_FOUND THEN p_MaKH := 0;
            END;
            RETURN p_MaKH;
          END;
          
--PROCEDURE THEM PHIEU XUAT--
CREATE OR REPLACE PROCEDURE THEM_PHIEU_XUAT(p_MaNV PHIEUXUAT.MANHANVIEN%TYPE, p_Ten KHACHHANG.TENKHACHHANG%TYPE, 
                            p_SDT KHACHHANG.SODIENTHOAI%TYPE, p_DC KHACHHANG.DIACHI%TYPE, p_Email KHACHHANG.EMAIL%TYPE)
IS
    p_MaKH number;    
BEGIN        
    SELECT FN_LAY_MA_KHACH_HANG(p_SDT) INTO p_MaKH FROM DUAL;
    IF p_MaKH = 0 THEN
        THEM_KHACH_HANG(p_Ten, p_SDT, p_DC, p_Email);
        SELECT FN_LAY_MA_KHACH_HANG(p_SDT) INTO p_MaKH FROM DUAL;
    END IF;
    INSERT INTO VANDUNG277.PHIEUXUAT(MANHANVIEN, MAKHACHHANG) VALUES(p_MaNV, p_MaKH);
    COMMIT;
END;

--TRIGGER THEM CT PHIEU XUAT--
CREATE OR REPLACE TRIGGER THEM_CHI_TIET_PHIEU_XUAT
BEFORE INSERT ON VANDUNG277.CT_PHIEUXUAT
  FOR EACH ROW
BEGIN
  SELECT MA_PHIEU_XUAT_TU_TANG.currval INTO :new.MAPX FROM DUAL;
END;

--PROCEDURE THEM CT PHIEU XUAT--
CREATE OR REPLACE PROCEDURE THEM_CHI_TIET_PHIEU_XUAT(p_MaHH CT_PHIEUXUAT.MAHANGHOA%TYPE, p_SoLuong CT_PHIEUXUAT.SOLUONG%TYPE, p_TongTien CT_PHIEUXUAT.TONGTIEN%TYPE)
IS
BEGIN
    INSERT INTO VANDUNG277.CT_PHIEUXUAT(MAHANGHOA, SOLUONG, TONGTIEN)
    VALUES(p_MaHH, p_SoLuong, p_TongTien);
    COMMIT;
END;

--TEST-TEST-TEST-TEST-TEST-TEST-TEST-TEST-TEST-TEST-TEST-TEST-TEST-TEST-TEST-TEST--     
SELECT * FROM VIEWHANGHOA;
SELECT * FROM VIEWLOAIHANG;
SELECT * FROM VIEWNHASANXUAT;
exec THEMHANGHOA('TEST', 'TEST', 123, 12345, 2, 2);
exec SUAHANGHOA(3, 'TEST1', 'TEST1', 123, 12345, 2, 2);
exec XOAHANGHOA(3);
exec THEM_KHACH_HANG('Quoc Toan','01234567899','Test �ia chi','test@gmail.com');
exec THEM_PHIEU_XUAT(1, 'Quoc Toan','123456770','test �c','test@gmail.com');
exec THEM_CHI_TIET_PHIEU_XUAT(2,1,1000);