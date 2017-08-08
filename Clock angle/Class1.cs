using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;               */


namespace Clock_angle
{
    public class clockangle
    {

        //this project features (;) after every comment because equality;
        // And no i won't write (//) in front of every code in the name of the equality;

        /// <summary>
        ///Returns  angle between hour and minute hands of 
        ///the clock in  Degree and Decimals(DD) format, with hour hand angle being affected by minute hand. current system time is used upon no arguments
        /// </summary>
        /// <param name="hh"></param>
        /// <param name="mm"></param>
        /// <returns></returns>
        static public float Hands_angle_precise(short hh, short mm)
        {

            if (hh >= 12)                                            //support for 24 hour format
                hh -= 12;

            if (hh > 24 || hh < 0 || mm > 60 || mm < 0)              //invalid input will not be tolerated;
                return -1.0f;

            //float angle;

            //float minute = (30f / 5f) * mm;                          //calculates minute hands angle w.r.t 12 o'clock;
            //float hour = ((30f * hh) + (.5f * mm));                  //calculates hour angle w.r.t 12 and correction of minute hand is added;

            //angle = (minute - hour);                                 //calculate the difference;

            //angle = Math.Abs(angle);

            //EVERYTHING HAPPENING IN THE FOLLOWING RETURN STATEMENT IS A MASHUP OF ALL THE ABOVE COMMENTED OUT CODE IN TERNARY OPERATOR;

            return Math.Abs(((30f / 5f) * mm) - ((30f * hh) + (.5f * mm))) > 180 ? (360 - Math.Abs(((30f / 5f) * mm) - ((30f * hh) + (.5f * mm)))) : Math.Abs(((30f / 5f) * mm) - ((30f * hh) + (.5f * mm)));                //returns acute angle between two hands, add 180 to the method output or remove code of c** to enable obtuce value;
        }

        /// <summary>
        ///Returns  angle between hour and minute hands of 
        ///the clock in  Degree and Decimals(DD) format with hour hand angle unaffected by the minutes passed
        /// </summary>
        /// <param name="hh"></param>
        /// <param name="mm"></param>
        /// <returns></returns>
        static public float Hands_angle(short hh, short mm)
        {

            if (hh >= 12)                                            //support for 24 hour format
                hh -= 12;

            if (hh > 24 || hh < 0 || mm > 60 || mm < 0)              //invalid input will not be tolerated;
                return -1.0f;

            //float angle;

            //float minute = (30f / 5f) * mm;                          //calculates minute hands angle w.r.t 12 o'clock;
            //float hour = (30f * hh);                                 //angle of hour hand w.r.t to 12 o'clock;

            //angle = (minute - hour);                                 //calculate the difference;

            //angle = Math.Abs(angle);

            //EVERYTHING HAPPENING IN THE FOLLOWING RETURN STATEMENT IS A MASHUP OF ALL THE ABOVE COMMENTED OUT CODE IN TERNARY OPERATOR;

            return Math.Abs(((30f / 5f) * mm) - (30f * hh)) > 180 ? (360 - Math.Abs(((30f / 5f) * mm) - (30f * hh))) : Math.Abs(((30f / 5f) * mm) - (30f * hh));                //returns acute angle between two hands, add 180 to the method output or remove code of c** to enable obtuce value;
        }

        /// <summary>
        ///Returns  angle between hour and minute hands of 
        ///the clock in  Degree and Decimals(DD) format, with hour hand angle being affected by minutes passed. current system time is used upon no arguments
        /// </summary>
        /// <param name="hh"></param>
        /// <param name="mm"></param>
        /// <returns></returns>
        static public float Hands_angle_precise()
        {
            DateTime time = DateTime.Now;
            short hh = (short)time.Hour;
            short mm = (short)time.Minute;
            if (hh >= 12)                                            //support for 24 hour format
                hh -= 12;

            if (hh > 24 || hh < 0 || mm > 60 || mm < 0)              //invalid input will not be tolerated;
                return -1.0f;

            //float angle;

            //float minute = (30f / 5f) * mm;                          //calculates minute hands angle w.r.t 12 o'clock;
            //float hour = ((30f * hh) + (.5f * mm));                  //calculates hour angle w.r.t 12 and correction of minute hand is added;

            //angle = (minute - hour);                                 //calculate the difference;

            //angle = Math.Abs(angle);

            //EVERYTHING HAPPENING IN THE FOLLOWING RETURN STATEMENT IS A MASHUP OF ALL THE ABOVE COMMENTED OUT CODE IN TERNARY OPERATOR;

            return Math.Abs(((30f / 5f) * mm) - ((30f * hh) + (.5f * mm))) > 180 ? (360 - Math.Abs(((30f / 5f) * mm) - ((30f * hh) + (.5f * mm)))) : Math.Abs(((30f / 5f) * mm) - ((30f * hh) + (.5f * mm)));                //returns acute angle between two hands, add 180 to the method output or remove code of c** to enable obtuce value;
        }

        /// <summary>
        ///Returns  angle between hour and minute hands of 
        ///the clock in  Degree and Decimals(DD) format, With hour hand angle unaffected by the minutes passed
        /// </summary>
        /// <param name="hh"></param>
        /// <param name="mm"></param>
        /// <returns></returns>
        static public float Hands_angle()
        {
            DateTime time = DateTime.Now;
            short hh = (short)time.Hour;
            short mm = (short)time.Minute;
            if (hh >= 12)                                            //support for 24 hour format
                hh -= 12;


            //float angle;

            //float minute = (30f / 5f) * mm;                          //calculates minute hands angle w.r.t 12 o'clock;
            //float hour = (30f * hh);                                 //calculates hour angle w.r.t 12;

            //angle = (minute - hour);                                 //calculate the difference;

            //angle = Math.Abs(angle);

            //EVERYTHING HAPPENING IN THE FOLLOWING RETURN STATEMENT IS A MASHUP OF ALL THE ABOVE COMMENTED OUT CODE IN TERNARY OPERATOR;

            return Math.Abs(((30f / 5f) * mm) - (30f * hh)) > 180 ? (360 - Math.Abs(((30f / 5f) * mm) - (30f * hh))) : Math.Abs(((30f / 5f) * mm) - (30f * hh));                 //returns acute angle between two hands, add 180 to the method output or remove code of c** to enable obtuce value;
        }

    }
}