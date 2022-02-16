using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Dto.Response
{
    public class BaseResponse
    {

        public bool Success { get; set; }
        //public bool IsDeleted { get; set; }
        
        //public string Createby { get; set; }
        //public DateTime CreateDate { get; set; }
        
        //public string Updateby { get; set; }

        //public DateTime UpdateDate { get; set; }

        public ICollection<string> Errors { get; set; }
        public BaseResponse()
        {
            Errors= new List<string>(); 
        }
    }
    public class  BaseResponseGeneric<TClass>:BaseResponse
    {
        public TClass Result { get; set; }   
    }
    public class BaseCollectionResponse<TClass>:BaseResponseGeneric<TClass>
    {
        public int TotalPages { get; set; } 
    }
}
