using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace UIPathCustom_StringManupulation
{
    public class RemoveBlankLines:CodeActivity
    {
        [Category("input")]
        
        public InArgument<string> InputString  { get; set; }
        [Category("Output")]

        public OutArgument<string> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
           
        {
            string strName = InputString.Get(context);
           
            strName= Regex.Replace(strName, @"^\s+$[\r\n]*", "", RegexOptions.Multiline);
            string result = strName;

            Result.Set(context, result);
        }
    }
}
