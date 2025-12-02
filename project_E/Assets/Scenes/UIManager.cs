using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject popupPrefab;
    public Transform canvasTransform;//캔버스 위치
    public string TitleText;
    public string ContentText;

    public void OpenNoticePopup()
    {
        GameObject newPopup = Instantiate(popupPrefab, canvasTransform);
        //팝업프리팹 생성, 캔버스 위치에 //생성한 팝업 변수
        Popup popupScript = newPopup.GetComponent<Popup>();
        //팝업 스크립트 변수

        popupScript.SetContent(this.TitleText, this.ContentText);//팝업 내용 설정
    }
}
