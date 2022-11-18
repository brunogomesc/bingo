using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Utils
{
    public class GetPosition
    {

        public static int GetPositionX(int number)
        {
            int positionX = 0;
            if (number >= 1 && number <= 15) positionX = Session.Session.Instance.NextPositionBX;
            else if (number > 15 && number <= 30) positionX = Session.Session.Instance.NextPositionIX;
            else if (number > 30 && number <= 45) positionX = Session.Session.Instance.NextPositionNX;
            else if (number > 45 && number <= 60) positionX = Session.Session.Instance.NextPositionGX;
            else if (number > 60 && number <= 75) positionX = Session.Session.Instance.NextPositionOX;
            return positionX;
        }

        public static int GetPositionY(int number)
        {
            int positionY = 0;
            if (number >= 1 && number <= 15) positionY = Session.Session.Instance.NextPositionBY;
            else if (number > 15 && number <= 30) positionY = Session.Session.Instance.NextPositionIY;
            else if (number > 30 && number <= 45) positionY = Session.Session.Instance.NextPositionNY;
            else if (number > 45 && number <= 60) positionY = Session.Session.Instance.NextPositionGY;
            else if (number > 60 && number <= 75) positionY = Session.Session.Instance.NextPositionOY;
            return positionY;
        }

        public static void SetValuesInitialSession()
        {

            //B
            Session.Session.Instance.NextPositionBX = 10;
            Session.Session.Instance.NextPositionBY = 140;

            //I
            Session.Session.Instance.NextPositionIX = 280;
            Session.Session.Instance.NextPositionIY = 140;

            //N
            Session.Session.Instance.NextPositionNX = 585;
            Session.Session.Instance.NextPositionNY = 140;

            //G
            Session.Session.Instance.NextPositionGX = 935;
            Session.Session.Instance.NextPositionGY = 140;

            //O
            Session.Session.Instance.NextPositionOX = 1290;
            Session.Session.Instance.NextPositionOY = 140;

            //Current Ball
            Session.Session.Instance.CurrentBall = 0;

        }

    }
}
