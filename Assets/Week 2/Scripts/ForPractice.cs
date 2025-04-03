using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    private void Start()
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
    private void BaiTap1()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các phần tử trong mảng

        int[] soNguyen = { 69, 12, 26, 54, 32, 20, 47 };

        for (int i = 0; i < soNguyen.Length; i++)
        {
            //Debug.Log(soNguyen[i]);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    private void BaiTap2()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng

        int[] soNguyen = { 69, 12, 26, 54, 32, 20, 47 };

        int tong = 0;

        for (int i = 0; i < soNguyen.Length; i++)
        {
            tong += soNguyen[i];
            //Debug.Log(tong);
        }
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    private void BaiTap3()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng

        int[] soNguyen = { 69, 12, 26, 54, 32, 20, 47 };
        int maxValue = soNguyen[0];
        for (int i = 1; i < soNguyen.Length; i++)
        {
            if (soNguyen[i] > maxValue) maxValue = soNguyen[i];
            //Debug.Log(maxValue);
        }
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    private void BaiTap4()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    private void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách

        List<string> strings = new List<string>
        {
            "C#","abc", "baba", "hello world", "Unity", "1"
        };

        for (int i = 0; i < strings.Count; i++)
        {
            //Debug.Log(strings[i]);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    private void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách

        List<string> strings = new List<string>
        {
            "C#","abc", "baba", "hello world", "Unity", "1"
        };

        string chuoiDaiNhat = strings[0];

        for (int i = 0; i < strings.Count; i++)
        {
            if (strings[i].Length > chuoiDaiNhat.Length)
            {
                chuoiDaiNhat = strings[i];
            }
            //Debug.Log(chuoiDaiNhat);
        }
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    private void BaiTap7()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng

        int[] soNguyen = { 69, 12, 54, 32, 17, 87, 100, 8, 61 };
        int soLuongSoLe = 0;

        for (int i = 0; i < soNguyen.Length; i++)
        {
            if (soNguyen[i] % 2 != 0) soLuongSoLe++;
            //Debug.Log(soLuongSoLe);
        }
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    private void BaiTap8()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các số chẵn trong mảng

        int[] soNguyen = { 69, 12, 54, 32, 17, 87, 100, 8, 61 };

        for (int i = 0; i < soNguyen.Length; i++)
        {
            if (soNguyen[i] % 2 == 0)
            {
                //Debug.Log(soNguyen[i]);
            }
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    private void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không

        int[] soNguyen = { 69, 12, 54, 32, 17, 87, 100, 8, 61 };

        int phanTuCankiemTra = 12;

        bool isExits = false;

        for (int i = 0; i < soNguyen.Length; i++)
        {
            if (soNguyen[i] == phanTuCankiemTra)
            {
                isExits = true;
            }
        }
        if (isExits) Debug.Log(phanTuCankiemTra + ": " + "có tồn tại trong mảng");
        else Debug.Log(phanTuCankiemTra + ": " + "không tồn tại trong mảng");
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    private void BaiTap10()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng

        int[] soNguyen = { 69, 12, 54, -32, 17, 87, 100, -8, 61 };

        int soLuongAm = 0;

        for (int i = 0; i < soNguyen.Length; i++)
        {
            if (soNguyen[i] < 0)
            {
                soLuongAm++;
                //Debug.Log(soLuongAm);
            }
        }
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    private void BaiTap11()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng

        int[] soNguyen = { 6, 1, 54, 32, 9, 10, 100, 8, 61 };

        for (int i = 0; i < soNguyen.Length; i++)
        {
            if (soNguyen[i] > 10)
            {
                //Debug.Log(soNguyen[i]);
            }
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    private void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách

        List<string> strings = new List<string>
        {
            "C#","abc", "baba", "hello world", "Unity", "1"
        };

        string chuoiNgatNhat = strings[0];

        for (int i = 0; i < strings.Count; i++)
        {
            if (strings[i].Length < chuoiNgatNhat.Length)
            {
                chuoiNgatNhat = strings[i];
            }
            //Debug.Log(chuoiNgatNhat);
        }
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    private void BaiTap13()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng

        int[] soNguyen = { 6, 1, 54, 32, 9, 10, 100, 8, 61 };

        for (int i = 0; i < soNguyen.Length; i++)
        {
            soNguyen[i] *= 2;
            //Debug.Log(soNguyen[i]);
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    private void BaiTap14()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng

        int[] soNguyen = { 69, 12, 26, 54, 32, 20, 47 };

        int maxValue1 = int.MinValue;
        int maxValue2 = int.MinValue;

        for (int i = 0; i < soNguyen.Length; i++)
        {
            if ((soNguyen[i] > maxValue1)) maxValue1 = soNguyen[i];
            else if ((soNguyen[i] > maxValue2) && soNguyen[i] < maxValue1) maxValue2 = soNguyen[i];
        }
        //Debug.Log("Max1" + " " + maxValue1 + ": " + "Max2" + " " + maxValue2);
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    private void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'

        List<string> strings = new List<string>
        {
            "C#","Abc", "baba", "hello world", "Unity", "1"
        };

        for (int i = 0; i < strings.Count; i++)
        {
            if (strings[i].StartsWith("A"))
            {
                Debug.Log(strings[i]);
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    private void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không

        List<string> strings = new List<string>
        {
            "C#","Abc", "baba", "hello world", "Unity", "1"
        };

        string chuoiCanKiemTra = "C#";
        bool isExits = false;

        for (int i = 0; i < strings.Count; i++)
        {
            if ((strings[i] == chuoiCanKiemTra))
            {
                isExits = true;
            }
        }
        if (isExits) Debug.Log(chuoiCanKiemTra + ": " + "có tồn tại trong danh sách");
        else Debug.Log(chuoiCanKiemTra + ": " + "không tồn tại trong danh sách");
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    private void BaiTap17()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng

        int[] soNguyen = { 69, 12, 54, -32, 17, 87, 100, -8, 61 };

        for (int i = 0; i < soNguyen.Length; i++)
        {
            if (soNguyen[i] < 0)
            {
                //Debug.Log(soNguyen[i]);
            }
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    private void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng

        int[] soNguyen = { 69, 12, 54, 32, 17, 87, 63, 100, 8, 61, 14, 63, 94, 55, 62, 18, 94, 56, 165, 17, 90, 81, 63, 630 };
        int phanTuCanDem = 63;
        int soDemDuoc = 0;

        for (int i = 0; i < soNguyen.Length; i++)
        {
            if (soNguyen[i] == phanTuCanDem)
            {
                soDemDuoc++;
            }
        }
        //Debug.Log(soDemDuoc);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    private void BaiTap19()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10

        int[] soNguyen = { 69, 12, 9, 54, 12, 2, 9, 18, 3, 55 };

        List<int> listInt = new();

        for (int i = 0; i < soNguyen.Length; ++i)
        {
            if (soNguyen[i] > 10) listInt.Add(soNguyen[i]);
        }

        foreach (int i in listInt)
        {
            //Debug.Log(i);
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    private void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự

        List<string> strings = new List<string>
        {
            "C#","Abc", "baba", "hello world", "Unity", "1"
        };

        for (int i = 0; i < strings.Count; ++i)
        {
            if (strings[i].Length >= 5)
            {
                Debug.Log(strings[i]);
            }
        }
    }
}