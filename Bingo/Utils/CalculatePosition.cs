using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Utils
{
    public class CalculatePosition
    {

        public static void CalculatePositionX(string drawnBall)
        {

            int positionActual;

            if(drawnBall.Contains('B'))
            {

                positionActual = Session.Session.Instance.NextPositionBX;

                Session.Session.Instance.NextPositionBX = positionActual + 120;

                Session.Session.Instance.NextPositionBY = 135;

            }
            else if(drawnBall.Contains('I'))
            {

                positionActual = Session.Session.Instance.NextPositionIX;

                Session.Session.Instance.NextPositionIX = positionActual + 155;

                Session.Session.Instance.NextPositionIY = 135;

            }
            else if (drawnBall.Contains('N'))
            {

                positionActual = Session.Session.Instance.NextPositionNX;

                Session.Session.Instance.NextPositionNX = positionActual + 180;

                Session.Session.Instance.NextPositionNY = 135;

            }
            else if (drawnBall.Contains('G'))
            {

                positionActual = Session.Session.Instance.NextPositionGX;

                Session.Session.Instance.NextPositionGX = positionActual + 180;

                Session.Session.Instance.NextPositionGY = 135;

            }
            else if (drawnBall.Contains('O'))
            {

                positionActual = Session.Session.Instance.NextPositionOX;

                Session.Session.Instance.NextPositionOX = positionActual + 200;

                Session.Session.Instance.NextPositionOY = 135;

            }

        }

        public static void CalculatePositionY(string drawnBall)
        {

            int positionActual;

            if (drawnBall.Contains('B'))
            {

                positionActual = Session.Session.Instance.NextPositionBY;

                Session.Session.Instance.NextPositionBY = positionActual + 100;

            }
            else if (drawnBall.Contains('I'))
            {

                positionActual = Session.Session.Instance.NextPositionIY;

                Session.Session.Instance.NextPositionIY = positionActual + 100;

            }
            else if (drawnBall.Contains('N'))
            {

                positionActual = Session.Session.Instance.NextPositionNY;

                Session.Session.Instance.NextPositionNY = positionActual + 100;

            }
            else if (drawnBall.Contains('G'))
            {

                positionActual = Session.Session.Instance.NextPositionGY;

                Session.Session.Instance.NextPositionGY = positionActual + 100;

            }
            else if (drawnBall.Contains('O'))
            {

                positionActual = Session.Session.Instance.NextPositionOY;

                Session.Session.Instance.NextPositionOY = positionActual + 100;

            }

        }

    }
}
