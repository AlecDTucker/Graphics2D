//
//  GraphicViewDemo.cs
//  Programmation.Xam.Graphics2D
//
//  Created by David Dancy on 23/01/2015.
//  Copyright (c) 2015 Programmation Pty Limited. All rights reserved.
//
//  Generated by PaintCode (www.paintcodeapp.com)
//



using System;
using System.Drawing;
using Foundation;
using UIKit;
using CoreGraphics;

namespace Programmation.Xam.Graphics2D
{
    [Register ("GraphicViewDemo")]
    public class GraphicViewDemo : NSObject
    {

        //// Initialization

        static GraphicViewDemo()
        {
            // Colors Initialization
            NoneColor = UIColor.FromRGBA(0.000f, 0.000f, 0.000f, 0.000f);
            XamBlueColor = UIColor.FromRGBA(0.168f, 0.518f, 0.825f, 1.000f);

        }

        //// Colors

        public static UIColor NoneColor { get; private set; }
        public static UIColor XamBlueColor { get; private set; }

        //// Drawing Methods

        public static void DrawXamarinlogo()
        {

            //// Page-1
            {
                //// xamarin-logo
                {
                    //// Logo Drawing
                    UIBezierPath logoPath = new UIBezierPath();
                    logoPath.MoveTo(new CGPoint(201.83f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(191.51f, 107.43f));
                    logoPath.AddLineTo(new CGPoint(180.96f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(169.62f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(185.7f, 101.68f));
                    logoPath.AddLineTo(new CGPoint(171.23f, 76.29f));
                    logoPath.AddLineTo(new CGPoint(182.73f, 76.29f));
                    logoPath.AddLineTo(new CGPoint(192.12f, 95.58f));
                    logoPath.AddLineTo(new CGPoint(202.3f, 76.29f));
                    logoPath.AddLineTo(new CGPoint(212.82f, 76.29f));
                    logoPath.AddLineTo(new CGPoint(197.95f, 101.52f));
                    logoPath.AddLineTo(new CGPoint(213.06f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(201.83f, 127.22f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(238.62f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(238.62f, 121.68f));
                    logoPath.AddLineTo(new CGPoint(238.46f, 121.68f));
                    logoPath.AddCurveToPoint(new CGPoint(226.56f, 128.21f), new CGPoint(235.66f, 126.03f), new CGPoint(231.69f, 128.21f));
                    logoPath.AddCurveToPoint(new CGPoint(217.22f, 124.98f), new CGPoint(222.61f, 128.21f), new CGPoint(219.5f, 127.13f));
                    logoPath.AddCurveToPoint(new CGPoint(213.8f, 116.26f), new CGPoint(214.94f, 122.81f), new CGPoint(213.8f, 119.9f));
                    logoPath.AddCurveToPoint(new CGPoint(226.96f, 102.93f), new CGPoint(213.8f, 108.44f), new CGPoint(218.19f, 104.0f));
                    logoPath.AddLineTo(new CGPoint(238.69f, 101.31f));
                    logoPath.AddCurveToPoint(new CGPoint(231.08f, 93.1f), new CGPoint(238.69f, 95.84f), new CGPoint(236.16f, 93.1f));
                    logoPath.AddCurveToPoint(new CGPoint(217.73f, 97.58f), new CGPoint(226.24f, 93.1f), new CGPoint(221.79f, 94.59f));
                    logoPath.AddLineTo(new CGPoint(217.73f, 89.56f));
                    logoPath.AddCurveToPoint(new CGPoint(224.25f, 87.08f), new CGPoint(219.25f, 88.64f), new CGPoint(221.42f, 87.82f));
                    logoPath.AddCurveToPoint(new CGPoint(232.02f, 85.98f), new CGPoint(227.1f, 86.35f), new CGPoint(229.69f, 85.98f));
                    logoPath.AddCurveToPoint(new CGPoint(247.57f, 101.71f), new CGPoint(242.38f, 85.98f), new CGPoint(247.57f, 91.22f));
                    logoPath.AddLineTo(new CGPoint(247.57f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(238.62f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(238.62f, 127.22f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(230.02f, 108.78f));
                    logoPath.AddCurveToPoint(new CGPoint(224.32f, 110.79f), new CGPoint(227.32f, 109.13f), new CGPoint(225.42f, 109.79f));
                    logoPath.AddCurveToPoint(new CGPoint(222.72f, 115.31f), new CGPoint(223.25f, 111.76f), new CGPoint(222.72f, 113.27f));
                    logoPath.AddCurveToPoint(new CGPoint(224.56f, 119.44f), new CGPoint(222.72f, 116.99f), new CGPoint(223.33f, 118.37f));
                    logoPath.AddCurveToPoint(new CGPoint(229.39f, 121.01f), new CGPoint(225.79f, 120.49f), new CGPoint(227.4f, 121.01f));
                    logoPath.AddCurveToPoint(new CGPoint(236.06f, 118.22f), new CGPoint(232.09f, 121.01f), new CGPoint(234.31f, 120.08f));
                    logoPath.AddCurveToPoint(new CGPoint(238.69f, 111.26f), new CGPoint(237.82f, 116.36f), new CGPoint(238.69f, 114.04f));
                    logoPath.AddLineTo(new CGPoint(238.69f, 107.64f));
                    logoPath.AddLineTo(new CGPoint(230.02f, 108.78f));
                    logoPath.AddLineTo(new CGPoint(230.02f, 108.78f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(305.45f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(305.45f, 104.5f));
                    logoPath.AddCurveToPoint(new CGPoint(303.69f, 96.16f), new CGPoint(305.45f, 100.75f), new CGPoint(304.86f, 97.97f));
                    logoPath.AddCurveToPoint(new CGPoint(297.48f, 93.41f), new CGPoint(302.53f, 94.33f), new CGPoint(300.47f, 93.41f));
                    logoPath.AddCurveToPoint(new CGPoint(291.48f, 96.71f), new CGPoint(295.1f, 93.41f), new CGPoint(293.1f, 94.51f));
                    logoPath.AddCurveToPoint(new CGPoint(289.04f, 104.62f), new CGPoint(289.85f, 98.89f), new CGPoint(289.04f, 101.52f));
                    logoPath.AddLineTo(new CGPoint(289.04f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(279.97f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(279.97f, 103.71f));
                    logoPath.AddCurveToPoint(new CGPoint(272.08f, 93.41f), new CGPoint(279.97f, 96.85f), new CGPoint(277.34f, 93.41f));
                    logoPath.AddCurveToPoint(new CGPoint(266.0f, 96.52f), new CGPoint(269.62f, 93.41f), new CGPoint(267.59f, 94.45f));
                    logoPath.AddCurveToPoint(new CGPoint(263.64f, 104.62f), new CGPoint(264.43f, 98.59f), new CGPoint(263.64f, 101.29f));
                    logoPath.AddLineTo(new CGPoint(263.64f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(254.57f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(254.57f, 86.96f));
                    logoPath.AddLineTo(new CGPoint(263.64f, 86.96f));
                    logoPath.AddLineTo(new CGPoint(263.64f, 93.18f));
                    logoPath.AddLineTo(new CGPoint(263.8f, 93.18f));
                    logoPath.AddCurveToPoint(new CGPoint(276.52f, 85.98f), new CGPoint(266.7f, 88.38f), new CGPoint(270.94f, 85.98f));
                    logoPath.AddCurveToPoint(new CGPoint(283.58f, 88.1f), new CGPoint(279.19f, 85.98f), new CGPoint(281.54f, 86.69f));
                    logoPath.AddCurveToPoint(new CGPoint(287.94f, 93.88f), new CGPoint(285.65f, 89.49f), new CGPoint(287.1f, 91.42f));
                    logoPath.AddCurveToPoint(new CGPoint(301.45f, 85.98f), new CGPoint(291.0f, 88.62f), new CGPoint(295.51f, 85.98f));
                    logoPath.AddCurveToPoint(new CGPoint(314.56f, 102.34f), new CGPoint(310.19f, 85.98f), new CGPoint(314.56f, 91.43f));
                    logoPath.AddLineTo(new CGPoint(314.56f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(305.45f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(305.45f, 127.22f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(344.71f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(344.71f, 121.68f));
                    logoPath.AddLineTo(new CGPoint(344.55f, 121.68f));
                    logoPath.AddCurveToPoint(new CGPoint(332.66f, 128.21f), new CGPoint(341.75f, 126.03f), new CGPoint(337.79f, 128.21f));
                    logoPath.AddCurveToPoint(new CGPoint(323.31f, 124.98f), new CGPoint(328.71f, 128.21f), new CGPoint(325.59f, 127.13f));
                    logoPath.AddCurveToPoint(new CGPoint(319.9f, 116.26f), new CGPoint(321.04f, 122.81f), new CGPoint(319.9f, 119.9f));
                    logoPath.AddCurveToPoint(new CGPoint(333.05f, 102.93f), new CGPoint(319.9f, 108.44f), new CGPoint(324.28f, 104.0f));
                    logoPath.AddLineTo(new CGPoint(344.79f, 101.31f));
                    logoPath.AddCurveToPoint(new CGPoint(337.17f, 93.1f), new CGPoint(344.79f, 95.84f), new CGPoint(342.25f, 93.1f));
                    logoPath.AddCurveToPoint(new CGPoint(323.82f, 97.58f), new CGPoint(332.33f, 93.1f), new CGPoint(327.88f, 94.59f));
                    logoPath.AddLineTo(new CGPoint(323.82f, 89.56f));
                    logoPath.AddCurveToPoint(new CGPoint(330.34f, 87.08f), new CGPoint(325.34f, 88.64f), new CGPoint(327.51f, 87.82f));
                    logoPath.AddCurveToPoint(new CGPoint(338.12f, 85.98f), new CGPoint(333.19f, 86.35f), new CGPoint(335.79f, 85.98f));
                    logoPath.AddCurveToPoint(new CGPoint(353.66f, 101.71f), new CGPoint(348.48f, 85.98f), new CGPoint(353.66f, 91.22f));
                    logoPath.AddLineTo(new CGPoint(353.66f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(344.71f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(344.71f, 127.22f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(336.11f, 108.78f));
                    logoPath.AddCurveToPoint(new CGPoint(330.42f, 110.79f), new CGPoint(333.42f, 109.13f), new CGPoint(331.52f, 109.79f));
                    logoPath.AddCurveToPoint(new CGPoint(328.81f, 115.31f), new CGPoint(329.35f, 111.76f), new CGPoint(328.81f, 113.27f));
                    logoPath.AddCurveToPoint(new CGPoint(330.66f, 119.44f), new CGPoint(328.81f, 116.99f), new CGPoint(329.43f, 118.37f));
                    logoPath.AddCurveToPoint(new CGPoint(335.48f, 121.01f), new CGPoint(331.89f, 120.49f), new CGPoint(333.5f, 121.01f));
                    logoPath.AddCurveToPoint(new CGPoint(342.16f, 118.22f), new CGPoint(338.18f, 121.01f), new CGPoint(340.41f, 120.08f));
                    logoPath.AddCurveToPoint(new CGPoint(344.79f, 111.26f), new CGPoint(343.91f, 116.36f), new CGPoint(344.79f, 114.04f));
                    logoPath.AddLineTo(new CGPoint(344.79f, 107.64f));
                    logoPath.AddLineTo(new CGPoint(336.11f, 108.78f));
                    logoPath.AddLineTo(new CGPoint(336.11f, 108.78f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(384.04f, 95.81f));
                    logoPath.AddCurveToPoint(new CGPoint(378.78f, 94.43f), new CGPoint(382.55f, 94.89f), new CGPoint(380.8f, 94.43f));
                    logoPath.AddCurveToPoint(new CGPoint(372.38f, 97.82f), new CGPoint(376.16f, 94.43f), new CGPoint(374.03f, 95.56f));
                    logoPath.AddCurveToPoint(new CGPoint(369.95f, 106.62f), new CGPoint(370.76f, 100.07f), new CGPoint(369.95f, 103.01f));
                    logoPath.AddLineTo(new CGPoint(369.95f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(360.88f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(360.88f, 86.96f));
                    logoPath.AddLineTo(new CGPoint(369.95f, 86.96f));
                    logoPath.AddLineTo(new CGPoint(369.95f, 94.79f));
                    logoPath.AddLineTo(new CGPoint(370.1f, 94.79f));
                    logoPath.AddCurveToPoint(new CGPoint(380.39f, 86.26f), new CGPoint(372.04f, 89.1f), new CGPoint(375.47f, 86.26f));
                    logoPath.AddCurveToPoint(new CGPoint(384.04f, 86.81f), new CGPoint(381.99f, 86.26f), new CGPoint(383.2f, 86.44f));
                    logoPath.AddLineTo(new CGPoint(384.04f, 95.81f));
                    logoPath.AddLineTo(new CGPoint(384.04f, 95.81f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(393.07f, 77.96f));
                    logoPath.AddCurveToPoint(new CGPoint(389.14f, 76.47f), new CGPoint(391.53f, 77.96f), new CGPoint(390.22f, 77.46f));
                    logoPath.AddCurveToPoint(new CGPoint(387.53f, 72.73f), new CGPoint(388.07f, 75.44f), new CGPoint(387.53f, 74.2f));
                    logoPath.AddCurveToPoint(new CGPoint(389.14f, 68.92f), new CGPoint(387.53f, 71.21f), new CGPoint(388.07f, 69.94f));
                    logoPath.AddCurveToPoint(new CGPoint(393.07f, 67.38f), new CGPoint(390.22f, 67.9f), new CGPoint(391.53f, 67.38f));
                    logoPath.AddCurveToPoint(new CGPoint(397.04f, 68.96f), new CGPoint(394.64f, 67.38f), new CGPoint(395.96f, 67.91f));
                    logoPath.AddCurveToPoint(new CGPoint(398.64f, 72.73f), new CGPoint(398.11f, 69.98f), new CGPoint(398.64f, 71.24f));
                    logoPath.AddCurveToPoint(new CGPoint(397.04f, 76.47f), new CGPoint(398.64f, 74.2f), new CGPoint(398.11f, 75.44f));
                    logoPath.AddCurveToPoint(new CGPoint(393.07f, 77.96f), new CGPoint(395.96f, 77.46f), new CGPoint(394.64f, 77.96f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(388.44f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(388.44f, 86.96f));
                    logoPath.AddLineTo(new CGPoint(397.51f, 86.96f));
                    logoPath.AddLineTo(new CGPoint(397.51f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(388.44f, 127.22f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(431.78f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(431.78f, 104.62f));
                    logoPath.AddCurveToPoint(new CGPoint(423.73f, 93.41f), new CGPoint(431.78f, 97.15f), new CGPoint(429.1f, 93.41f));
                    logoPath.AddCurveToPoint(new CGPoint(416.94f, 96.52f), new CGPoint(421.04f, 93.41f), new CGPoint(418.77f, 94.45f));
                    logoPath.AddCurveToPoint(new CGPoint(414.23f, 104.34f), new CGPoint(415.14f, 98.56f), new CGPoint(414.23f, 101.17f));
                    logoPath.AddLineTo(new CGPoint(414.23f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(405.16f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(405.16f, 86.96f));
                    logoPath.AddLineTo(new CGPoint(414.23f, 86.96f));
                    logoPath.AddLineTo(new CGPoint(414.23f, 93.41f));
                    logoPath.AddLineTo(new CGPoint(414.39f, 93.41f));
                    logoPath.AddCurveToPoint(new CGPoint(427.42f, 85.98f), new CGPoint(417.32f, 88.46f), new CGPoint(421.67f, 85.98f));
                    logoPath.AddCurveToPoint(new CGPoint(440.85f, 102.49f), new CGPoint(436.38f, 85.98f), new CGPoint(440.85f, 91.49f));
                    logoPath.AddLineTo(new CGPoint(440.85f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(431.78f, 127.22f));
                    logoPath.AddLineTo(new CGPoint(431.78f, 127.22f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(71.43f, 56.0f));
                    logoPath.AddCurveToPoint(new CGPoint(64.59f, 59.97f), new CGPoint(68.68f, 56.01f), new CGPoint(65.98f, 57.57f));
                    logoPath.AddLineTo(new CGPoint(43.02f, 97.53f));
                    logoPath.AddCurveToPoint(new CGPoint(43.02f, 105.47f), new CGPoint(41.66f, 99.93f), new CGPoint(41.66f, 103.07f));
                    logoPath.AddLineTo(new CGPoint(64.59f, 143.03f));
                    logoPath.AddCurveToPoint(new CGPoint(71.43f, 147.0f), new CGPoint(65.98f, 145.43f), new CGPoint(68.68f, 146.99f));
                    logoPath.AddLineTo(new CGPoint(114.57f, 147.0f));
                    logoPath.AddCurveToPoint(new CGPoint(121.41f, 143.03f), new CGPoint(117.32f, 146.99f), new CGPoint(120.02f, 145.43f));
                    logoPath.AddLineTo(new CGPoint(142.98f, 105.47f));
                    logoPath.AddCurveToPoint(new CGPoint(142.98f, 97.53f), new CGPoint(144.34f, 103.07f), new CGPoint(144.34f, 99.93f));
                    logoPath.AddLineTo(new CGPoint(121.41f, 59.97f));
                    logoPath.AddCurveToPoint(new CGPoint(114.57f, 56.0f), new CGPoint(120.02f, 57.57f), new CGPoint(117.32f, 56.01f));
                    logoPath.AddLineTo(new CGPoint(71.43f, 56.0f));
                    logoPath.ClosePath();
                    logoPath.MoveTo(new CGPoint(71.82f, 77.98f));
                    logoPath.AddCurveToPoint(new CGPoint(72.0f, 77.98f), new CGPoint(71.88f, 77.97f), new CGPoint(71.94f, 77.97f));
                    logoPath.AddLineTo(new CGPoint(79.44f, 77.98f));
                    logoPath.AddCurveToPoint(new CGPoint(80.26f, 78.46f), new CGPoint(79.77f, 77.98f), new CGPoint(80.09f, 78.18f));
                    logoPath.AddLineTo(new CGPoint(92.88f, 101.02f));
                    logoPath.AddCurveToPoint(new CGPoint(93.0f, 101.38f), new CGPoint(92.94f, 101.13f), new CGPoint(92.98f, 101.25f));
                    logoPath.AddCurveToPoint(new CGPoint(93.12f, 101.02f), new CGPoint(93.02f, 101.25f), new CGPoint(93.06f, 101.13f));
                    logoPath.AddLineTo(new CGPoint(105.71f, 78.46f));
                    logoPath.AddCurveToPoint(new CGPoint(106.55f, 77.98f), new CGPoint(105.88f, 78.17f), new CGPoint(106.22f, 77.98f));
                    logoPath.AddLineTo(new CGPoint(114.0f, 77.98f));
                    logoPath.AddCurveToPoint(new CGPoint(114.84f, 79.4f), new CGPoint(114.65f, 77.98f), new CGPoint(115.15f, 78.82f));
                    logoPath.AddLineTo(new CGPoint(102.52f, 101.5f));
                    logoPath.AddLineTo(new CGPoint(114.84f, 123.57f));
                    logoPath.AddCurveToPoint(new CGPoint(114.0f, 125.02f), new CGPoint(115.18f, 124.16f), new CGPoint(114.67f, 125.03f));
                    logoPath.AddLineTo(new CGPoint(106.55f, 125.02f));
                    logoPath.AddCurveToPoint(new CGPoint(105.71f, 124.51f), new CGPoint(106.21f, 125.02f), new CGPoint(105.87f, 124.81f));
                    logoPath.AddLineTo(new CGPoint(93.12f, 101.95f));
                    logoPath.AddCurveToPoint(new CGPoint(93.0f, 101.59f), new CGPoint(93.06f, 101.84f), new CGPoint(93.02f, 101.72f));
                    logoPath.AddCurveToPoint(new CGPoint(92.88f, 101.95f), new CGPoint(92.98f, 101.72f), new CGPoint(92.94f, 101.84f));
                    logoPath.AddLineTo(new CGPoint(80.26f, 124.51f));
                    logoPath.AddCurveToPoint(new CGPoint(79.44f, 125.02f), new CGPoint(80.1f, 124.81f), new CGPoint(79.78f, 125.01f));
                    logoPath.AddLineTo(new CGPoint(72.0f, 125.02f));
                    logoPath.AddCurveToPoint(new CGPoint(71.16f, 123.57f), new CGPoint(71.33f, 125.03f), new CGPoint(70.82f, 124.16f));
                    logoPath.AddLineTo(new CGPoint(83.48f, 101.5f));
                    logoPath.AddLineTo(new CGPoint(71.16f, 79.4f));
                    logoPath.AddCurveToPoint(new CGPoint(71.82f, 77.98f), new CGPoint(70.86f, 78.87f), new CGPoint(71.23f, 78.09f));
                    logoPath.AddLineTo(new CGPoint(71.82f, 77.98f));
                    logoPath.ClosePath();
                    logoPath.MiterLimit = 4.0f;

                    logoPath.UsesEvenOddFillRule = true;

                    GraphicViewDemo.XamBlueColor.SetFill();
                    logoPath.Fill();
                }
            }
        }

    }
}
