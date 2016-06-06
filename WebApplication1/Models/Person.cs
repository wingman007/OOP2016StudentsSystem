﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person : BaceModel
    {
        [Required]
        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "EGN Required")]
        [MinLength(10, ErrorMessage = "EGN is 10 digits lenght!")]
        [MaxLength(10, ErrorMessage = "EGN number is 10 digits lenght!")]
        [DisplayName("ЕГН")]
        [EGNValidation]
        public long EGN { get; set; }

        [Required]
        [DisplayName("Е-майл")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

    }
    public class EGNValidation : ValidationAttribute
    {

        public EGNValidation()
        {

        }

        public override bool IsValid(object value)
        {
            string egn = ((long)value).ToString();

            if (egn.Length != 10)
            {
                ErrorMessage = "ЕГН-то трябва да бъде от 10 цифри, а въведенето от вас е с " + egn.Length + " цифра/цифри";
                return false;
            }
            int year = int.Parse(egn.Substring(0, 2));
            int month = int.Parse(egn.Substring(2, 2));
            int day = int.Parse(egn.Substring(4, 2));

            if (month >= 1 && month <= 12)
                year += 1900;
            else if (month >= 21 && month <= 32)
                year += 1800;
            else if (month >= 41 && month <= 52)
                year += 2000;
            else
            {
                ErrorMessage = "Въвели сте невалиден месец в ЕГН-то";
                return false;
            }

            month %= 20;

            if (day == 0 || day > DateTime.DaysInMonth(year, month))
            {
                ErrorMessage = "Въвели сте невалиден ден от месеца";
                return false;
            }

            int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int temp = 0;

            for (int d = 0; d < egn.Length - 1; d++)
                temp += (egn[d] - 48) * weights[d];

            temp %= 11;
            if (temp == 10)
                temp = 0;

            if (temp != int.Parse(egn.Substring(9)))
                ErrorMessage = "Невалидно ЕГН";
            return temp == int.Parse(egn.Substring(9));
        }
    }
}

