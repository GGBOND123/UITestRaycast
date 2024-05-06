using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class TestMain:MonoBehaviour
    {
        public Button Btn1;
        public Button Btn2;
        public Button Btn3;
        
        private void Awake()
        {
            Btn1.onClick.AddListener(OnBtn1Click);
            Btn2.onClick.AddListener(OnBtn2Click);
            Btn3.onClick.AddListener(OnBtn3Click);
        }

        private void OnBtn1Click()
        {
        }
    
        private void OnBtn2Click()
        {
        }
        
        private void OnBtn3Click()
        {
        }
    }
}