using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web0._1.Models
{
    public class upload
    {
        [Required(ErrorMessage = "Please Enter Your Full Name")]
        [Display(Name = "Product Name")]
        public string productName { get; set; }

        [Required(ErrorMessage = "Please Enter discription ")]
        [Display(Name = "product disc")]
        [MaxLength(200)]
        public string description { get; set; }

        [Required(ErrorMessage = "Please Enter price ")]
        [Display(Name = "product price")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$")]
        public decimal price { get; set; }

        [Required(ErrorMessage = "Please Upload File")]
        [Display(Name = "Upload File")]
        [ValidateFile]
        public HttpPostedFileBase file { get; set; }
    }

    //Customized data annotation validator for uploading file
    public class ValidateFileAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int MaxContentLength = 1024 * 1024 * 3; //3 MB
            string[] AllowedFileExtensions = new string[] { ".jpg", ".gif", ".png", ".pdf" };

            var file = value as HttpPostedFileBase;

            if (file == null)
                return false;
            else if (!AllowedFileExtensions.Contains(file.FileName.Substring(file.FileName.LastIndexOf('.'))))
            {
                ErrorMessage = "Please upload Your Photo of type: " + string.Join(", ", AllowedFileExtensions);
                return false;
            }
            else if (file.ContentLength > MaxContentLength)
            {
                ErrorMessage = "Your Photo is too large, maximum allowed size is : " + (MaxContentLength / 1024).ToString() + "MB";
                return false;
            }
            else
                return true;
        }
    }
}