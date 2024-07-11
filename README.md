# wpf-toyproject-2024
🚑WPF TOYPROJECT 레포지토리 :  대전 치과 정보 서비스앱

##  🧾프로젝트 소개
- 대전 치과 정보 서비스 앱은 대전의 모든 치과를 데이터 그리드를 통해 보여주고 원하는 치과를 선택하면 그 치과에 대한 상세 정보를 알려주는 앱입니다.
- 원하는 치과 선택시 지도 서비스, 전화번호 등의 정보를 알 수 있습니다.
- 즐겨찾기 기능을 이용해 한번 다녀온 치과는 즐겨찾기하여 다음 이용시 편리하게 확인 가능합니다.
- 오프라인 지도 서비스 
## 🛠️기능 구현을 위해 패키지 및 툴
- Cefsharp WebBrowser 패키지
- Cefsharp.Apis 패키지
- GMap.NET.WinPresentation 패키지
- GMap.NET.Core 패키지
- MahApps.Metro UI
- SQL Server, DB 연동
- 오픈 api 활용
## 🚀개발 기간
- 2024-05-13(1차)
- 2024-05-21 ~ 2024-05-27(2차)
## ✨주요 기능
- 조회 및 정보 확인 기능
    - 조회 버튼 클릭 시 대전 치과 목록이 그리드뷰에 출력
    - 그리뷰 병원 더블 클릭 시 상세 정보 팝업 
    - 그리뷰 병원 클릭 시 구글 맵에서 위치 정보 화면이 나옴
    

    ![조회 및 정보 실행화면](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/PJ003.png)  ![조회 및 정보 실행화면](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/PJ004.png)
   
    <img src = "https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/PJ005.png" align="center">


- 나의병원 (즐겨찾기) 추가 및 삭제 기능
    - 나의병원 추가 버튼을 이용하여 즐겨찾기 목록 생성
        - 복수개 선택 가능
        - 즐겨찾기 목록에서 다시 추가 버튼 클릭시 중복 저장 되지 않게 기능 구현
        - 복수개 선택 시 이미 저장되어 있는 병원은 제외하고 저장됨. 
    - 나의병원 삭제 버튼 클릭시 즐겨 찾기 목록에서 삭제 됨

    ![나의병원 저장 실행화면](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/PJ007.png)    ![나의병원 저장 실행화면](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/PJ006.png)    ![나의병원 저장 실행화면](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/PJ008.png)



## 🤝보완해서 개발할 거
- 병원 이름 검색을 통해 병원 선택하기
- 맵 크게 보기 버튼 구현하기
- 구글 api 사용하여 구글맵 서비스 활용하여 app 기능 추가하기

# 토이프로젝트 개발 2차 준비중...
- 구글 맵 지원 기능 
(https://developers.google.com/maps/documentation/maps-static/start?hl=ko)
    - 위치 지정 위도,경도 사용하지 않고 주소를 사용하여 나타내기 위해서 주소를 지리적 지점으로 변환하는 것을 지오코딩 -> Maps Static API 서비스에서 지오코딩 실행가능
    - 주소를 나타낸느 문자열은 URL로 인코딩 되어야 함 (City+Hall,New+York,NY)

## 2일차
- Nudget 패키지 설치하기
    - GMap.NET.Core
    - GMap.NET.WinPresentation
- 구글 맵 열기 구현하기
    - 지도 서비스 클릭시 구글맵 열림
    - 치과에 Mark 표시하기

![구글맵](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/pj003.jpg)

## 3일차
- 기능 추가
    - 병원 선택을 하면 구글맵에 자동 검색 기능
    - 병원 선택시 구글맵 아래 텍스트 박스에 주소, 전화번호 정보 출력

![병원정보](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/pj009.png)
