# wpf-toyproject-2024
wpf toyproject 레포지토리 :  대전 치과 정보 서비스앱

##  프로젝트 소개
- 대전 치과 정보 서비스 앱은 대전의 모든 치과를 데이터 그리드를 통해 보여주고 원하는 치과를 선택하면 그 치과에 대한 상세 정보를 알려주는 앱입니다.
- 원하는 치과 선택시 지도 서비스, 전화번호 등의 정보를 알 수 있습니다.
- 즐겨찾기 기능을 이용해 한번 다녀온 치과는 즐겨찾기하여 다음 이용시 편리하게 확인 가능합니다.

## 개발 기간
- 2024-05-13 

## 주요 기능
- 조회 및 정보 확인 기능
    - 조회 버튼 클릭 시 대전 치과 목록이 그리드뷰에 출력
    - 그리뷰 병원 더블 클릭 시 상세 정보 팝업 
    - 그리뷰 병원 클릭 시 구글 맵에서 위치 정보 화면이 나옴

    ![조회 및 정보 실행화면](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/PJ003.png)  ![조회 및 정보 실행화면](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/PJ004.png)
    ![조회 및 정보 실행화면](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/PJ005.png)


- 나의병원 (즐겨찾기) 추가 및 삭제 기능
    - 나의병원 추가 버튼을 이용하여 즐겨찾기 목록 생성
        - 복수개 선택 가능
        - 즐겨찾기 목록에서 다시 추가 버튼 클릭시 중복 저장 되지 않게 기능 구현
        - 복수개 선택 시 이미 저장되어 있는 병원은 제외하고 저장됨. 
    - 나의병원 삭제 버튼 클릭시 즐겨 찾기 목록에서 삭제 됨

    ![나의병원 저장 실행화면](https://raw.githubusercontent.com/Juhyi/wpf-toyproject-2024/main/images/pj002.jpg)


## 기능 구현을 위해 패키지 및 툴
- Cefsharp WebBrowser 패키지
- Cefsharp.Apis 패키지
- MahApps.Metro UI
- SQL Server, DB 연동
- 오픈 api 활용

## 보완해서 개발할 거
- 병원 이름 검색을 통해 병원 선택하기