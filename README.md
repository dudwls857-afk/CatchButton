# 버튼을 잡아라!(C# 코딩)
## 개요
-이 작품은 C# WinForms를 이용하여 만든 버튼을 잡아라!게임 마우스가 버튼에 다가가면 도망가도록 만든 프로젝트이다.
## 핵심기능
- 버튼 텍스트를 나를 잡아봐로 설정
- 버튼이 화면밖으로 나가지 않도록 범위를 제한
- 마우스가 버튼위로 가면 다른 위치로 이동하도록 설정
## 화면 구성
-form 1개
-Button 1개
-버튼 이름을 Target 텍스트는 나를 잡아봐
## 실행 화면
-1단계 코드의 실행 스크린샷

<img width="828" height="548" alt="image" src="https://github.com/user-attachments/assets/4c36f446-619b-4def-abfb-15164c953507" />

-버튼의랜덤이동과 화면내로 제한

-2단계 코드의 실행 스크린샷

<img width="828" height="548" alt="image" src="https://github.com/user-attachments/assets/3795122f-91f2-4183-b484-afda0a9d42d8" />

-버튼을 클릭시 축하합니다~! 창이 뜨도록 설정

-3단계 코드의 실행 스크린샷

<img width="835" height="547" alt="image" src="https://github.com/user-attachments/assets/f0127fa9-490d-4f25-a6d1-b7fdc25dc5bb" />

<img width="833" height="542" alt="image" src="https://github.com/user-attachments/assets/70e1c3b3-867f-4a54-9423-4d41de7d615c" />


-클릭할때마다 버튼 크기 축소 설정 및 점수 계산 

-4단계 코드의 실행 스크린샷

<img width="827" height="546" alt="image" src="https://github.com/user-attachments/assets/cccb2032-1bc0-49f0-8e33-f87747fce340" />

-20번 실패시 다시시도 창이 뜨도록 유도

##구현시 어려웠던점
-처음에는 버튼의 위치를 랜덤으로 이동시킬 때 폼의 크기만 이용하여 좌표를 계산했다.그렇게 하니까 화면 밖으로 나가는 일이 생겨 최대 범위를 계산하도록 수정했다.
-게임오버후 다시시도 버튼이 화면에 나타나지 않느 문제가 있었는데 visible 속성을 이용하여 해결하였다.
-초기화되지않던 문제를 reset 버튼을 누를시 misscount와score가 초기화 되도록 설정하였다.
