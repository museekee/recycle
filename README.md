# **[[다운로드]](https://github.com/moremi-kr/recycle/releases/tag/v0.1.1)**
# Trash
- 쓰레기 버리는 게임입니다.

## 제작자가 하고싶은 말
- 제발 벽 뚫지 말아주세요.
- 유니티 처음해봅니다.
- 윈도우, 안드로이드 지원합니다.
- 핵 만들어도 별로 할게 없습니다. 고작 성공, 실패(세자리수가 최대) 조작 정도..?
- **이거 GPL 3.0이다.**
- 소스코드는 ./Assets/Scripts 에 있습니다.
- 사실 제가 분리수거를 잘 몰라서 쉬워요.

## 포함 된 폰트
- NEXONLv1GothicBold.ttf
- NEXONLv1GothicLight.ttf
- NEXONLv1GothicRegular.ttf

모두 ./Assets/Resources/Fonts 에 존재합니다.

## 포함된 효과음
### https://github.com/JJoriping/KKuTu
- fail.mp3 (fail.mp3)
- success.mp3 (missing.mp3)
- click.mp3 (k.mp3)
    

## 도움말
### 쓰레기 추가
- 쓰레기를 추가 하려면 Trashes.json의 해당하는 Tag(쓰레기 종류)를 찾은 후 Amount를 1 증가시켜주세요.
- 쓰레기 위치는./Assets/Resources/Trashes/Tag/번호.png 입니다.
### 태그 이름 설명
- A-Z순 입니다.
- Can : 캔류
- Food : 음식물 쓰레기
- Glass : 병류
- Paper : 종이류
- PaperPack : 종이팩
- Pet : 페트
- Plastic : 플라스틱
- Trash : 일반 쓰레기
- Viasic : 밑 더 자세한 설명에 있습니다.
- Vinil : 비닐류
- WaterPlastic : 물에 씻어야 하는 플라스틱
#### 더 자세한 설명
WaterPlastic을 추가시킨다면 Plastic도 추가되어야 합니다.
WaterPlastic을 세척용 물에 닿으면 Plastic으로 변하기 때문입니다.
반대로 Plastic을 추가한다면 WaterPlastic은 필요 없습니다. 대신 번호 순서는 WaterPlastic과 함께갑니다.
예) WaterPlastic은 1,2,5,6번이 있고 Plastic은 1,2,3,4,5,6,7번이 있을 수 있음 (저도 어떻게 설명할지 잘 모르겠네요).

Viastic은 Vinil + Plastic입니다.
플라스틱과 비닐이 따로 떼져서 분리해 버려야 하는 아이템입니다.

#### 해야 할 것
- 쓰레기들 화질 개선