using System.ComponentModel.DataAnnotations;

namespace Kimtaehoo_hompage.Models
{
    public class User
    {
        /// <summary>
        /// 사용자 번호
        /// </summary>
        [Key] // PK 설정
        public int UserNo { get; set; }
        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required]  // Not Null 설정
        public string UserName { get; set; }
        /// <summary>
        /// 사용자 ID
        /// </summary>
        [Required]  // Not Null 설정
        public string UserId { get; set; }
        /// <summary>
        /// 사용자 PassWord
        /// </summary>
        [Required]  // Not Null 설정
        public string UserPassWord { get; set; }
    }
}
