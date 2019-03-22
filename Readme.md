
# Overview

@Author: **liam.pham@grapecity.com**

@Date: 20/03/2019

# Requirements

Understand .NET core framework, ASP.NET Core infrastructure and basic components.

Build a simple .net Core app to do the CRUD actions.

# How to run this test

You can view online demo at : https://gcfamily.azurewebsites.net/ or run it yourself through source code.

To run source code:
- Run with command line: 
    - install .Net Core    
    - Run command line : 
        > dotnet restore
        
        > dotnet run

- Run with Visual Studio 2017:
    - install  .NET core
    - install VS workload (if not yet)
    - run/debug



# .NET Core Framework

Là em trai cùng cha giống mẹ với .Net Framework. .Net Core thừa hưởng những đặc tính vốn có, đồng thời có thêm những đặc tính khác biệt và vượt trội so với người đàn anh. Mãi tới cuối tháng 6 năm 2016 .NetCore mới ra đời, nghĩa là trẻ hơn ông anh tận 14 tuổi :)).

Vì không muốn đứng nhìn các sản phẩm của mình chỉ chạy trên hệ sinh thái của Window, MS đã quyết định dấn thân vào sân chơi đa nền tảng. Và .Net Core framework là một trong những viên gạch đầu tiên cho tham vọng đó.

## .NET Core là có các đặc tính nổi bật sau:

- **Cross-Platform**: Support các OS phổ biến ở thời điểm hiện tại gồm Window, MacOS, Linux.. Trên cái framework này có thể viết đủ thể loại ứng dụng bao gồm Destop Application, ứng dụng Web, IoT, các backend API...

- **Open-Source**: Xây dựng 1 framwork "Sạch" hơn, tận dụng sự hỗ trợ của cộng đồng các nhà phát triển.

- **Flexible Deployment**: Có 2 cách để triển khai 1 ứng dụng đó là framework-dependent deployment hoặc self-contained deployment. framework-dependent thì chỉ có app và các third party dependency được cài đặt, ứng dụng sẽ chạy phụ thuộc vào phiên bản .NET core được cài đặt trên hệ thống. self-contained deployment thì nó đóng gói tất vào 1 file chạy, kể cả .NET core.

- **Modular**: Tính module hóa rất cao, thay vì đóng gói toàn bộ thì .NET Core chỉ đóng gói những thành phần cần thiết để chạy ứng dụng. Điều đó giúp file chạy nhẹ hơn, tăng hiệu năng, giảm chi phí...



.NET Core hỗ trợ 4 loại ứng dụng đa nền tảng như : ASP.NET Core web apps, Command-line apps, libraries, và Universal Windows Platform apps. Hiện tại (Version 2.2) chưa hỗ trợ WF hay WPF, tuy nhiên .Net Core 3 sẽ hỗ trợ các công nghệ Desktop như WinForms, WPF và UWP.

Giống như các Open Source framework khác, .Net Core sử dụng NuGet để quản lý, tự động hóa việc cài đặt, nâng cấp, gỡ bỏ các phần mềm, thư viện. Trong khi .Net Framework sử dụng thông qua các Window Update services.

