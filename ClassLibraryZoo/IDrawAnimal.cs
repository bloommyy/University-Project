using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preslav.ZooGame.ClassLibraryZoo
{
    public interface IDrawAnimal
    {
        void DrawHead(Animal animal, int outlineSize, Rectangle? headRectangle
            , Rectangle? leftFaceCircle, Rectangle? rightFaceCircle, Rectangle? leftEye, Rectangle? rightEye, Rectangle? mouth);

        void DrawBody(Animal animal, int outlineSize, Rectangle? bodyRectangle);

        void DrawLegs(Animal animal, int outlineSize,
            Rectangle[] legs, Rectangle? leftPenguinLeg, Rectangle? rightPenguinLeg);

        void DrawSpecials(Animal animal, int outlineSize,
            int? trunkContour, int? trunkWidth, Point[] curvePoints,
            Rectangle? stomach, Rectangle? leftWing, Rectangle? rightWing);
    }
}
