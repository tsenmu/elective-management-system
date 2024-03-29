﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ElectiveManagementSystem
{
    public static class Utils
    {
        public static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static string DecodeTime(string time)
        {
            StringBuilder sb = new StringBuilder();
            char[] sep_sc = { ',' };
            char[] sep_cm = { '.' };
            string[] separated_strings = time.Split(sep_sc);
            
            for (int i = 0; i < separated_strings.Length; ++i)
            {
                string str = separated_strings[i];
                string[] res_str = str.Split(sep_cm);
                
                if (res_str.Length == 2)
                {
                    bool succeeded = true;
                    try
                    {
                        int weekday = Convert.ToInt32(res_str[0]);
                        int section = Convert.ToInt32(res_str[1]);
                        if (succeeded)
                        {
                            string weekday_str;
                            switch (weekday)
                            {
                                case 1:
                                    weekday_str = "一";
                                    break;
                                case 2:
                                    weekday_str = "二";
                                    break;
                                case 3:
                                    weekday_str = "三";
                                    break;
                                case 4:
                                    weekday_str = "四";
                                    break;
                                case 5:
                                    weekday_str = "五";
                                    break;
                                case 6:
                                    weekday_str = "六";
                                    break;
                                case 7:
                                    weekday_str = "日";
                                    break;
                                default:
                                    weekday_str = "{ERROR_WEEKDAY}";
                                    break;
                            }
                            sb.Append("周" + weekday_str);
                            string section_str;
                            switch (section)
                            {
                                case 1:
                                    section_str = "一";
                                    break;
                                case 2:
                                    section_str = "二";
                                    break;
                                case 3:
                                    section_str = "三";
                                    break;
                                case 4:
                                    section_str = "四";
                                    break;
                                case 5:
                                    section_str = "五";
                                    break;
                                case 6:
                                    section_str = "六";
                                    break;
                                case 7:
                                    section_str = "七";
                                    break;
                                case 8:
                                    section_str = "八";
                                    break;
                                default:
                                    section_str = "{ERROR_SECTION}";
                                    break;
                            }
                            sb.Append("第" + section_str + "节");
                        }
                    }
                    catch (Exception e)
                    {

                    }
                }
                else
                {
                    sb.Append("{ERROR_TIME}");
                }
                if (i != separated_strings.Length - 1)
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }
    }
}
