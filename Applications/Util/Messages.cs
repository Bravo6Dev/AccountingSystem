using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Util
{
    public class Messages
    {
        public const string ExistEmployee = "عذرا هذا الرقم مستخدم من قبل موظف اخر";
        public const string SqlError = "حدث خطأ اثناء ما, يرجى اعادة المحاولة لاحقا";
        public const string AddNew = "تمت اضافة {0} بنجاح";
        public const string NotFound = "عذرا لم يتم العثور على {0} المطلوب";
        public const string WrongCredentials = "كلمة المرور او اسم المستخدم غير صحيح";
    }
}
