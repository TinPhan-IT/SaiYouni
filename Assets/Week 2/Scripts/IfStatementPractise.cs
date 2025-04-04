using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        //BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        //BaiTap2(); // Kiểm tra số chẵn hay lẻ
        //BaiTap3(); // Kiểm tra điều kiện thi đỗ
        //BaiTap4(); // Tìm số lớn nhất trong hai số
        //BaiTap5(); // Kiểm tra điều kiện mua hàng
        //BaiTap6(); // Kiểm tra năm nhuận
        //BaiTap7(); // Tính giá vé xem phim
        //BaiTap8(); // Kiểm tra học sinh xuất sắc
        //BaiTap9(); // So sánh ba số
        //BaiTap10(); // Tính tiền lương
        //BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        //BaiTap12(); // Phân loại học sinh
        //BaiTap13(); // Tính tiền điện
        //BaiTap14(); // Kiểm tra điều kiện thăng chức
        //BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        //BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó là số dương, âm hay bằng 0

        float number = -1;

        if (number < 0)
        {
            Debug.Log("Đây là số âm");
        }

        else if (number > 0)
        {
            Debug.Log("Đây là số đương");
        }

        else Debug.Log("Đây là số 0");
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó là số chẵn hay lẻ

        float number = 3;

        if (number % 2 == 0)
        {
            Debug.Log("Đây là số chẵn");
        }

        else if (number % 2 != 0)
        {
            Debug.Log("Đây là số lẻ");
        }

        else Debug.Log("Đây là số 0");
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt

        float diemKiemtra = 4.9f;

        if (diemKiemtra >= 5)
        {
            Debug.Log("ĐỖ!");
        }

        else Debug.Log("NGƯỢC");
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        // Nhập hai số nguyên từ bàn phím
        // Kiểm tra và in ra số lớn nhất trong hai số đó

        int number1 = -1;
        int number2 = 2;

        if (number1 > number2) Debug.Log(number1 + " " + "lớn hơn" + " " + number2);
        else if (number2 > number1) Debug.Log(number2 + " " + "lớn hơn" + " " + number1);
        else Debug.Log("Hai số bằng nhau");
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        // Kiểm tra xem người dùng có đủ tiền mua hàng không

        float soTien = 50.00f;
        float matHang = 49.99f;

        if (soTien >= matHang) Debug.Log("Bạn đủ tiền mua hàng");
        else Debug.Log("Bạn không đủ tiền mua hàng");
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        // Nhập một năm từ bàn phím
        // Kiểm tra xem năm đó có phải là năm nhuận hay không

        int year = 2025;

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0 ) Debug.Log(year + " " + "là năm nhuận");
        else Debug.Log(year + " " + "không phải năm nhuận");
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        // Nhập tuổi của người mua vé từ bàn phím
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng

        int yourAge = 17;

        int underAge = 17;
        float underAgeTicket = 50.000f;

        int mature = 18;
        float matureTicket = 100.000f;

        if (yourAge <= underAge) Debug.Log("Giá vé của bạn là" + ": " + underAgeTicket);
        else if (yourAge >= mature) Debug.Log("Giá vé của bạn là" + ": " + matureTicket);
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)

        float diem = 9.1f;
        float diemCanDat = 9.0f;

        if (diem >= diemCanDat)
        {
            Debug.Log("Bạn là học sinh xuất sắc!");
        }

        else Debug.Log("Bạn không phải là học sinh xuất sắc!");
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        // Nhập ba số nguyên từ bàn phím
        // Kiểm tra và in ra số lớn nhất trong ba số đó

        int number1 = 6157;
        int number2 = 6169;
        int number3 = 6186;

        if (number1 > number2 && number1 > number3) Debug.Log(number1 + " là số lớn nhất");
        else if (number2 > number1 && number2 > number3) Debug.Log(number2 + " là số lớn nhất");
        else if (number3 > number2 && number3 > number1) Debug.Log(number3 + " là số lớn nhất");
        else Debug.Log("Ba số bằng nhau");
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định

        float gioLamCuaBan = 39;

        float luongCodinh = 45f;
        float luongThemGio = 20f;
        int gioLamViec = 40;

        if (gioLamCuaBan > gioLamViec)
        {
            float tongLuong;
            tongLuong = luongCodinh += luongThemGio;
            Debug.Log("Bạn đã làm việc hơn 40 tiếng và đây là phần trưởng cho bạn:" + " " + tongLuong);
        }
        else if (gioLamCuaBan <= gioLamViec)
        {
            Debug.Log("Bạn đã làm việc đủ 40 tiếng và đây là phần trưởng cho bạn:" + " " + luongCodinh);
        }
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ

        int yourAge = 19;
        bool yourMenberCard = false;

        int age = 18;
        bool menberCard = true;

        if (yourAge >= age && yourMenberCard == menberCard)
        {
            Debug.Log("Bạn được vào câu lạc bộ!");
        }
        else Debug.Log("Bạn không được vào câu lạc bộ");
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        float diemCuaBan = 4.9f;

        float xuatSac = 9.0f;
        float kha = 8.0f;
        float trungBinh = 5.0f;

        if (diemCuaBan >= xuatSac) Debug.Log("Học sinh xuất sắc");
        else if (diemCuaBan >= kha) Debug.Log("Học sinh khá");
        else if (diemCuaBan >= trungBinh) Debug.Log("Học sinh trung bình");
        else Debug.Log("Học sinh yếu");
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        // Nhập số điện tiêu thụ từ bàn phím
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
        float mucDoTieuThuDien = 101f;

        float kWh = 100f;
        float tienTren100 = 1.500f;
        float tienDuoi100 = 2.000f;

        if (mucDoTieuThuDien > kWh) Debug.Log("Chi phí tiêu thụ điện là: " + tienTren100 + " đồng/kWh");
        else Debug.Log("Chi phí tiêu thụ điện là: " + tienDuoi100 + " đồng/kWh");
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        // Nhập số năm làm việc và đánh giá công việc
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức

        int namDaCongTacCuaBan = 4;
        bool DanhGiaTotCuaBan = true;

        int namDaCongTac = 5;
        bool duocDanhGiaTot = true;

        if (namDaCongTacCuaBan >= namDaCongTac && DanhGiaTotCuaBan == duocDanhGiaTot) Debug.Log("Bạn được thăng chức");
        else Debug.Log("Bạn không đủ điều kiệu để thăng chức");
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        // Nhập giá trị đơn hàng từ bàn phím
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        float DonHangCuaBan = 486.000f;

        float giaTriDonHang = 500.000f;

        if (DonHangCuaBan >= giaTriDonHang)
        {
            Debug.Log("Đơn hàng của bạn đủ điều kiện miễn phí vận chuyển.");
        }
        else
        {
            Debug.Log("Đơn hàng của bạn không đủ điều kiện miễn phí vận chuyển.");
        }
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        // Nhập thu nhập từ bàn phím
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập

        float thuNhapCuaBan = 7500000f;
        float thueThuNhapCaNhan = 0.05f;

        if (thuNhapCuaBan > 5000000f)
        {
            float ThuNhapSauThue;
            ThuNhapSauThue = thuNhapCuaBan * thueThuNhapCaNhan;
            Debug.Log("Thu nhập của bạn: " + ThuNhapSauThue +"VND");
        }
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)

        float diem1 = 6.0f;
        float diem2 = 7.5f;
        float diem3 = 8.0f;

        float averageScore = (diem1 + diem2 + diem3) / 3;

        if (averageScore >= 5.0f)
        {
            Debug.Log($"Điểm trung bình là: {averageScore}. Học sinh đạt yêu cầu.");
        }
        else
        {
            Debug.Log($"Điểm trung bình là: {averageScore}. Học sinh không đạt yêu cầu.");
        }
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)

        int currentStock = 85;
        int maxCapacity = 100;

        // Check if more goods can be added
        if (currentStock < maxCapacity)
        {
            Debug.Log($"Hàng hiện tại: {currentStock}. Có thể nhập thêm hàng.");
        }
        else
        {
            Debug.Log($"Hàng hiện tại: {currentStock}. Không thể nhập thêm hàng, kho đã đầy.");
        }
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó có lớn hơn 10 hay không

        int number = 15;

        if (number > 10)
        {
            Debug.Log($"Số {number} lớn hơn 10.");
        }
        else
        {
            Debug.Log($"Số {number} không lớn hơn 10.");
        }
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không

        float diemTongKet = 8.5f;
        bool duocNhapNhanHocNangCao = false;

        bool duocHocNangCao = true;

        if (diemTongKet >= 8.0f && duocHocNangCao && duocNhapNhanHocNangCao)
        {
            Debug.Log("Học sinh đủ điều kiện đăng ký khóa học nâng cao.");
        }
        else
        {
            Debug.Log("Học sinh không đủ điều kiện đăng ký khóa học nâng cao.");
        }
    }
}
