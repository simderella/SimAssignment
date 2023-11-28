# SimAssignment
게더 만들기 개인과제

알게 된 기능 및 코드

1. 인풋 시스템
![image](https://github.com/simderella/SimAssignment/assets/146172523/31c83fd7-cb9d-423b-9ab7-df03427b6cf2)

인풋 시스템을 사용하면 복잡한 코드를 사용하여 움직임이나 물리적 동작을 만들 필요없이, 사용자가 원하는 키입력을 설정하여
간단하게 나타낼 수 있다.

   
3. Asset 파일 Import
<https://assetstore.unity.com/packages/2d/characters/2d-character-sprite-animation-penguin-236747>
<https://assetstore.unity.com/packages/2d/environments/rogue-fantasy-castle-164725>
사용 된 에셋 링크이다.
 
4. 카메라가 플레이어 따라가기
구글링을 통해 알게 된 코드이다.
public class MainCameraAction : MonoBehaviour
{
    public GameObject Target;
    public float offsetX = 0.0f;            // 카메라의 x좌표
    public float offsetY = 10.0f;           // 카메라의 y좌표
    public float offsetZ = -10.0f;          // 카메라의 z좌표

    public float CameraSpeed = 10.0f;       // 카메라의 속도
    Vector3 TargetPos;                      // 타겟의 위치

    // Update is called once per frame
    void FixedUpdate()
    {
        // 타겟의 x, y, z 좌표에 카메라의 좌표를 더하여 카메라의 위치를 결정
        TargetPos = new Vector3(
            Target.transform.position.x + offsetX,
            Target.transform.position.y + offsetY,
            Target.transform.position.z + offsetZ
            );

        // 카메라의 움직임을 부드럽게 하는 함수(Lerp)
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
    }

5. 애니메이션 추가
미니프로젝트에서 배운 애니메이션 효과를 사용하여 캐릭터에 움직임을 더해줬다. 처음 해본 기능이라서 복습하지 않아도 아직까지 기억에 남아있어서 쉽게 해결할 수 있었다.


6. 물리적 동작 RigidBody , 충돌 감지 Collider 컴포넌트
RigidBody = 
GameObject에 물리적 동작을 가능하게 해주는 Component이다.
해당 Component가 추가된 GameObject는 Forces에 따라서 반응한다.

Collider = 
GameObject에게 물리적으로 일어난 충돌을 감지해주는 Component이다.
일종의 센서라고 알고있으면 이해하기 쉽다.

7. 타일맵 만들기
2D Object -> Tilemap -> Rectangular 를 사용하여 맵을 만들어주었다.
메뉴 창의 Window -> 2D -> TilePalette 를 추가하여 Asset 파일들을 옮겨서 그려주는 기능이 있어서 맵을 만들기 수월했다.
추가로 컴포넌트 Rigidbody 와 Collider 를 사용하여 벽을 넘어가지 못하도록 설정해주었고, 기본적으로 Rigidbody 를 주게되면 중력의 영향을 받아 아래로 내려가게 되는데, Gravity 값을 0으로 설정하여 해결했다.
