﻿using FlickrWFA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickrWFA
{
    public class Presenter
    {
        public IView View { get; set; }
        public Presenter(IView view)
        {
            View = view;
            view.htmlString = "<!DOCTYPE html><html style=\"background-color:#99B4D1\"><table><tr><td><img src=\"https://live.staticflickr.com/65535/52274753338_908cb2c2f1_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52274727733_a0a9105a28_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52274960814_efb643b4b9_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52275179275_f7355e2cf8_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52274729683_5060e26cd0_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> </tr><tr><td><img src=\"https://live.staticflickr.com/65535/52274953389_487c8d757d_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52275181385_95bcd39c0c_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52274708421_ce5d94a813_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52274702921_64ee00cb68_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52274686203_56f471bed5_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> </tr><tr><td><img src=\"https://live.staticflickr.com/65535/52273693397_ac5b9f14c8_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52273706452_b2e14273d2_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52273672502_255c597d00_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52273669577_0fb540f39d_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52275135905_b3a460313b_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> </tr><tr><td><img src=\"https://live.staticflickr.com/65535/52273673647_a055b1aa9f_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52274921819_93ace6b77b_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52273691602_49cc77a138_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52274926854_ce7e5706c7_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> <td><img src=\"https://live.staticflickr.com/65535/52274629826_4515a527d4_m.jpg\" alt=\"nature\" style=\"width:100px; height:100px; margin: 0px; margni-top:-4px\"></td> </tr></table></html>";
        }
    }
}
