using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj_personnel
{
    class PersonInfo
    {
        #region 사원등록
        public string name { get; set; }  //사원 이름
        public string gender { get; set; } //성별
        public string age { get; set; } //나이
        public string position { get; set; } //직급
        public string department { get; set; } //소속부서
        public string date { get; set; } //입사일

        public string phoneNum { get; set; } //연락처
        public string address { get; set; } //주소

        #endregion



        #region 사원검색
        public string departmentType { get; set; } //부서별

        public string inputDepartment { get; set; } //부서별 입력
        #endregion



        #region 부서등록
        public string departmentName { get; set; } //부서명

        public string headDepartment { get; set; } //부서장
        #endregion

    }
}
