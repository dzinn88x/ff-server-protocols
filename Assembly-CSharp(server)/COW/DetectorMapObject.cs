using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C56 RID: 7254
	[Token(Token = "0x2001C56")]
	public class DetectorMapObject
	{
		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06009DE0 RID: 40416 RVA: 0x00029508 File Offset: 0x00027708
		[Token(Token = "0x17000A6D")]
		public bool Stopped
		{
			[Token(Token = "0x6009DE0")]
			[Address(RVA = "0x16017C4", Offset = "0x16017C4", VA = "0x7BBBE017C4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009DE1 RID: 40417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DE1")]
		[Address(RVA = "0x16017EC", Offset = "0x16017EC", VA = "0x7BBBE017EC")]
		internal void OnUIInit(Transform container, ]XMFBq\u0081 d, Transform detector, UISprite circle, UISprite point, UISprite car, TweenScale tweenScale, float scale, bool fadeLine)
		{
		}

		// Token: 0x06009DE2 RID: 40418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DE2")]
		[Address(RVA = "0x1601EA0", Offset = "0x1601EA0", VA = "0x7BBBE01EA0")]
		public void SetAirLineSprites(UISprite line, UISprite start, UISprite end)
		{
		}

		// Token: 0x06009DE3 RID: 40419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DE3")]
		[Address(RVA = "0x16025D8", Offset = "0x16025D8", VA = "0x7BBBE025D8")]
		public void OnUIDestory()
		{
		}

		// Token: 0x06009DE4 RID: 40420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DE4")]
		[Address(RVA = "0x16029C0", Offset = "0x16029C0", VA = "0x7BBBE029C0")]
		public void Update(float rotAngles)
		{
		}

		// Token: 0x06009DE5 RID: 40421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DE5")]
		[Address(RVA = "0x1603FC0", Offset = "0x1603FC0", VA = "0x7BBBE03FC0")]
		public void UpdateDetectorPointScale(float map_scale_ratio = 1f)
		{
		}

		// Token: 0x06009DE6 RID: 40422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DE6")]
		[Address(RVA = "0x1603AE8", Offset = "0x1603AE8", VA = "0x7BBBE03AE8")]
		private void UpdateFading()
		{
		}

		// Token: 0x06009DE7 RID: 40423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DE7")]
		[Address(RVA = "0x1603A08", Offset = "0x1603A08", VA = "0x7BBBE03A08")]
		private void ShowCircleTween()
		{
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DE8")]
		[Address(RVA = "0x1603A54", Offset = "0x1603A54", VA = "0x7BBBE03A54")]
		private void HideCircleTween()
		{
		}

		// Token: 0x06009DE9 RID: 40425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DE9")]
		[Address(RVA = "0x1603328", Offset = "0x1603328", VA = "0x7BBBE03328")]
		private void ShowPoints(List<Vector3> ps, float angle, UISprite sprite, List<DetectorMapObject.Point> points)
		{
		}

		// Token: 0x06009DEA RID: 40426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DEA")]
		[Address(RVA = "0x1602688", Offset = "0x1602688", VA = "0x7BBBE02688")]
		private void DestroyPoints()
		{
		}

		// Token: 0x06009DEB RID: 40427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DEB")]
		[Address(RVA = "0x160414C", Offset = "0x160414C", VA = "0x7BBBE0414C")]
		private void HidePoints()
		{
		}

		// Token: 0x06009DEC RID: 40428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DEC")]
		[Address(RVA = "0x1601ECC", Offset = "0x1601ECC", VA = "0x7BBBE01ECC")]
		private void SetupAirLine()
		{
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DED")]
		[Address(RVA = "0x16032B0", Offset = "0x16032B0", VA = "0x7BBBE032B0")]
		private void ShowAirLine()
		{
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DEE")]
		[Address(RVA = "0x1602544", Offset = "0x1602544", VA = "0x7BBBE02544")]
		private void HideAirLine()
		{
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DEF")]
		[Address(RVA = "0x160451C", Offset = "0x160451C", VA = "0x7BBBE0451C")]
		private void SetAirLineAlpha(float alpha)
		{
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DF0")]
		[Address(RVA = "0x1604450", Offset = "0x1604450", VA = "0x7BBBE04450")]
		private void SetAirLineActive(bool active)
		{
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DF1")]
		[Address(RVA = "0x16045AC", Offset = "0x16045AC", VA = "0x7BBBE045AC")]
		public DetectorMapObject()
		{
		}

		// Token: 0x0400A415 RID: 42005
		[Token(Token = "0x400A415")]
		[FieldOffset(Offset = "0x10")]
		private DetectorMapObjectModel m_Model;

		// Token: 0x0400A416 RID: 42006
		[Token(Token = "0x400A416")]
		[FieldOffset(Offset = "0x18")]
		private Transform m_MapContainer;

		// Token: 0x0400A417 RID: 42007
		[Token(Token = "0x400A417")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_Detector;

		// Token: 0x0400A418 RID: 42008
		[Token(Token = "0x400A418")]
		[FieldOffset(Offset = "0x28")]
		private UISprite m_Point;

		// Token: 0x0400A419 RID: 42009
		[Token(Token = "0x400A419")]
		[FieldOffset(Offset = "0x30")]
		private UISprite m_Circle;

		// Token: 0x0400A41A RID: 42010
		[Token(Token = "0x400A41A")]
		[FieldOffset(Offset = "0x38")]
		private UISprite m_CarPoint;

		// Token: 0x0400A41B RID: 42011
		[Token(Token = "0x400A41B")]
		[FieldOffset(Offset = "0x40")]
		private TweenScale m_CircleTween;

		// Token: 0x0400A41C RID: 42012
		[Token(Token = "0x400A41C")]
		[FieldOffset(Offset = "0x48")]
		private List<DetectorMapObject.Point> m_Points;

		// Token: 0x0400A41D RID: 42013
		[Token(Token = "0x400A41D")]
		[FieldOffset(Offset = "0x50")]
		private List<DetectorMapObject.Point> m_CarPoints;

		// Token: 0x0400A41E RID: 42014
		[Token(Token = "0x400A41E")]
		[FieldOffset(Offset = "0x58")]
		private float m_RangeOnMap;

		// Token: 0x0400A41F RID: 42015
		[Token(Token = "0x400A41F")]
		[FieldOffset(Offset = "0x5C")]
		private float m_Scale;

		// Token: 0x0400A420 RID: 42016
		[Token(Token = "0x400A420")]
		[FieldOffset(Offset = "0x60")]
		private UISprite m_AirLine;

		// Token: 0x0400A421 RID: 42017
		[Token(Token = "0x400A421")]
		[FieldOffset(Offset = "0x68")]
		private UISprite m_AirLineStart;

		// Token: 0x0400A422 RID: 42018
		[Token(Token = "0x400A422")]
		[FieldOffset(Offset = "0x70")]
		private UISprite m_AirLineEnd;

		// Token: 0x0400A423 RID: 42019
		[Token(Token = "0x400A423")]
		[FieldOffset(Offset = "0x78")]
		private bool m_AirLineVisible;

		// Token: 0x0400A424 RID: 42020
		[Token(Token = "0x400A424")]
		[FieldOffset(Offset = "0x7C")]
		private int m_LastDetectFrame;

		// Token: 0x0400A425 RID: 42021
		[Token(Token = "0x400A425")]
		[FieldOffset(Offset = "0x80")]
		public float m_FadeStartTime;

		// Token: 0x0400A426 RID: 42022
		[Token(Token = "0x400A426")]
		[FieldOffset(Offset = "0x84")]
		public float m_FadeEndTime;

		// Token: 0x0400A427 RID: 42023
		[Token(Token = "0x400A427")]
		[FieldOffset(Offset = "0x88")]
		private float m_InitialPointRotAngle;

		// Token: 0x0400A428 RID: 42024
		[Token(Token = "0x400A428")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_FadeLine;

		// Token: 0x02001C57 RID: 7255
		[Token(Token = "0x2001C57")]
		private class Point
		{
			// Token: 0x06009DF2 RID: 40434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DF2")]
			[Address(RVA = "0x1604448", Offset = "0x1604448", VA = "0x7BBBE04448")]
			public Point()
			{
			}

			// Token: 0x0400A429 RID: 42025
			[Token(Token = "0x400A429")]
			[FieldOffset(Offset = "0x10")]
			public UISprite Sprite;

			// Token: 0x0400A42A RID: 42026
			[Token(Token = "0x400A42A")]
			[FieldOffset(Offset = "0x18")]
			public TweenAlpha TweenAlpha;

			// Token: 0x0400A42B RID: 42027
			[Token(Token = "0x400A42B")]
			[FieldOffset(Offset = "0x20")]
			public Transform SpriteTrans;
		}
	}
}
