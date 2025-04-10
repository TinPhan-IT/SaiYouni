# Sử Dụng NavMesh Obstacle Trong Unity
-Chọn gameObject, trong Inscpector chọn, add component rồi chọn "NavMesh Obstacle".

## Hỏi AI: Cách Sử Dụng NavMesh Obstacle
- Chọn đối tượng bạn muốn làm chướng ngại vật (ví dụ: tường, bàn, hoặc vật thể động). Trong Inspector, nhấp vào "Add Component" và tìm kiếm "NavMesh Obstacle".
- tùy chỉnh thông số như: 
	+ Shape(hình dạng) của đối tượng.
	+ Carve:
		+Nếu bật, chướng ngại vật sẽ tạo ra lỗ trên NavMesh và buộc NavMesh Agent đi vòng qua.
		+Nếu tắt, NavMesh Agent chỉ coi là một vật thể cần tránh mà không ảnh hưởng trực tiếp đến NavMesh.
	+ Size (Kích thước)
	+ Move Threshold và Time To Stationary

### NavMesh Obstacle là gì?

- là một thành phần (component) trong Unity được sử dụng để tạo ra các vật cản trong môi trường, ngăn cản các nhân vật hoặc đối tượng điều hướng (navigation) qua những khu vực nhất định. Đối tượng được gắn NavMesh Obstacle sẽ trở thành vật cản và có thể tĩnh hoặc động, tùy thuộc vào cách bạn cấu hình nó.