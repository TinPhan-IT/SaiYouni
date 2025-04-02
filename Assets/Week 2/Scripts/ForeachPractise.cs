using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các phần tử trong mảng

        int[] soNguyen = { 1, 2, 3, 4, 5 };

        foreach (int i in soNguyen)
        {
            //Debug.Log(i);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng

        int[] soNguyen = { 1, 2, 3, 4, 5 };
        int tong = 0;

        foreach (int i in soNguyen)
        {
            tong += i;
        }
            //Debug.Log(tong);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng

        int[] soNguyen = { 69, 12, 26, 54, 32, 20, 47 };

        int maxValue = int.MinValue;
        foreach (int i in soNguyen)
        {
            if (i > maxValue) maxValue = i;
        }
        //Debug.Log(maxValue);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng

        int[] soNguyen = { 69, 12, 26, 54, 32, 20, 47,87 ,101, 8, 61 };
        
        int soLuongSoChan = 0;
        foreach (int i in soNguyen)
        {
            if (i % 2 == 0) soLuongSoChan++;
        }
        //Debug.Log(soLuongSoChan);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách

        List<string> strings = new List<string>
        {
            "1","a", "b", "hello world"
        };

        foreach (string i in strings)
        {
            //Debug.Log(i);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách

        List<string> strings = new List<string>
        {
            "1","a", "b", "hello world"
        };

        string chuoiDaiNhat = "";

        foreach (string i in strings)
        {
            if (i.Length >  chuoiDaiNhat.Length) chuoiDaiNhat = i;
            //Debug.Log(i);
        }
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng

        int[] soNguyen = { 69, 12, 26, 54, 32, 20, 47, 87, 101, 8, 61 };

        int tongSoLe = 0;
        foreach (int i in soNguyen)
        {
            if (i % 2 != 0) tongSoLe += i;
        }
        //Debug.Log(tongSoLe);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các số chẵn trong mảng

        int[] soNguyen = { 69, 12, 26, 54, 32, 20, 47, 87, 101, 8, 61 };

        foreach (int i in soNguyen)
        {
            if (i % 2 == 0)
            {
                //Debug.Log(i);
            }
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không

        int[] soNguyen = { 69, 12, 26, 54, 32, 20, 47, 87, 101, 8, 61 };
        int kiemTraPhanTu = 69;
        bool tonTai = false;
        foreach (int i in soNguyen)
        {
            if (i == kiemTraPhanTu)
            {
                tonTai = true;
                break;
            } 
        }

        if (tonTai) Debug.Log(kiemTraPhanTu + " " + "có tồn tại trong mảng");
        else Debug.Log(kiemTraPhanTu + " " + "không tồn tại");
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng

        int[] soNguyen = { 69, -12, 26, 54, 32, -20, -47, 87, 101, -8, 61 };
        int tongSoAm = 0;

        foreach (int i in soNguyen)
        {
            if (i < 0)
            {
                tongSoAm++;
            }
            //Debug.Log(tongSoAm);
        }
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng

        int[] soNguyen = {9, 5, 22, 11, 10, 1, 55};
        int soLonHon10 = 10;

        foreach (int i in soNguyen)
        {
            if (i > soLonHon10)
            {
                //Debug.Log(i);
            }
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách

        List<string> strings = new List<string>
        {
            "C#","abc", "baba", "hello world", "Unity", "1"
        };

        string chuoiNgatNhat = strings[0];

        foreach (string i in strings)
        {
            if (i.Length < chuoiNgatNhat.Length)
            {
                chuoiNgatNhat = i;
            }
            //Debug.Log(chuoiNgatNhat);
        }
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng

        int[] soNguyen = { 69, 12, 26, 54, 32 };

        foreach (int i in soNguyen)
        {
            int ketQua = i * 2;
            //Debug.Log(ketQua);
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng

        int[] soNguyen = { 69, 12, 26, 54, 32, 20, 47 };

        int maxValue1 = int.MinValue;
        int maxValue2 = int.MinValue;
        foreach (int i in soNguyen)
        {
            if (i > maxValue1) maxValue1 = i;
            else if (i > maxValue2 && i < maxValue1) maxValue2 = i;
        }
        //Debug.Log("Max1" + " " + maxValue1 + ": " + "Max2" + " " + maxValue2);
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'

        string[] strings = { "Apple", "Banana", "C#", "Unity", "Hihi", "Ahaha" };

        foreach (string i in strings) 
        {
            if ( i.StartsWith("A"))
            {
                //Debug.Log(i);
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không

        string[] strings = { "Apple", "Banana", "C#", "Unity", "Hihi", "Ahaha", "Hello" };
        bool isExit = false;

        foreach (string i in strings)
        {
            if (i == "Hello")
            {
                isExit = true;
                break;
            }
        }

        if (isExit) Debug.Log(isExit + " " + "có tồn tại trong mảng");
        else Debug.Log(isExit + " " + "không tồn");
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng

        int[] soNguyen = { 69, 12, -26, 54, 32, -20, 47 };

        foreach (int i in soNguyen)
        {
            if (i < 0)
            {
                //Debug.Log(i);
            }

        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng

        int[] soNguyen = { 69, 69, 69, 12, -26, 54, 32, -20, 47};

        int phanTuCanDem = 69;
        int demPhanTu = 0;

        foreach (int i in soNguyen)
        {
            if (i == phanTuCanDem)
            {
                demPhanTu++;
                //Debug.Log(demPhanTu);
            }
        }
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10

        int[] soNguyen = { 69, 12, 9, 54, 32, 2 };

        List<int> listInt = new();

        foreach (int i in soNguyen)
        {
            if(i > 10) listInt.Add(i);
        }

        foreach (int i in listInt)
        {
            //Debug.Log(i);
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự

        string[] strings = { "C#", "abc", "baba", "hello world", "Unity", "1" };
            
        foreach (string i in strings)
        {
            if (i.Length >= 5)
            {
                //Debug.Log(i);
            }
        }
    }
}