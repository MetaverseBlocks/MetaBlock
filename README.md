# MetaBlock 
*haptic을 활용한 메타버스 실감교육 플랫폼 '메타블록'*
<br>
<br>
![메타블록](https://github.com/MetaverseBlocks/MetaBlock/blob/main/images/metablock%20meaning_resize.jpg)
<br>
<br>

## 🖥️ 프로젝트 소개
**두 손의 감각을 이용해 가상현실에서도 실제와 같은 블록 놀이를 즐기다**
- **개발 배경**
<br>초등학생 인터뷰, 교육봉사, 보도 및 관련 논문 자료조사 진행 
<br>>> 흥미로운 메타버스? 실제 촉감을 느낄 수 있는 가상현실로 초등학생들의 흥미 유발
<br>>> 블록놀이 교육적 효과? 사회학습의 기회, 수학적 경험 촉진, 신체발달 고무, 공간지각 능력 개념 향상
<br>블록놀이의 교육적 가치와 초실감 메타버스를 결합한 초등학생 대상 "메타블록: haptic활용 메타버스 실감교육 플랫폼" 기획 및 제작 

- **차별성 및 목표**
<br>최근 들어 많은 사람들에게 주목 받고 있으며 급부상한 메타버스 시장
<br>>> 평범한 3D게임과 달리 촉감을 자극하는 초실감 메타버스는 찾아보기 힘듦 
<br>메타버스 연동 햅틱 디바이스의 다양하고 즉각적인 촉각 피드백
<br>>> 블록놀이 몰입감 상승과 실제와 같은 경험 제공
<br>메타버스상 자유로운 블록 놀이로 공간제약 없이 자신만의 작품 제작
<br>>> 사용자의 디지털적 사고방식과 문제해결 능력 향상에 기여

## 🕰️ 개발 기간
* 2022.04.26~2022.10.25

### ⚙️ 개발 환경
- Language : C#, C
- IDE : Unity, Visual Studio, Arduino IDE
- H/W 
    - device : Leap Motion, Haptic Glove, Moving Controller
    - equipment : felx sensor, vibration motor, servo motor, joy stick, switch button 
    - communication : HC-06 Bluetooth 
![구성도](https://github.com/MetaverseBlocks/MetaBlock/blob/main/images/system.png)


### 🧑‍🤝‍🧑 맴버 구성
 - 팀장  : 박지연 - 손 제스쳐 인식, 블록생성,  블록놀이, 립모션 연결, 블루투스 통신
 - 팀원1 : 전인서 - 햅틱 글로브 제작, 이동 컨트롤러 제작, 메타블록 3D맵 제작
 - 팀원2 : 나유경 - 햅틱 글로브 제작, 이동 컨트롤러 제작, 블루투스 연결  
 - 팀원3 : 오은아 - 개발 보고서 문서 작성
 - 팀원4 : 이경주 - 로고 디자인, 립모션 연결 
<br>


## 📌 주요 기능
![주요기능](https://github.com/MetaverseBlocks/MetaBlock/blob/main/images/main%20function.gif)
<br>

### **#A. 메타블록**
#### 사용자 손 제스쳐 인식 
- *Ultraleap SDK* 활용 🔗[UnityPlugin-github](https://github.com/ultraleap/UnityPlugin) 
- 클릭 제스쳐
    - 검지 손가락만 펼치고 나머지 손가락은 접은 모션
    - 버튼 터치 모드로 전환
- 팔레트 펼치기/닫기 제스쳐
    - 오른손바닥을 뒤집는 모션
- 블록잡기/놓기 제스쳐 인식
    - 블록잡고 이동 : holding the block and moving
    - 블록놓은 순간 : left/right hand put down the block
    - 블록잡은 순간 : grabbing the block
<details>
<summary>Image 📷</summary>
  
![프로젝트#1](https://github.com/MetaverseBlocks/MetaBlock/blob/main/images/%ED%94%84%EB%A1%9C%EC%A0%9D%ED%8A%B81%EB%B2%88%EC%82%AC%EC%A7%84.png)
  
</details>

#### 블록생성
- 팔레트 펼치기
- 블록 색상 선택
    - 클릭 제스쳐
    - 검지손가락 끝 충돌함수 활용 index tip - *onCollisionEnter* 
- 시야 속 랜덤 드롭
  
#### 블록놀이
- 블록 잡기
- 블록 쌓기
- 블록 충돌 타이밍 감지
    - 손가락별 충돌 감지
    - 햅틱 디바이스 작동 신호 전송
<details>
<summary>Image 📷</summary>
  
![프로젝트#2](https://github.com/MetaverseBlocks/MetaBlock/blob/main/images/%ED%94%84%EB%A1%9C%EC%A0%9D%ED%8A%B82%EB%B2%88%EC%82%AC%EC%A7%84.png)
  
</details>

<br>

### **#B. 햅틱 디바이스**
#### 햅틱 글로브
- 피부 감각 재현
    - UI버튼 클릭시 진동 피드백
    - 블록놀이 중 진동 피드백 
    - 손 끝 촉각 자극
- 운동 감각 재현
    - 블록 잡기시 손모양 고정  
    - 플렉스센서, 서보모터 활용
    - 물리적 힘 → 손 동작 제어

#### 이동 컨트롤러
-  앞/뒤/좌/우 
    - 하드웨어 조이스틱 조작
    - 메타버스상 사용자 위치 움직임
- 위/아래
    - 하드웨어 스위치버튼 조작
    - 메타버스상 사용자 시야 움직임
<details>
<summary>Image 📷</summary>
  
![프로젝트#3](https://github.com/MetaverseBlocks/MetaBlock/blob/main/images/%ED%94%84%EB%A1%9C%EC%A0%9D%ED%8A%B83%EB%B2%88%EC%82%AC%EC%A7%84.png)
  
</details>
<br>
<br>

✅ **블루투스 통신**
- Unity3D
    - *Arduino Bluetooth API* 활용 🔗[ArduinoBluetoothPlugin-UnityAssetStore](https://assetstore.unity.com/packages/tools/input-management/arduino-bluetooth-plugin-98960)
    - 실행시 햅틱디바이스 블루투스와 자동 연결 
 - Unity3D → Arduino
    - 블록충돌 타이밍
    - UI요소 터치 타이밍
    - 진동 피드백 손가락 정보
- Arduino → Unity3D
    - 사용자 위치 이동 정보
<br>


## 🎥 시연 영상

[**[YouTube] <span style="font-size:89%">haptic을 활용한 메타버스 실감교육 플랫폼 '메타블록' </span>**](https://www.youtube.com/watch?v=PJec90oPHjQ)
<br>
[![Thumbnail](https://github.com/MetaverseBlocks/MetaBlock/blob/main/images/metablock%20intro.gif)](https://www.youtube.com/watch?v=PJec90oPHjQ)
<br>
<br>


## 🏆 수상 실적
**2022 이브와 ICT 멘토링 공모전 동상 수상**
<br>
[[영남대 학과소식] <span style="font-size:80%">박지연, 나유경, 오은아, 이경주, 전인서 학생 ‘2022 이브와 ICT 멘토링 공모전’ IT여성기업인협회장상 (동상) 수상</span>](https://www.yu.ac.kr/cse/community/news.do?mode=view&articleNo=5372806&article.offset=0&articleLimit=10)
<br>
[[SEN 서울경제TV] <span style="font-size:80%">영남대 컴퓨터공학과, 주요 공모전 휩쓸며 전공 역량 공인</span>](https://m.sentv.co.kr/news/view/648671)
<br>
<br>
**2022 지역 우수 이공계 인재 표창 - 제14회 WIT리더 컨퍼런스 & 시상식**
<br>
[[영남대 학과소식] <span style="font-size:80%">박지연, 나유경, 오은아, 이경주, 전인서 학생, 지역 우수 이공계 인재 표창상 수여</span>](https://www.yu.ac.kr/cse/community/news.do?mode=view&articleNo=5372791&article.offset=0&articleLimit=10)
<br>
<br>
**2022 ICT멘토링 엑스포 아이디어존 전시**
<br>
[[YouTube] 2022 ICT멘토링 엑스포 스케치 영상](https://www.youtube.com/watch?v=JyVylUfShgc)
![엑스포](https://github.com/MetaverseBlocks/MetaBlock/blob/main/images/%EC%97%91%EC%8A%A4%ED%8F%AC%EC%82%AC%EC%A7%84.png) 
<br>
<br>

### 🗂️프로젝트 포스터
<details>
<summary>Poster view</summary>
  
![포스터](https://github.com/MetaverseBlocks/MetaBlock/blob/main/images/metablock%20poster.jpg)
  
</details>
<br>

### 🔗 멤버 깃허브
 - 박지연 - [github/codingGoover](https://github.com/codingGoover)
 - 전인서 - [github/returnstonesteel](https://github.com/returnstonesteel)
 - 나유경 - [github/yoogaeme](https://github.com/yoogaeme)
 - 오은아 - [github/eunalove](https://github.com/eunalove)
 - 이경주 - [github/rodwnl](https://github.com/rodwnl)

